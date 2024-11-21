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
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeaSMart_App
{
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string namalengkap = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox4.Text;
            string kofirmasiPassword = textBox5.Text;

            if (string.IsNullOrEmpty(namalengkap) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(kofirmasiPassword))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != kofirmasiPassword)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password harus memiliki minimal 6 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=najwaa;Database=PBOcoba2";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, nama_lengkap, email, password) VALUES (@Username, @NamaLengkap, @Email, @Password)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NamaLengkap", namalengkap);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", HashPassword(password)); // Gunakan hashing
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registrasi berhasil! Anda sekarang masuk ke sistem.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
