using Npgsql;
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
        private M_Users loggedUser;
        public InventarisOwner(M_Users user)
        {
            InitializeComponent();
            loggedUser = user ?? throw new ArgumentNullException(nameof(user), "User tidak boleh null");
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

        private void btnAddProduk_Click(object sender, EventArgs e)
        {
            AddProduk produkBaru = new AddProduk(loggedUser);
            produkBaru.Show();
            this.Close();
        }

        private void ProdukOwner_Load()
        {
            flykatalogProduk.Controls.Clear();
            List<M_Produk> produkList = C_Produk.GetAllProduct();
            foreach (var produk in produkList)
            {
                Panel produkPanel = new Panel
                {
                    Size = new Size(330, 159),
                    BackColor = Color.FromArgb(181, 199, 156),
                    Margin = new Padding(6),
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
                    produkPanel.Controls.Add(pictureBox);
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
                Button btnPanelEdit = new Button
                {
                    Text = "Edit",
                    Size = new Size(60, 30),
                    Location = new Point(246, 120),
                    Cursor = Cursors.Hand
                };
                btnPanelEdit.Click += (s, e) =>
                {
                    AddProduk editProdukForm = new AddProduk(produk, loggedUser); // Kirim produk ke form AddProduk
                    editProdukForm.ShowDialog();
                    this.Hide();
                    ProdukOwner_Load(); // Refresh daftar produk setelah selesai
                };
                Button btnPanelHapus = new Button
                {
                    Text = "Hapus",
                    Size = new Size(60, 30),
                    Location = new Point(176, 120),
                    Tag = produk.id_produk,
                    Cursor = Cursors.Hand
                };
                btnPanelHapus.Click += BtnDelete_Click;

                produkPanel.Controls.Add(lblPanelNama);
                produkPanel.Controls.Add(lblPanelHarga);
                produkPanel.Controls.Add(lblPanelStok);
                produkPanel.Controls.Add(btnPanelEdit);
                produkPanel.Controls.Add(btnPanelHapus);

                flykatalogProduk.Controls.Add(produkPanel);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil ID produk dari Tag tombol
                Button btn = sender as Button;
                int idProduk = Convert.ToInt32(btn.Tag);

                // Konfirmasi penghapusan
                var confirmResult = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus produk ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Panggil fungsi delete
                    C_Produk.DelProduk(idProduk);

                    // Beri notifikasi
                    MessageBox.Show("Produk berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh daftar produk
                    ProdukOwner_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            // Bersihkan panel sebelum menambahkan data baru
            flykatalogProduk.Controls.Clear();
            List<M_Produk> produkList = C_Produk.SearchProducts(searchTerm);
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
                Button btnPanelEdit = new Button
                {
                    Text = "Edit",
                    Size = new Size(60, 30),
                    Location = new Point(246, 120),
                    Cursor = Cursors.Hand
                };

                btnPanelEdit.Click += (s, e) =>
                {
                    AddProduk editProdukForm = new AddProduk(produk, loggedUser); // Kirim produk ke form AddProduk
                    editProdukForm.ShowDialog();
                    ProdukOwner_Load(); // Refresh daftar produk setelah selesai
                };

                Button btnPanelHapus = new Button
                {
                    Text = "Hapus",
                    Size = new Size(60, 30),
                    Location = new Point(176, 120),
                    Cursor = Cursors.Hand
                };
                btnPanelHapus.Click += BtnDelete_Click;

                produkPanel.Controls.Add(lblPanelNama);
                produkPanel.Controls.Add(lblPanelHarga);
                produkPanel.Controls.Add(lblPanelStok);
                produkPanel.Controls.Add(btnPanelEdit);
                produkPanel.Controls.Add(btnPanelHapus);

                flykatalogProduk.Controls.Add(produkPanel);
            }
        }

        private void buttonHalamanUtama_Click(object sender, EventArgs e)
        {
            HalamanUtama halUtama = new HalamanUtama(loggedUser);
            halUtama.Show();
            this.Hide();
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
            Settings settings = new Settings(loggedUser);
            settings.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            loggedUser = null;
            MessageBox.Show("Anda telah berhasil logout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        private void btnHInventaris_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
