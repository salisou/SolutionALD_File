using WinFormsApp1.Views;

namespace WinFormsApp1
{
    public partial class frmDemo1 : Form
    {
        public frmDemo1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Attesa di registrazione in corso!");
            frmRegister register = new();
            register.ShowDialog();

        }
    }
}
