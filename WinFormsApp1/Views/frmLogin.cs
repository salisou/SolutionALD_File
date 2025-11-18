using WinFormsApp1.Helpers;
using WinFormsApp1.Views;

namespace WinFormsApp1
{
    public partial class frmDemo1 : Form
    {
        private PasswordTextBox txtPassword;
        public frmDemo1()
        {
            InitializeComponent();
            Loader();
        }

        private void Loader()
        {
            txtPassword = new()
            {
                Location = new Point(290, 192),   // <— posizione corretta
                Width = 338,
                Height = 34
            };

            this.Controls.Add(txtPassword);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUtente = txtNome.Text;
            string password = txtPassword.Text;

            if (nomeUtente == "Moussa" && password == "password@123")
            {
                frmMain main = new();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Attenzione verifica il Nome dell'utente e la password");
            }
        }
    }
}
