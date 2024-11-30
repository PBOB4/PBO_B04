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
                    Size = new Size(354, 159),
                    BackColor = Color.FromArgb(181, 199, 156),
                    Margin = new Padding(10)
                };
                string imgName = produk.gambar.ToLower();

                var imageResource = Properties.Resources.ResourceManager.GetObject(imgName);
                if (imageResource != null)
                {
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(115, 126),
                        Image = imageResource as System.Drawing.Image,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    produkPanel.Controls.Add(pictureBox);
                }
                else
                {
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(115, 126),
                        Image = Properties.Resources.default_image,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    produkPanel.Controls.Add(pictureBox);
                }

                Label lblPanelNama = new Label
                {
                    Text = produk.namaProduk.ToString(),
                    AutoSize = true,
                    Location = new Point(145, 23)
                };
                Label lblPanelHarga = new Label
                {
                    Text = produk.hargaProduk.ToString(),
                    AutoSize = true,
                    Location = new Point(145, 46)
                };
                Label lblPanelStok = new Label
                {
                    Text = produk.Stok.ToString(),
                    AutoSize = true,
                    Location = new Point(145, 66)
                };
                Button btnPanelCO = new Button
                {
                    Text = "Check Out",
                    Size = new Size(60, 30)
                };

                produkPanel.Controls.Add(lblPanelNama);
                produkPanel.Controls.Add(lblPanelHarga);
                produkPanel.Controls.Add(lblPanelStok);
                produkPanel.Controls.Add(btnPanelCO);

                flowLayoutPanel2.Controls.Add(produkPanel);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }
    }
}
