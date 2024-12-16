using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaSMart_App.App.Context;
using TeaSMart_App.App.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeaSMart_App.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void btnKeDaftar_Click(object sender, EventArgs e)
        {
            FormRegist formRegist = new FormRegist();
            formRegist.Show();
            this.Hide();
        }
        private M_Users loggedUser;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                loggedUser = C_User.Login(username, password);

                if (loggedUser != null)
                {
                    MessageBox.Show(loggedUser.nama.ToString());
                    HalamanUtama halamanUtama = new HalamanUtama(loggedUser);
                    halamanUtama.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                // Tampilkan password sebagai teks biasa
                tbPassword.PasswordChar = '\0'; // '\0' adalah karakter null untuk menonaktifkan masking
            }
            else
            {
                // Sembunyikan password kembali dengan karakter '*'
                tbPassword.PasswordChar = '*';
            }

        }
    }
}