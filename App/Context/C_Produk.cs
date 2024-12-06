using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaSMart_App.App.Core;
using TeaSMart_App.App.Models;


namespace TeaSMart_App.App.Context
{
    internal class C_Produk : DatabaseWrapper
    {
        public List<M_jenis> GetAllJenis()
        {
            return M_jenis.GetJenisTeh();
        }

        private static string table = "produk";

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

            // Query untuk mengambil semua produk
            string query = "SELECT id_produk, namaproduk, hargaproduk, stok, gambar from produk ";

            // Eksekusi query untuk mendapatkan hasil
            DataTable dataTable = DatabaseWrapper.queryExecutor(query);
            foreach(DataRow row in dataTable.Rows)
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


        public static DataTable UpdateProducts(int product_id)
        {
            string query = @"
                Select ";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@product_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = product_id }
            };

            DataTable dataUsers = queryExecutor(query, parameters);
            return dataUsers;
        }
    }
}
