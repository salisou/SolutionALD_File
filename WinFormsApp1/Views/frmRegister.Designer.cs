namespace WinFormsApp1.Views
{
    partial class frmRegister
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            lblRegister = new Label();
            label3 = new Label();
            label5 = new Label();
            btnClose = new Button();
            btnRegister = new Button();
            txtCognome = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(310, 13);
            label4.Name = "label4";
            label4.Size = new Size(265, 24);
            label4.TabIndex = 23;
            label4.Text = "Sistema di Registrazione ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.code;
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F);
            txtNome.Location = new Point(262, 63);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci tuo nome";
            txtNome.Size = new Size(340, 26);
            txtNome.TabIndex = 21;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Arial", 12F);
            lblRegister.ForeColor = Color.CornflowerBlue;
            lblRegister.Location = new Point(410, 287);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(179, 18);
            lblRegister.TabIndex = 20;
            lblRegister.Text = "Clicca qui pre accedere!";
            lblRegister.Click += lblRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(478, 264);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 19;
            label3.Text = "Hai un accout?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(262, 45);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 17;
            label5.Text = "Nome";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(623, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 35);
            btnClose.TabIndex = 16;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button2_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Font = new Font("Arial", 12F);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(262, 259);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 23);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Salva";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtCognome
            // 
            txtCognome.Font = new Font("Arial", 12F);
            txtCognome.Location = new Point(262, 118);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "Inserisci tuo cognome";
            txtCognome.Size = new Size(340, 26);
            txtCognome.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(262, 100);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 24;
            label1.Text = "Cognome";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F);
            txtEmail.Location = new Point(262, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Inserisci l'indirizzo mail";
            txtEmail.Size = new Size(340, 26);
            txtEmail.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(262, 152);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 26;
            label2.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(262, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Inserisci la password";
            txtPassword.Size = new Size(340, 26);
            txtPassword.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(262, 209);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 28;
            label6.Text = "Password";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(675, 319);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtCognome);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(txtNome);
            Controls.Add(lblRegister);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegiter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private TextBox txtNome;
        private Label lblRegister;
        private Label label3;
        private Label label5;
        private Button btnClose;
        private Button btnRegister;
        private TextBox txtCognome;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Label label6;
    }
}