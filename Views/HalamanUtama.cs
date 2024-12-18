using Npgsql;
using System.Data;
using System.Globalization;
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
            flyRank.Controls.Clear();
            List<M_Produk> rank = C_Produk.GetProdukTerlaris();
            foreach (var produk in rank)
            {
                Panel panel = new Panel()
                {
                    BackColor = Color.FromArgb(181, 199, 156),
                    Location = new Point(70, 62),
                    Margin = new Padding(15),
                    Size = new Size(340, 159),
                    TabIndex = 0
                };
                string resourcesPath = Path.Combine(@"D:\Kuliah semester 3\PBO\PROJECT besar\TeaSMart App\Resources");
                string imgName = Path.Combine(resourcesPath, produk.gambar);

                var imageResource = Properties.Resources.ResourceManager.GetObject(imgName);
                if (File.Exists(imgName))
                {
                    // MessageBox.Show($"Gambar ditemukan di: {imgName}");
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(110, 126),
                        Image = Image.FromFile(imgName),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(18, 18)
                    };
                    panel.Controls.Add(pictureBox);
                }
                else
                {
                    // MessageBox.Show($"Gambar tidak ditemukan di: {imgName}");
                    var pictureBox = new PictureBox
                    {
                        Size = new Size(110, 124),
                        Image = Properties.Resources.default_image,
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
                flyRank.Controls.Add(panel);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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

        private void LoadRandomQuote()
        {
            lblQuotes.Text = _controller.GetRandomQuote();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRandomQuote();
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Have a Joyful Tea Time, {loggedUser.nama}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedUser = null;
            MessageBox.Show("Anda telah berhasil logout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            MainForm main = new MainForm();
            main.Show();
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
            Settings setting = new Settings(loggedUser);
            setting.Show();

            this.Hide();
        }

        private void buttonHalamanUtama_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
