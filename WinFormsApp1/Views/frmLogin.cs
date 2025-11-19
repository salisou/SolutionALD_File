using Newtonsoft.Json;
using WinFormsApp1.Helpers;
using WinFormsApp1.Modes;
using WinFormsApp1.Views;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        private PasswordTextBox txtPassword;
        public frmLogin()
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
            // Legge i dati inseriti
            string nomeUtente = txtNome.Text;
            string password = txtPassword.Text;


            // Carica gli utenti  dal file JSON
            List<Utente> utenti = CaricaUtenti();

            // Carica l'utente registrato 
            Utente? utente = utenti.FirstOrDefault(u =>
                u.Nome == nomeUtente && u.Passwor == password
            );

            //foreach (var u in utenti)
            //{
            //    if (u.Nome == nomeUtente && u.Password == password)
            //    {
            //        utenteTrovato = u;
            //        break;
            //    }
            //}

            if (utente != null)
            {
                // Login Ok
                frmMain main = new();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome o password errati!", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Utente> CaricaUtenti()
        {
            string path = "utente.json";

            if (!File.Exists(path))
                return [];


            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Utente>>(json) ?? [];
        }
    }
}
