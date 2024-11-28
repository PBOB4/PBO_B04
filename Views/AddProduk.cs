using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaSMart_App.Views
{
    public partial class AddProduk : Form
    {
        public string NamaProduk { get; private set; }
        public string HargaProduk { get; private set; }
        public Image gambar { get; private set; }
        public string Jenis { get; private set; }
        public string batch { get; private set; }
        public DateOnly tglProduksi { get; private set; }
        public DateOnly tglEXP { get; private set; }

        public AddProduk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            NamaProduk = textBox1.Text;
            HargaProduk = textBox2.Text; // TextBox untuk harga
            gambar = pictureBox1.Image;
            Jenis = textBox3.Text;
            batch = textBox6.Text;

            if (string.IsNullOrWhiteSpace(NamaProduk) || string.IsNullOrWhiteSpace(HargaProduk))
            {
                MessageBox.Show("Silakan isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
