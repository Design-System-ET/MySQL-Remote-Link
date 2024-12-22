namespace MySQL_Remote_Link
{
    public partial class NewConnection : Form
    {
        public string ConnectionName => textBox1.Text;
        public string Host => textBox2.Text;
        public string User => textBox4.Text;
        public string Password => textBox5.Text;


        public NewConnection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Esto cierra el formulario y marca que se aceptaron los datos.
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
