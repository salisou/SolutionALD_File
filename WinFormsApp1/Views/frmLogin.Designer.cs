namespace WinFormsApp1
{
    partial class frmDemo1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblRegister = new Label();
            txtNome = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F);
            button1.Location = new Point(287, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Salva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(577, 5);
            button2.Name = "button2";
            button2.Size = new Size(81, 35);
            button2.TabIndex = 5;
            button2.Text = "Esci";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(287, 98);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 6;
            label1.Text = "Nome Utente";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(287, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Inserisci la passwod";
            txtPassword.Size = new Size(340, 26);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(287, 172);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(391, 238);
            label3.Name = "label3";
            label3.Size = new Size(192, 18);
            label3.TabIndex = 10;
            label3.Text = "Non sei ancora registrato?";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Arial", 12F);
            lblRegister.ForeColor = Color.CornflowerBlue;
            lblRegister.Location = new Point(340, 269);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(179, 18);
            lblRegister.TabIndex = 11;
            lblRegister.Text = "Clicca qui pre registrarti!";
            lblRegister.Click += lblRegister_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F);
            txtNome.Location = new Point(287, 116);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci il nome";
            txtNome.Size = new Size(340, 26);
            txtNome.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.code;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(266, 27);
            label4.Name = "label4";
            label4.Size = new Size(287, 24);
            label4.TabIndex = 14;
            label4.Text = "Sistema di authenticazione ";
            // 
            // frmDemo1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(663, 316);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(txtNome);
            Controls.Add(lblRegister);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDemo1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrazione";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label lblRegister;
        private TextBox txtNome;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
