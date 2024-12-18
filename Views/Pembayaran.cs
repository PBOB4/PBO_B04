using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaSMart_App.App.Models;
using TeaSMart_App.App.Context;

namespace TeaSMart_App.Views
{
    public partial class Pembayaran : Form
    {
        private List<M_Produk> selectedProducts;
        private readonly M_detailTransaksi detailTransaksi;
        private readonly M_Users loggedUser;
        private readonly M_transaksi noFaktur;

        public Pembayaran(M_Users loggedUser, List<M_Produk> selectedProducts)
        {
            InitializeComponent();
            this.selectedProducts = selectedProducts;
            this.loggedUser = loggedUser;
            InfoAdmin();
            InfoTransaksi();
            // Panggil fungsi untuk menampilkan produk
            DisplaySelectedProductsInFlowPanel();
        }

        private void DisplaySelectedProductsInFlowPanel()
        {
            // Bersihkan FlowLayoutPanel sebelum menambah data baru
            flyProduk.Controls.Clear();

            foreach (var produk in selectedProducts)
            {
                // Buat panel untuk setiap produk
                Panel produkPanel = new Panel
                {
                    Size = new Size(484, 49),
                    Location = new Point(3, 3),
                    Margin = new Padding(0)
                };
                Label lblHarga = new Label
                {
                    Text = $"Rp{produk.hargaProduk:n0}",
                    AutoSize = true,
                    Font = new Font("Arial", 10),
                    Location = new Point(194, 14)
                };
                produkPanel.Controls.Add(lblHarga);
                // Tambahkan label nama produk
                Label lblNamaProduk = new Label
                {
                    Text = produk.namaProduk,
                    Location = new Point(7, 14),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                produkPanel.Controls.Add(lblNamaProduk);
                // Tambahkan label jumlah
                Label lblJumlah = new Label
                {
                    Text = $"{produk.SelectedQty}",
                    AutoSize = true,
                    Font = new Font("Arial", 10),
                    Location = new Point(326, 14)
                };
                produkPanel.Controls.Add(lblJumlah);
                // Tambahkan label harga
                Label lblTotal = new Label
                {
                    Text = $"Rp{(produk.SelectedQty * produk.hargaProduk):n0}",
                    TextAlign = ContentAlignment.MiddleRight,
                    AutoSize = true,
                    Size = new Size(97, 20),
                    Font = new Font("Arial", 10),
                    Location = new Point(377, 14)
                };
                MessageBox.Show(lblTotal.Text);
                produkPanel.Controls.Add(lblTotal);

                // Tambahkan panel ke FlowLayoutPanel
                flyProduk.Controls.Add(produkPanel);
            }
        }
        private int currentTransactionId; // Variabel global untuk menyimpan ID transaksi

        private void InfoTransaksi()
        {
            try
            {
                // Ambil ID transaksi terakhir
                DataTable maxTransaksi = C_Transaksi.GetMAXIdTransaksi(0); // Sesuaikan metode ini dengan implementasi Anda

                if (maxTransaksi != null && maxTransaksi.Rows.Count > 0)
                {
                    // Asumsikan kolom pertama adalah id_transaksi
                    currentTransactionId = Convert.ToInt32(maxTransaksi.Rows[0]["id_transaksi"]);
                    lblIdTransaksi.Text = $"#{currentTransactionId}";
                }
                else
                {
                    currentTransactionId = 0; // Fallback jika tidak ada transaksi
                    lblIdTransaksi.Text = "ID Tidak Tersedia";
                }

                // Set tanggal transaksi saat ini
                lblTgltransaksi.Text = maxTransaksi.Rows[0]["tanggalTransaksi"].ToString();
                lblTotalHarga.Text = $"Total Harga     : {maxTransaksi.Rows[0]["totalHarga"]:n0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mendapatkan informasi transaksi: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentTransactionId = 0;
                lblIdTransaksi.Text = "Error";
                lblTgltransaksi.Text = "Error";
            }
        }

        private void InfoAdmin()
        {
            try
            {
                if (loggedUser != null)
                {

                    lblNamaAdm.Text = loggedUser.nama;
                    lblUsnAdm.Text = $"@{loggedUser.username}";
                    lblIdAdm.Text = $"ID: {loggedUser.id_user.ToString()}";
                }
                else
                {
                    MessageBox.Show("User tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTransactionId > 0)
                {
                    // Batalkan transaksi yang sedang berjalan
                    C_Transaksi.DropTransaksi(currentTransactionId);
                    MessageBox.Show($"Transaksi #{currentTransactionId} telah dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Kembali ke form inventaris
                InventarisAdmin inventarisAdmin = new InventarisAdmin(loggedUser);
                inventarisAdmin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SimpanDetailTransaksi()
        {
            if (currentTransactionId == 0)
            {
                MessageBox.Show("ID Transaksi tidak valid, tidak dapat menyimpan detail transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var produk in selectedProducts)
            {
                // Buat objek detail transaksi
                var detailTransaksi = new M_detailTransaksi
                {
                    qty = produk.SelectedQty,
                    harga = produk.hargaProduk,
                    id_transaksi = currentTransactionId,
                    id_produk = produk.id_produk
                };

                // Panggil metode insert untuk menyimpan ke database
                C_Transaksi.insertDetailTransaksi(detailTransaksi);
                // Mengupdate stok produk di database
                int newStock = produk.Stok - produk.SelectedQty;

                if (newStock >= 0)
                {
                    C_Produk.UpdateStokProduk(produk.id_produk, newStock);
                }
                else
                {
                    MessageBox.Show($"Stok produk {produk.namaProduk} tidak cukup.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Detail transaksi berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            try
            {
                // Mengambil nilai pembayaran dari TextBox
                if (!decimal.TryParse(tbBayar.Text, out decimal bayar) ||
                    !decimal.TryParse(lblTotalHarga.Text.Replace("Total Harga     : ", "").Replace("Rp", "").Replace(",", ""), out decimal totalHarga))
                {
                    MessageBox.Show("Harap masukkan jumlah pembayaran yang valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi apakah jumlah bayar >= total harga
                if (bayar < totalHarga)
                {
                    MessageBox.Show("Jumlah uang yang dibayarkan kurang dari total harga. Harap periksa kembali.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Simpan detail transaksi
                SimpanDetailTransaksi();

                string folderPath = @"D:\Project besar";

                // Menggunakan input dialog untuk mengganti nama file
                string fileName = $"StrukTransaksi_{currentTransactionId}";

                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    SaveFormAsImageHD(folderPath, fileName);
                }
                else
                {
                    MessageBox.Show("Nama file tidak valid!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RiwayatTransaksi riwayatTransaksi = new RiwayatTransaksi("admin", loggedUser);
                riwayatTransaksi.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap CaptureFormHD()
        {
            // Sembunyikan tombol sebelum mengambil gambar
            btnSelesai.Visible = false;
            btnBack.Visible = false;

            // Buat bitmap lebih besar untuk kualitas HD (full size)
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Menggambar form dalam skala tinggi
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            }

            // Tampilkan kembali tombol setelah selesai
            btnSelesai.Visible = true;
            btnBack.Visible = true;

            return bitmap;
        }

        private void SaveFormAsImageHD(string folderPath, string fileName)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, $"{fileName}.png");

                // Tangkap form HD
                Bitmap bitmap = CaptureFormHD();

                // Menggunakan codec untuk memastikan resolusi penuh tanpa kompresi
                bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show($"Form berhasil disimpan di: {filePath}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan gambar HD: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbBayar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Mengambil nilai pembayaran dari TextBox
                if (decimal.TryParse(tbBayar.Text, out decimal bayar) &&
                    decimal.TryParse(lblTotalHarga.Text.Replace("Total Harga     : ", "").Replace("Rp", "").Replace(",", ""), out decimal totalHarga))
                {
                    decimal kembalian = bayar - totalHarga;

                    if (kembalian < 0)
                        lblKembali.Text = $"Kembali          : Rp0 (Uang tidak cukup)";
                    else
                        lblKembali.Text = $"Kembali          : Rp{kembalian:n0}";
                }
                else
                {
                    lblKembali.Text = "Kembali          :";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan input: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}