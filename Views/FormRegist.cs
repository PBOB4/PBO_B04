using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using TeaSMart_App.App.Context;
using TeaSMart_App.App.Models;
using TeaSMart_App.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeaSMart_App
{
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();

            tbPassword.PasswordChar = '*';
            tbKonfirmasiPw.PasswordChar = '*';
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                M_Users userBaru = new M_Users
                {
                    nama = tbNama.Text.Trim(),
                    username = tbUsername.Text.Trim(),
                    password = tbPassword.Text.Trim(),
                    konfirmasiPassword = tbKonfirmasiPw.Text.Trim(),
                    role = "Admin"
                };

                C_User.Register(userBaru);

                MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormLogin halUtama = new FormLogin();
                halUtama.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbKonfirmasiPw.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbKonfirmasiPw.PasswordChar = '*';
            }
        }
    }
}
