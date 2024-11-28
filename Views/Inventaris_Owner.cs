using Npgsql;
using PROJEK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TeaSMart_App.Views
{

    public partial class Inventaris_Owner : Form
    {
        bool sidebarExpand;
        public Inventaris_Owner()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
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



        private void btnHalUtama_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Inventaris_Owner_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProduk produkBaru = new AddProduk();
            if (produkBaru.ShowDialog() == DialogResult.OK) // Pastikan validasi di Form3 berhasil
            {
                TambahPanelProduk(produkBaru.NamaProduk, produkBaru.HargaProduk, produkBaru.gambar, produkBaru.Jenis, produkBaru.batch, produkBaru.tglProduksi, produkBaru.tglEXP);
            }
        }

        private void TambahPanelProduk(string nama, string harga, Image gambar, string jenis, string batch, DateOnly tglproduksi, DateOnly tglexp)
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = gambar,
                Size = new Size(180, 180),
                Location = new Point(16, 14),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Panel produkPanel = new Panel
            {
                Size = new Size(200, 300),
                BackColor = Color.LightGray,
                Margin = new Padding(10)
            };
            Label lblInfo = new Label
            {
                Text = $"Nama: {nama}\nHarga: {harga}\nExp:{tglexp}",
                AutoSize = true,
                Location = new Point(10, 10)
            };

            produkPanel.Controls.Add(pictureBox);
            produkPanel.Controls.Add(lblInfo);

            flykatalogProduk.Controls.Add(produkPanel);
        }
        private void flykatalogProduk_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
