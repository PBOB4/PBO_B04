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
using TeaSMart_App.App.Core;

namespace TeaSMart_App.Views
{
    public partial class RiwayatTransaksi : Form
    {
        private M_Users loggedUser;
        private string UserRole;
        bool sidebarExpand = true;

        public RiwayatTransaksi(string role, M_Users loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            UserRole = role;
            LoadTransaksiData();
        }

        private void LoadTransaksiData()
        {
            DataTable transaksiData;

            if (UserRole == "owner")
            {
                // Jika role Owner, tampilkan semua transaksi dari semua user
                transaksiData = C_Transaksi.GetTransaksiData();
            }
            else if (UserRole == "admin")
            {
                // Jika role Admin, tampilkan transaksi yang dibuat oleh admin tersebut
                int idAdmin = loggedUser.id_user;  // Mengambil ID admin dari session/login state
                transaksiData = C_Transaksi.GetTransaksiByAdmin(idAdmin);
            }
            else
            {
                MessageBox.Show("Peran pengguna tidak dikenali.");
                return;
            }

            // Binding data ke DataGridView jika transaksiData tidak null
            if (transaksiData != null)
            {
                dataGridRiwayat.DataSource = transaksiData;

                // Mengatur header kolom
                if (dataGridRiwayat.Columns["tanggaltransaksi"] != null)
                    dataGridRiwayat.Columns["tanggaltransaksi"].HeaderText = "Tanggal";
                if (dataGridRiwayat.Columns["totalharga"] != null)
                    dataGridRiwayat.Columns["totalharga"].HeaderText = "Total Harga";
                if (dataGridRiwayat.Columns["qty"] != null)
                    dataGridRiwayat.Columns["qty"].HeaderText = "Jumlah";
                if (dataGridRiwayat.Columns["harga"] != null)
                    dataGridRiwayat.Columns["harga"].HeaderText = "Harga";
                if (dataGridRiwayat.Columns["namaproduk"] != null)
                    dataGridRiwayat.Columns["namaproduk"].HeaderText = "Nama Produk";
                if (dataGridRiwayat.Columns["jenis"] != null)
                    dataGridRiwayat.Columns["jenis"].HeaderText = "Jenis";

                dataGridRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridRiwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridRiwayat.AllowUserToResizeColumns = true;
                dataGridRiwayat.AllowUserToResizeRows = true;
            }
            else
            {
                MessageBox.Show("Gagal memuat data transaksi.");
            }
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
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

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings(loggedUser);
            setting.Show();

            this.Hide();
        }
    }
}