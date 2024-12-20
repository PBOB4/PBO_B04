﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaSMart_App.App.Core;
using TeaSMart_App.App.Models;
using TeaSMart_App.Views;


namespace TeaSMart_App.App.Context
{
    internal class C_Produk : DatabaseWrapper
    {
        private static string table = "produk";
        public List<M_jenis> GetAllJenis()
        {
            return M_jenis.GetJenisTeh();
        }

        public static List<M_Produk> SearchProducts(string searchTerm)
        {
            List<M_Produk> filteredProducts = new List<M_Produk>();
            string query = $@"
                SELECT id_produk, namaproduk, hargaproduk, stok, gambar
                FROM {table}
                WHERE namaproduk ILIKE @searchTerm";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@searchTerm", $"%{searchTerm}%")
            };

            DataTable dataTable = DatabaseWrapper.queryExecutor(query, parameters);
            foreach (DataRow row in dataTable.Rows)
            {
                M_Produk produk = new M_Produk
                {
                    id_produk = Convert.ToInt32(row["id_produk"]),
                    namaProduk = row["namaproduk"].ToString(),
                    hargaProduk = Convert.ToDecimal(row["hargaproduk"]),
                    Stok = Convert.ToInt32(row["stok"]),
                    gambar = row["gambar"].ToString()
                };
                filteredProducts.Add(produk);
            }
            return filteredProducts;
        }

        public static void AddProduk(M_Produk produkBaru)
        {
            string query = $@"
                INSERT INTO {table} (namaproduk, hargaproduk, id_jenis, stok, gambar, diperbarui, isactive)
                VALUES (@namaProduk, @hargaProduk, @id_jenis, @stok, @gambar, @diperbarui, @isActive)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaProduk", produkBaru.namaProduk),
                new NpgsqlParameter("@hargaProduk", produkBaru.hargaProduk),
                new NpgsqlParameter("@id_jenis", produkBaru.id_jenis),
                new NpgsqlParameter("@stok", produkBaru.Stok),
                new NpgsqlParameter("@gambar", produkBaru.gambar),
                new NpgsqlParameter("@diperbarui", produkBaru.Diperbarui),
                new NpgsqlParameter("@isActive", produkBaru.isActive)
            };

            commandExecutor(query, parameters);
        }

        public static List<M_Produk> GetAllProduct()
        {
            List<M_Produk> products = new List<M_Produk>();

            string query = $@"SELECT id_produk, namaproduk, hargaproduk, stok, gambar from produk
                WHERE isactive=true";

            DataTable dataTable = queryExecutor(query);
            foreach (DataRow row in dataTable.Rows)
            {
                M_Produk produk = new M_Produk
                {
                    id_produk = Convert.ToInt32(row["id_produk"]),
                    namaProduk = row["namaproduk"].ToString(),
                    hargaProduk = Convert.ToDecimal(row["hargaproduk"]),
                    Stok = Convert.ToInt32(row["stok"]),
                    gambar = row["gambar"].ToString()
                };
                products.Add(produk);
            }
            return products;
        }

        public static void UpdateProduk(M_Produk produkUpdate)
        {
            string query = $@"
            UPDATE {table}
            SET namaproduk = @namaproduk,
                hargaproduk = @hargaProduk,
                id_jenis = @id_jenis,
                stok = @stok,
                gambar = @gambar,
                diperbarui = @diperbarui
            WHERE id_produk = @id_produk";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", produkUpdate.id_produk),
                new NpgsqlParameter("@namaProduk", produkUpdate.namaProduk),
                new NpgsqlParameter("@hargaProduk", produkUpdate.hargaProduk),
                new NpgsqlParameter("@id_jenis", produkUpdate.id_jenis),
                new NpgsqlParameter("@stok", produkUpdate.Stok),
                new NpgsqlParameter("@gambar", produkUpdate.gambar),
                new NpgsqlParameter("@diperbarui", produkUpdate.Diperbarui)
            };

            commandExecutor(query, parameters);
        }

        public static void DelProduk(int idProduk)
        {
            string query = $@"
                UPDATE produk
                SET isactive = false
                WHERE id_produk = @id_produk";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", idProduk)
            };

            commandExecutor(query, parameters);
        }

        public static List<M_Produk> GetCheckedProduk(List<M_Produk> allProducts, List<(string namaProduk, int qty)> selectedItems)
        {
            var selectedProducts = new List<M_Produk>();

            foreach (var item in selectedItems)
            {
                var produk = allProducts.FirstOrDefault(p => p.namaProduk == item.namaProduk);
                if (produk != null)
                {
                    produk.SelectedQty = item.qty;  
                    selectedProducts.Add(produk);
                }
            }

            return selectedProducts;
        }

        public static List<M_Produk> GetProdukTerlaris()
        {
            List<M_Produk> products = new List<M_Produk>();
            string query = @"
                SELECT 
                    p.namaProduk, p.hargaproduk, 
                    SUM(dt.qty) AS total_qty,
                    p.gambar

                FROM 
                    detailtransaksi dt
                JOIN 
                    produk p ON dt.id_produk = p.id_produk
                GROUP BY 
                    p.namaProduk, p.hargaproduk, p.gambar
                ORDER BY 
                    total_qty DESC
                LIMIT 3";

            DataTable dataTable = DatabaseWrapper.queryExecutor(query);
            foreach (DataRow row in dataTable.Rows)
            {
                M_Produk produk = new M_Produk
                {
                    namaProduk = row["namaproduk"].ToString(),   
                    hargaProduk = Convert.ToDecimal(row["hargaproduk"]),  
                    gambar= row["gambar"].ToString()
                };

                products.Add(produk);
            }
            return products;
        }

        public static void UpdateStokProduk (int id_produk, int newStok)
        {
            try
            {
                string query = "UPDATE produk SET stok = @newStock WHERE id_produk =@id_produk";

                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@newStock", newStok),
                    new NpgsqlParameter("@id_produk", id_produk)
                };

                commandExecutor(query, parameters);
            }
            catch
            {

            }
        }
    }
}
