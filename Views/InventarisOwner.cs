using Npgsql;
using PROJEK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaSMart_App.App.Context;
using TeaSMart_App.App.Models;
using static System.Windows.Forms.DataFormats;
using Label = System.Windows.Forms.Label;

namespace TeaSMart_App.Views
{

    public partial class InventarisOwner : Form
    {
        bool sidebarExpand = true;
        public InventarisOwner()
        {
            InitializeComponent();
            ProdukOwner_Load();
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



        private void btnHalUtama_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void InventarisOwner_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProduk produkBaru = new AddProduk();
            if (produkBaru.ShowDialog() == DialogResult.OK) // Pastikan validasi di Form3 berhasil
            {
                //TambahPanelProduk(produkBaru.NamaProduk, produkBaru.HargaProduk, produkBaru.gambar, produkBaru.Jenis, produkBaru.batch, produkBaru.tglProduksi, produkBaru.tglEXP);
            }
        }

        private void ProdukOwner_Load()
        {
            flykatalogProduk.Controls.Clear();
            List<M_Produk> produkList = C_Produk.GetAllProduct();
            foreach (var produk in produkList)
            {
                Panel produkPanel = new Panel
                {
                    Size = new Size(340, 159),
                    BackColor = Color.FromArgb(181, 199, 156),
                    Margin = new Padding(6),
                };
                string imgName = produk.gambar;

                var imageResource = Properties.Resources.ResourceManager.GetObject(imgName);
                if (imageResource != null)
                {
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(115, 126),
                        Image = imageResource as System.Drawing.Image,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(18, 18)
                    };
                    produkPanel.Controls.Add(pictureBox);
                }
                else
                {
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(115, 126),
                        Image = Properties.Resources.Teh_Jasmine_Premium,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(18, 18)
                    };
                    produkPanel.Controls.Add(pictureBox);
                }

                Label lblPanelNama = new Label
                {
                    Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Text = produk.namaProduk.ToString(),
                    Size = new Size(59, 23),
                    AutoSize = true,
                    Location = new Point(145, 23)
                };
                Label lblPanelHarga = new Label
                {
                    Text = $"Rp {produk.hargaProduk:N0}",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Location = new Point(145, 46)
                };
                Label lblPanelStok = new Label
                {
                    Text = produk.Stok.ToString(),
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Location = new Point(145, 66)
                };
                Button btnPanelEdit = new Button
                {
                    Text = "Edit",
                    Size = new Size(60, 30),
                    Location = new Point(246, 120)
                };

                btnPanelEdit.Click += (s, e) =>
                {
                    editProduk editproduk = new editProduk();
                    editproduk.Show();
                };

                Button btnPanelHapus = new Button
                {
                    Text = "Hapus",
                    Size = new Size(60, 30),
                    Location = new Point(176, 120)
                };
                btnPanelHapus.Click += (s, e) =>
                {
                    
                };

                produkPanel.Controls.Add(lblPanelNama);
                produkPanel.Controls.Add(lblPanelHarga);
                produkPanel.Controls.Add(lblPanelStok);
                produkPanel.Controls.Add(btnPanelEdit);
                produkPanel.Controls.Add(btnPanelHapus);

                flykatalogProduk.Controls.Add(produkPanel);
            }
        }

        private void flykatalogProduk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
