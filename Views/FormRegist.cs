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
using PROJEK;
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                M_Users userBaru = new M_Users
                {
                    nama = textBox1.Text.Trim(),
                    username = textBox2.Text.Trim(),
                    password = textBox4.Text.Trim(),
                    konfirmasiPassword = textBox5.Text.Trim(),
                };

                C_User.Register(userBaru);

                MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HalamanUtama halUtama = new HalamanUtama();
                halUtama.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void FormRegist_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
