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

        public AddProduk()
        {
            InitializeComponent();
            _CProduk = new C_Produk();
            LoadCBJenis();

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

                // Dapatkan nama jenis teh yang dipilih
                //string selectedJenis = cbJenis.SelectedItem.ToString();

                //int id_jenis = M_jenis.GetIdByNamaJenis(selectedJenis);  // Gunakan M_jenis untuk mendapatkan ID


                // Ambil id_jenis berdasarkan nama jenis teh yang dipilih
                //int id_jenis = _CProduk.GetIdByNamaJenis(selectedJenis);

                int id_jenis = Convert.ToInt32(cbJenis.SelectedValue);


                M_Produk produkBaru = new M_Produk
                {
                    namaProduk = tbNama.Text.Trim(),
                    hargaProduk = Convert.ToDecimal(tbHarga.Text.Trim()),
                    Stok = Convert.ToInt32(tbStok.Text.Trim()),
                    Diperbarui = dtPDiperbarui.Value,
                    gambar = tbFileName.Text.Trim(),
                    isActive= true,
                    id_jenis= id_jenis
                };
                C_Produk.AddProduk(produkBaru);
                MessageBox.Show("Produk baru berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InventarisOwner inventaris_Owner = new InventarisOwner();
                inventaris_Owner.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
