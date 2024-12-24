namespace MySQL_Remote_Link
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(157, 39);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 1;
            label1.Text = "MySQL Remote Link";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(403, 49);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 2;
            label2.Text = "Version 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 94);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Build #PC ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 251);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 4;
            label4.Text = "Copyright © 2004-2028 -";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(309, 251);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 6;
            label5.Text = "Design System ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 133);
            label7.Name = "label7";
            label7.Size = new Size(188, 20);
            label7.TabIndex = 8;
            label7.Text = "Descripción del Programa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 158);
            label8.Name = "label8";
            label8.Size = new Size(504, 60);
            label8.TabIndex = 9;
            label8.Text = "Esta es una aplicación de escritorio desarrollada en C# utilizando .NET 9.0. \r\nEsta herramienta permite a los usuarios gestionar conexiones remotas a \r\nbases de datos MySQL de manera eficiente.";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(553, 280);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(571, 327);
            MinimizeBox = false;
            MinimumSize = new Size(571, 327);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About MySQL Remote Link";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}