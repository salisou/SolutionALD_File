using WinFormsApp1.Modes;

namespace WinFormsApp1
{
    public partial class DemoDataGridView : Form
    {
        // Lista studenti come "database" in memoria
        private List<Studente> studenti = [];

        public DemoDataGridView()
        {
            InitializeComponent();
        }

        private void prova_Load(object sender, EventArgs e)
        {
            // Collega la lista al DataGridView (dgrStudente)
            dgrStudente.DataSource = studenti;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Crea un nuovo studente dei TextBox
            Studente nuovo = new()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Classe = txtClasse.Text
            };

            // Aggiunge alla lista
            studenti.Add(nuovo);

            // Aggiurna la grilia
            dgrStudente.DataSource = null; // reset
            dgrStudente.DataSource = studenti;
        }

    }
}
