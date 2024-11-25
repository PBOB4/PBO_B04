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
            FormRegist formRegist = new FormRegist();

            // Menampilkan RegisterForm
            formRegist.Show();

            // (Opsional) Menyembunyikan MainForm
            this.Hide();
        }
    }
}
