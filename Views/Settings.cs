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
    public partial class Settings : Form
    {
        private M_Users loggedUser;
        bool sidebarExpand = true;
        public Settings(M_Users loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
        }

        private void linkUbahPw_Click(object sender, EventArgs e)
        {
            UbahPassword ubahPassword = new UbahPassword(loggedUser);
            ubahPassword.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            lblHeader.Text = $"Informasi Akun, {loggedUser.username}";
            lblNamaUser.Text = $"Nama         : {loggedUser.nama}";
            lblUsnUser.Text = $"Username     : {loggedUser.username}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loggedUser = null;

            // Tampilkan pesan logout
            MessageBox.Show("Anda telah berhasil logout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tutup form saat ini dan kembali ke form login
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 71)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 267)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void buttonHalamanUtama_Click(object sender, EventArgs e)
        {
            HalamanUtama halUtama = new HalamanUtama(loggedUser);
            halUtama.Show();
            this.Hide();
        }

        private void btnHInventaris_Click(object sender, EventArgs e)
        {
            if (loggedUser.role == "owner")
            {
                InventarisOwner ownerForm = new InventarisOwner(loggedUser);
                ownerForm.Show();
                this.Hide();
            }
            else if (loggedUser.role == "admin")
            {
                InventarisAdmin inventarisAdmin = new InventarisAdmin(loggedUser);
                inventarisAdmin.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("User not found", e.ToString());
            }
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            if (loggedUser.role == "owner")
            {
                RiwayatTransaksi riwayatTransaksi = new RiwayatTransaksi("owner", loggedUser);
                riwayatTransaksi.Show();
                this.Hide();
            }
            else if (loggedUser.role == "admin")
            {
                RiwayatTransaksi riwayatTransaksiAdmin = new RiwayatTransaksi("admin", loggedUser);
                riwayatTransaksiAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found", e.ToString());
            }
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedUser = null;
            MessageBox.Show("Anda telah berhasil logout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
