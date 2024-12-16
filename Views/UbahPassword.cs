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
    public partial class UbahPassword : Form
    {
        private M_Users loggedUser;
        public UbahPassword(M_Users loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
        }

        private void btnUbahPw_Click(object sender, EventArgs e)
        {
            // Ambil input dari text box
            string oldPassword = tbPwLama.Text.Trim(); // TextBox untuk password lama
            string newPassword = tbPwBaru.Text.Trim(); // TextBox untuk password baru
            string confirmPassword = tbKonfirmasiPw.Text.Trim(); // TextBox untuk konfirmasi password

            // Validasi input
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Password baru dan konfirmasi password tidak sesuai.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Panggil fungsi UpdatePassword
                int id_user = loggedUser.id_user; // Asumsikan `LoggedUser` adalah objek user yang sedang login
                C_User.UpdatePassword(id_user, oldPassword, newPassword);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(loggedUser);
            settings.Show();
            this.Close();
        }

        private void showConfirmPw_CheckedChanged(object sender, EventArgs e)
        {
            if (showConfirmPw.Checked)
            {
                tbKonfirmasiPw.PasswordChar = '\0';
            }
            else
            {
                tbKonfirmasiPw.PasswordChar = '*';
            }
        }
    }
}
