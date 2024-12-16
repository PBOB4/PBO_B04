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
using TeaSMart_App.Properties;

namespace TeaSMart_App.Views
{
    public partial class AddProduk : Form
    {
        private C_Produk _CProduk;
        private bool _isEditMode; 
        private M_Produk _produkToEdit; 

        private readonly M_Users loggedUser;

        // Constructor untuk mode tambah
        public AddProduk(M_Users loggedUser)
        {
            InitializeComponent();
            _CProduk = new C_Produk();
            _isEditMode = false; 
            LoadCBJenis();
            this.loggedUser = loggedUser;
        }

        // Constructor untuk mode edit
        public AddProduk(M_Produk produk, M_Users loggedUser)
        {
            InitializeComponent();
            _CProduk = new C_Produk();
            _isEditMode = true; 
            _produkToEdit = produk; 

            this.loggedUser = loggedUser;
            LoadCBJenis();

            FillFormWithData(produk);
        }

        private void FillFormWithData(M_Produk produk)
        {
            tbNama.Text = produk.namaProduk;
            tbHarga.Text = produk.hargaProduk.ToString();
            tbStok.Text = produk.Stok.ToString();
            dtPDiperbarui.Value = DateTime.Now; 
            tbFileName.Text = produk.gambar;
            cbJenis.SelectedValue = produk.id_jenis;

            if (!string.IsNullOrEmpty(produk.gambar))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Images", produk.gambar);
                if (File.Exists(imgPath))
                {
                    picProduk.Image = Image.FromFile(imgPath);
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
                    picProduk.Image = Image.FromFile(openFileDialog.FileName);

                    string resourcesPath = @"D:\Kuliah semester 3\PBO\PROJECT besar\TeaSMart App\Resources";
                    if (!Directory.Exists(resourcesPath))
                    {
                        Directory.CreateDirectory(resourcesPath);
                    }
                    
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string destinationPath = Path.Combine(resourcesPath, fileName);

                    File.Copy(openFileDialog.FileName, destinationPath, overwrite: true);
                    tbFileName.Text = fileName;


                    tbFileName.Text = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (openFileDialog.FileName.EndsWith(".jpg") ||
            openFileDialog.FileName.EndsWith(".png") ||
            openFileDialog.FileName.EndsWith(".bmp"))
            {
                picProduk.Image = Image.FromFile(openFileDialog.FileName);
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
                cbJenis.DataSource = jenisTehList;
                cbJenis.DisplayMember = "jenis";
                cbJenis.ValueMember = "id_jenis";
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


                if (_isEditMode) 
                {
                    _produkToEdit.namaProduk = tbNama.Text.Trim();
                    _produkToEdit.hargaProduk = Convert.ToDecimal(tbHarga.Text.Trim());
                    _produkToEdit.Stok = Convert.ToInt32(tbStok.Text.Trim());
                    _produkToEdit.Diperbarui = dtPDiperbarui.Value;
                    _produkToEdit.gambar = tbFileName.Text.Trim();
                    _produkToEdit.id_jenis = id_jenis;

                    C_Produk.UpdateProduk(_produkToEdit); 
                    MessageBox.Show("Produk berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
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
                    C_Produk.AddProduk(produkBaru); 
                    MessageBox.Show("Produk baru berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InventarisOwner invtOwner = new InventarisOwner(loggedUser);
                invtOwner.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventarisOwner inventarisOwner = new InventarisOwner(loggedUser);
            inventarisOwner.Show();
            this.Close();
        }
    }
}
