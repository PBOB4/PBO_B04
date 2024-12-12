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

        public Pembayaran(List<M_Produk> selectedProducts)
        {
            InitializeComponent();
            this.selectedProducts = selectedProducts;

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
                    Size = new Size(410, 49),
                    Location = new Point(3, 3),
                    Margin = new Padding(5)
                };

                Label lblHarga = new Label
                {
                    Text = $"Rp{produk.hargaProduk.ToString()}",
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
                    Text = $"Rp{produk.SelectedQty * produk.hargaProduk}",
                    AutoSize = true,
                    //Size = new Size(97, 20),
                    Font = new Font("Arial", 10),
                    Location = new Point(377, 14)
                };
                produkPanel.Controls.Add(lblTotal);

                // Tambahkan panel ke FlowLayoutPanel
                flyProduk.Controls.Add(produkPanel);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventarisAdmin inventarisAdmin = new InventarisAdmin();
            inventarisAdmin.Show();
            this.Close();
        }
    }
}