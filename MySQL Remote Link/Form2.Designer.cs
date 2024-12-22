namespace MySQL_Remote_Link
{
    partial class NewConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(469, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(469, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 27);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(290, 293);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(390, 293);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Accept";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 28);
            label1.TabIndex = 6;
            label1.Text = "Fill in the data for the new connection";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(471, 20);
            label2.TabIndex = 7;
            label2.Text = "_____________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 8;
            label3.Text = "Connection Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 123);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "URL Data Base";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 186);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 11;
            label6.Text = "User";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 186);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 12;
            label7.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(254, 209);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(230, 27);
            textBox5.TabIndex = 13;
            // 
            // NewConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 335);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            MaximizeBox = false;
            MaximumSize = new Size(514, 382);
            MinimizeBox = false;
            MinimumSize = new Size(514, 382);
            Name = "NewConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Conection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
    }
}