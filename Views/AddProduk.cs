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
    public partial class AddProduk : Form
    {
        private C_Produk _CProduk;
        private bool _isEditMode; // Menyimpan informasi apakah dalam mode edit
        private M_Produk _produkToEdit; // Menyimpan produk yang akan diedit

        // Constructor untuk mode tambah
        public AddProduk()
        {
            InitializeComponent();
            _CProduk = new C_Produk();
            _isEditMode = false; // Default ke mode tambah
            LoadCBJenis();
        }

        // Constructor untuk mode edit
        public AddProduk(M_Produk produk)
        {
            InitializeComponent();
            _CProduk = new C_Produk();
            _isEditMode = true; // Aktifkan mode edit
            _produkToEdit = produk; // Simpan produk yang akan diedit
            LoadCBJenis();

            // Isi form dengan data produk yang akan diedit
            FillFormWithData(produk);
        }

        // Fungsi untuk mengisi form dengan data produk
        private void FillFormWithData(M_Produk produk)
        {
            tbNama.Text = produk.namaProduk;
            tbHarga.Text = produk.hargaProduk.ToString();
            tbStok.Text = produk.Stok.ToString();
            dtPDiperbarui.Value = DateTime.Now; // Nilai default
            tbFileName.Text = produk.gambar;
            cbJenis.SelectedValue = produk.id_jenis;

            // Jika ada gambar, tampilkan
            if (!string.IsNullOrEmpty(produk.gambar))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Images", produk.gambar);
                if (File.Exists(imgPath))
                {
                    pictureBox1.Image = Image.FromFile(imgPath);
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Pilih Gambar",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Memuat gambar ke PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Menangani kesalahan
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (openFileDialog.FileName.EndsWith(".jpg") ||
            openFileDialog.FileName.EndsWith(".png") ||
            openFileDialog.FileName.EndsWith(".bmp"))
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("File yang dipilih bukan gambar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void AddProduk_Load(object sender, EventArgs e)
        {
            LoadCBJenis();
        }
        private void LoadCBJenis()
        {
            try
            {
                List<M_jenis> jenisTehList = _CProduk.GetAllJenis();

                // Mengisi ComboBox dengan data jenis teh
                cbJenis.DataSource = jenisTehList;
                cbJenis.DisplayMember = "jenis"; // Menampilkan nama jenis teh
                cbJenis.ValueMember = "id_jenis";     // Menyimpan ID jenis teh di dalam nilai combo box
                cbJenis.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data jenis teh: {ex.Message}");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbJenis.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih jenis teh terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int id_jenis = Convert.ToInt32(cbJenis.SelectedValue);


                if (_isEditMode) // Mode edit
                {
                    _produkToEdit.namaProduk = tbNama.Text.Trim();
                    _produkToEdit.hargaProduk = Convert.ToDecimal(tbHarga.Text.Trim());
                    _produkToEdit.Stok = Convert.ToInt32(tbStok.Text.Trim());
                    _produkToEdit.Diperbarui = dtPDiperbarui.Value;
                    _produkToEdit.gambar = tbFileName.Text.Trim();
                    _produkToEdit.id_jenis = id_jenis;
                    _produkToEdit.isActive = true;

                    C_Produk.UpdateProduk(_produkToEdit); // Panggil metode untuk mengupdate produk
                    MessageBox.Show("Produk berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Mode tambah
                {
                    M_Produk produkBaru = new M_Produk
                    {
                        namaProduk = tbNama.Text.Trim(),
                        hargaProduk = Convert.ToDecimal(tbHarga.Text.Trim()),
                        Stok = Convert.ToInt32(tbStok.Text.Trim()),
                        Diperbarui = dtPDiperbarui.Value,
                        gambar = tbFileName.Text.Trim(),
                        isActive = true,
                        id_jenis = id_jenis
                    };
                    C_Produk.AddProduk(produkBaru); // Panggil metode untuk menambah produk baru
                    MessageBox.Show("Produk baru berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventarisOwner inventarisOwner = new InventarisOwner();
            inventarisOwner.Show();
            this.Close();
        }
    }
}
