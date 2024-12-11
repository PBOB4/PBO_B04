using TeaSMart_App.Views;

namespace TeaSMart_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();

            formlogin.Show();
        }
    }
}
