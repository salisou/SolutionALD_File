namespace WinFormsApp1
{
    partial class DemoDataGridView
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            txtClasse = new TextBox();
            txtCognome = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            panel4 = new Panel();
            dgrStudente = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrStudente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 47);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 539);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtClasse);
            panel3.Controls.Add(txtCognome);
            panel3.Controls.Add(txtNome);
            panel3.Controls.Add(txtId);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(112, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 48);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(770, 8);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 4;
            button1.Text = "Salva";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtClasse
            // 
            txtClasse.Location = new Point(539, 12);
            txtClasse.Name = "txtClasse";
            txtClasse.PlaceholderText = "Inserisci la classe";
            txtClasse.Size = new Size(143, 23);
            txtClasse.TabIndex = 3;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(359, 12);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "Inserisci il Cognome";
            txtCognome.Size = new Size(143, 23);
            txtCognome.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(184, 12);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserisci il Nome";
            txtNome.Size = new Size(143, 23);
            txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(13, 12);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Inserisci l'id";
            txtId.Size = new Size(143, 23);
            txtId.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(dgrStudente);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(112, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(861, 491);
            panel4.TabIndex = 3;
            // 
            // dgrStudente
            // 
            dgrStudente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrStudente.Dock = DockStyle.Fill;
            dgrStudente.Location = new Point(0, 0);
            dgrStudente.Name = "dgrStudente";
            dgrStudente.Size = new Size(861, 491);
            dgrStudente.TabIndex = 0;
            // 
            // prova
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 586);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "prova";
            Text = "prova";
            Load += prova_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrStudente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtClasse;
        private TextBox txtCognome;
        private TextBox txtNome;
        private TextBox txtId;
        private Panel panel4;
        private DataGridView dgrStudente;
        private Button button1;
    }
}