namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Condizione (se la condizione è sodisfata mostra il nome)
            MessageBox.Show($"Nome completo dell'utente = {textBox1.Text} - {textBox2.Text}");
            // Altrimenti Mostra un messaggio di errore 
        }
    }
}
