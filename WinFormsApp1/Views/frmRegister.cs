using Newtonsoft.Json;
using WinFormsApp1.Modes;

namespace WinFormsApp1.Views
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmLogin login = new();
            login.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Verica tutti i gli passati nel frmRegist[progettazione]
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCognome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Compila tutti campi");
                return;
            }

            Utente nuovo = new()
            {
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Passwor = txtPassword.Text,
                Email = txtEmail.Text
            };

            SalvaUtente(nuovo);

            MessageBox.Show("Registrazione complettata!");
        }

        private void SalvaUtente(Utente u)
        {
            string path = "utente.json";
            List<Utente> lista;

            // Ferifico se il file.json esiste o no. se si/no micrea o aggiorna
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Utente>>(json) ?? [];
            }
            else
            {
                lista = [];
            }

            lista.Add(u);

            var valuesJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(path, valuesJson);
        }
    }
}
