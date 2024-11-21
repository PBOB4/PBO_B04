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
            // Membuat instance dari RegisterForm
            FormRegist registerForm = new FormRegist();

            // Menampilkan RegisterForm
            registerForm.Show();

            // (Opsional) Menyembunyikan MainForm
            this.Hide();
        }
    }
}
