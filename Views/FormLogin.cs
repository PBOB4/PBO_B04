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

namespace TeaSMart_App.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
        }

        private void btnKeDaftar_Click(object sender, EventArgs e)
        {
            FormRegist formRegist = new FormRegist();
            formRegist.Show();

            this.Hide();
        }

        // Contoh handler login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox4.Text;

            try
            {
                // Validasi login dan simpan data pengguna
                M_Users loggedUser = C_User.Login(username, password);

                if (loggedUser != null)
                {
                    // MessageBox.Show(loggedUser.role.ToString());
                    // Login berhasil, buka halaman utama
                    HalamanUtama halamanUtama = new HalamanUtama(loggedUser); // Kirim data pengguna
                    halamanUtama.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}