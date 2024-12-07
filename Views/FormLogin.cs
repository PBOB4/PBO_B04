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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil username dan password dari TextBox
                string inputUsername = textBox2.Text.Trim();
                string inputPassword = textBox4.Text.Trim();

                // Validasi input (opsional)
                if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
                {
                    throw new Exception("Username dan password tidak boleh kosong.");
                }

                // Login pengguna
                M_Users loggedInUser = C_User.Login(inputUsername, inputPassword);

                // Jika berhasil, tampilkan pesan dan buka halaman utama
                MessageBox.Show($"Login berhasil! Selamat datang, {loggedInUser.nama}.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HalamanUtama halUtama = new HalamanUtama();
                halUtama.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika login gagal
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
