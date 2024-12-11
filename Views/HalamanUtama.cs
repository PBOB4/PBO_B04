using Npgsql;
using System.Data;
using TeaSMart_App.App.Context;
using TeaSMart_App.App.Core;
using TeaSMart_App.App.Models;
using TeaSMart_App.Views;
using static System.Windows.Forms.DataFormats;
using Label = System.Windows.Forms.Label;

namespace TeaSMart_App.Views
{
    public partial class HalamanUtama : Form
    {
        bool sidebarExpand = true;
        private M_Users loggedUser;
        private readonly C_HalUtama _controller;
        private readonly M_Users _loggedUser; // Data pengguna yang login

        public HalamanUtama(M_Users loggedUser)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            RankProduk();
            _controller = new C_HalUtama();
            LoadRandomQuote();
        }

        private void RankProduk()
        {
            flowLayoutPanel1.Controls.Clear();
            List<M_Produk> rank = C_Produk.GetProdukTerlaris();
            foreach (var produk in rank)
            {
                Panel panel = new Panel()
                {
                    BackColor = Color.FromArgb(181, 199, 156),
                    Location = new Point(70, 62),
                    Margin = new Padding(20),
                    Size = new Size(340, 159),
                    TabIndex = 0
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
                    panel.Controls.Add(pictureBox);
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
                    panel.Controls.Add(pictureBox);
                }

                Label lblPanelNama = new Label
                {
                    Text = produk.namaProduk.ToString(),
                    Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    ForeColor = Color.FromArgb(0, 64, 0),
                    Size = new Size(173, 17),
                    TabIndex = 2,
                    Location = new Point(147, 31)
                };
                Label lblPanelHarga = new Label
                {
                    Text = $"Rp {produk.hargaProduk:N0}",
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Location = new Point(150, 57)
                };
                panel.Controls.Add(lblPanelNama);
                panel.Controls.Add(lblPanelHarga);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        public void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (loggedUser.role == "owner")
            {
                InventarisOwner inventaris_Owner = new InventarisOwner();
                inventaris_Owner.Show();
                this.Hide();
            } else if (loggedUser.role == "admin")
            {
                InventarisAdmin inventaris_Admin = new InventarisAdmin();
                inventaris_Admin.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("User not found", e.ToString());
            }
            
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadRandomQuote()
        {
            lblQuotes.Text = _controller.GetRandomQuote();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRandomQuote();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //transaksi
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Show();

            this.Close();
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {
            
        }
    }
}
