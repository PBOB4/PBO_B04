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
    public partial class InventarisAdmin : Form
    {
        bool sidebarExpand = true;
        public InventarisAdmin()
        {
            InitializeComponent();
            ProdukAdmin_Load();
        }

        private void ProdukAdmin_Load()
        {
            flowLayoutPanel2.Controls.Clear();
            List<M_Produk> produkList = C_Produk.GetAllProduct();
            foreach (var produk in produkList)
            {
                Panel produkPanel = new Panel
                {
                    Size = new Size(330, 159),
                    BackColor = Color.FromArgb(181, 199, 156),
                    Margin = new Padding(6),
                };
                string imgName = produk.gambar;

                var imageResource = Properties.Resources.ResourceManager.GetObject(imgName);
                if (imageResource != null)
                {
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(110, 126),
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
                        Size = new Size(110, 124),
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
                    Location = new Point(130, 23)
                };
                Label lblPanelHarga = new Label
                {
                    Text = $"Rp {produk.hargaProduk:N0}",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Location = new Point(130, 46)
                };
                Label lblPanelStok = new Label
                {
                    Text = produk.Stok.ToString(),
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Location = new Point(130, 66)
                };
                Button btnPanelCO = new Button
                {
                    Text = "Check Out",
                    Size = new Size(60, 30),
                    AutoSize = true,
                    Location = new Point(210, 120)
                };
                btnPanelCO.Click += (s, e) =>
                {
                    // halaman check out
                };

                produkPanel.Controls.Add(lblPanelNama);
                produkPanel.Controls.Add(lblPanelHarga);
                produkPanel.Controls.Add(lblPanelStok);
                produkPanel.Controls.Add(btnPanelCO);

                flowLayoutPanel2.Controls.Add(produkPanel);
            }
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 71)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 267)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void btnHalUtama_Click(object sender, EventArgs e)
        {
            HalamanUtama halUtama = new HalamanUtama();
            halUtama.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            //transaksi
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout
        }
    }
}
