using WinFormsApp1.Helpers;
using WinFormsApp1.Views;

namespace WinFormsApp1
{
    public partial class frmDemo1 : Form
    {
        public frmDemo1()
        {
            InitializeComponent();
            Loader();
        }

        private void Loader()
        {
            var pwdBox = new PasswordTextBox()
            {
                Location = new Point(290, 192),   // <— posizione corretta
                Width = 338,
                Height = 34,
                Placeholder = "Inserisci la password"
            };

            this.Controls.Add(pwdBox);

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
