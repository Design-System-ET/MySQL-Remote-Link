using System.Diagnostics;
using Newtonsoft.Json;

namespace MySQL_Remote_Link
{
    public partial class Form1 : Form
    {
        private Process cmdProcess;
        private StreamWriter cmdStreamWriter;
        string cmdClear = "SYSTEM cls;";

        public Form1()
        {
            InitializeComponent();
            ComboBox();
        }

        private void ComboBox()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Collation));
        }

        private void newConectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConnection connectionForm = new NewConnection();
            if (connectionForm.ShowDialog() == DialogResult.OK)
            {
                var connectionData = new
                {
                    Name = connectionForm.ConnectionName,
                    Host = connectionForm.Host,
                    User = connectionForm.User,
                    Password = connectionForm.Password
                };

                SaveConnectionData(connectionData);
                MessageBox.Show("La nueva conexión se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveConnectionData(object connectionData)
        {
            string filePath = "connections.json";
            List<Connection> connections = LoadConnections();

            connections.Add(new Connection
            {
                Name = ((dynamic)connectionData).Name,
                Host = ((dynamic)connectionData).Host,
                User = ((dynamic)connectionData).User,
                Password = ((dynamic)connectionData).Password
            });

            File.WriteAllText(filePath, JsonConvert.SerializeObject(connections, Newtonsoft.Json.Formatting.Indented));
        }

        private List<Connection> LoadConnections()
        {
            string filePath = "connections.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Connection>>(json) ?? new List<Connection>();
            }
            return new List<Connection>();
        }

        private void startConectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Connection> connections = LoadConnections();

            if (connections.Count > 0)
            {
                startConectionToolStripMenuItem.DropDownItems.Clear();

                foreach (var connection in connections)
                {
                    ToolStripMenuItem connectionItem = new ToolStripMenuItem(connection.Name);
                    connectionItem.Click += (s, args) => StartConnection(connection);
                    startConectionToolStripMenuItem.DropDownItems.Add(connectionItem);
                }

                WriteToConsole(consoleTextBox, "Connection list loaded", Color.Blue);
            }
            else
            {
                MessageBox.Show("No hay conexiones guardadas.", "Sin Conexiones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StartConnection(Connection connection)
        {
            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                WriteToConsole(consoleTextBox, "Existe una conexion en ejecucion aun, debe finalizarla para abrir una nueva", Color.Orange);
            }
            else
            {
                string user = connection.User;
                string host = connection.Host;
                string password = connection.Password;

                string cmdCommand = $"mysql -u {user} -p{password} -h {host}";

                // Mostrar el comando ejecutado en consoleTextBox
                WriteToConsole(consoleTextBox, $"Estableciendo conexion con: mysql -u ****** -p****** -h {host}", Color.Blue);

                // Ejecutar el comando en una ventana de cmd visible
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/K",  // Mantener la ventana abierta después de ejecutar el comando
                    UseShellExecute = false,  // No usar la interfaz del shell
                    RedirectStandardInput = true,  // Redirigir la entrada estándar
                    CreateNoWindow = false,  // Crear una ventana visible
                    Verb = "runas"  // Ejecutar como administrador
                };

                cmdProcess = new Process
                {
                    StartInfo = processInfo
                };

                cmdProcess.Start();
                cmdStreamWriter = cmdProcess.StandardInput;


                // Ejecutar el comando inicial y limpiar pantalla
                cmdStreamWriter.WriteLine(cmdCommand);
                cmdStreamWriter.WriteLine(cmdClear);
            }
        }

        public void WriteToConsole(Control control, string output, Color color)
        {
            if (consoleTextBox.IsHandleCreated && !consoleTextBox.IsDisposed)
            {
                consoleTextBox.Invoke((MethodInvoker)delegate
                {
                    control.ResetText();
                    control.Text = (output);
                    control.ForeColor = color;

                    //consoleTextBox.AppendText(output + Environment.NewLine);
                    consoleTextBox.ScrollToCaret();
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                cmdStreamWriter.WriteLine(cmdClear);

                cmdStreamWriter.WriteLine("show databases;");
                WriteToConsole(consoleTextBox, "Comando enviado: SHOW databases;", Color.Blue);
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbName = textBox1.Text;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                if (!string.IsNullOrEmpty(dbName))
                {
                    cmdStreamWriter.WriteLine(cmdClear);

                    string command = $"USE " + dbName + ";";
                    cmdStreamWriter.WriteLine(command);
                    WriteToConsole(consoleTextBox, $"Comando enviado: USE {dbName};", Color.Blue);
                }
                else
                {
                    WriteToConsole(consoleTextBox, "Debe indicar el nombre de la BD", Color.Orange);
                }

            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bd = textBox1.Text;

            if (cmdProcess != null && !cmdProcess.HasExited)
            {

                if (!string.IsNullOrEmpty(bd))
                {
                    cmdStreamWriter.WriteLine(cmdClear);

                    cmdStreamWriter.WriteLine("show tables;");
                    WriteToConsole(consoleTextBox, "Comando enviado: SHOW tables;", Color.Blue);
                }
                else
                {
                    WriteToConsole(consoleTextBox, "Debe seleccionar una BD", Color.Orange);
                }
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tableName = textBox2.Text;
            string dbName = textBox1.Text;

            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(dbName))
                {
                    cmdStreamWriter.WriteLine(cmdClear);

                    string command = $"DESCRIBE " + tableName + ";";
                    cmdStreamWriter.WriteLine(command);
                    WriteToConsole(consoleTextBox, $"Comando enviado: DESCRIBE {tableName};", Color.Blue);
                }
                else
                {
                    WriteToConsole(consoleTextBox, "Debe indicar el nombre de la BD y el nombre de la tabla", Color.Orange);
                }
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                cmdStreamWriter.WriteLine(cmdClear);
                WriteToConsole(consoleTextBox, "Comando enviado: Clear;", Color.Blue);
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                WriteToConsole(consoleTextBox, "Para cerrar debe finalizar la ejecucion de la conexion", Color.Orange);
            }
            else
            {
                Close();
            }
        }

        private void disconectBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                cmdStreamWriter.WriteLine("exit");
                cmdStreamWriter.WriteLine("exit");
                WriteToConsole(consoleTextBox, "Comando enviado: se desconecto de la BD;", Color.Blue);
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string newBD = textBox3.Text;
            string collation = comboBox1.Text;

            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                cmdStreamWriter.WriteLine(cmdClear);

                string command = $"CREATE DATABASE " + newBD + " CHARACTER SET " + collation + ";";
                cmdStreamWriter.WriteLine(command);
                WriteToConsole(consoleTextBox, $"Comando enviado: CREATE DATABASE {newBD};", Color.Blue);
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string tableName = textBox2.Text;
            string dbName = textBox1.Text;

            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(dbName))
                {
                    cmdStreamWriter.WriteLine(cmdClear);

                    string command = $"SELECT * FROM " + tableName + ";";
                    cmdStreamWriter.WriteLine(command);
                    WriteToConsole(consoleTextBox, $"Comando enviado: SELECT * FROM {tableName};", Color.Blue);
                }
                else
                {
                    WriteToConsole(consoleTextBox, "Debe indicar el nombre de la tabla", Color.Orange);
                }
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string newTable = textBox4.Text;
            string paramenters = textBox5.Text;

            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                if (!string.IsNullOrEmpty(newTable) && !string.IsNullOrEmpty(paramenters))
                {
                    cmdStreamWriter.WriteLine(cmdClear);

                    string command = $"CREATE TABLE " + newTable + " " + paramenters + ";";
                    cmdStreamWriter.WriteLine(command);
                    WriteToConsole(consoleTextBox, $"Comando enviado: CREATE TABLE {newTable};", Color.Blue);
                }
                else
                {
                    WriteToConsole(consoleTextBox, "Debe iniciar una BD e indicar el nombre de la tabla y los parametros a crear", Color.Orange);
                }
            }
            else
            {
                WriteToConsole(consoleTextBox, "El proceso cmd no está en ejecución.", Color.Red);
            }
        }
    }
}