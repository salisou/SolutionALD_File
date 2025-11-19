namespace WinFormsApp1.Views
{
    public partial class DemoListBox : Form
    {
        public DemoListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clontrolla che il txtTask non sia vuoto
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                // Aggiungere il testo txtTask all listView1
                listView1.Items.Add(txtTask.Text);

                // Pulire il txtTask
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Inserisci un attività prima🧐");
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            // Contolla che ci sai un elemento selezionato
            //if (listView1.SelectedIndex != -1)
            //{

            //}
            //else
            //{

            //}
        }
    }
}
