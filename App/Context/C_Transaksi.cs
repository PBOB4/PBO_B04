using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TeaSMart_App.App.Core;
using TeaSMart_App.App.Models;
using TeaSMart_App.Views;

namespace TeaSMart_App.App.Context
{
    internal class C_Transaksi : DatabaseWrapper
    {
        public static DataTable GetTransaksiData()
        {
            string query = @"
        SELECT 
            t.tanggaltransaksi AS Tanggal_Transaksi, 
            p.namaproduk AS Nama_Produk, 
            j.jenis AS Jenis_Produk, 
            dt.harga AS Harga_Satuan, 
            dt.qty AS Kuantitas, 
            t.totalharga AS Total_Harga,
            u.nama
        FROM
            detailtransaksi dt
        JOIN 
            transaksi t ON dt.id_transaksi = t.id_transaksi
        JOIN 
            produk p ON dt.id_produk = p.id_produk
        JOIN 
            jenis j ON p.id_jenis = j.id_jenis
        JOIN 
            users u ON t.id_user = u.id_user";

            try
            {
                DataTable dataTable = queryExecutor(query);
                return dataTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengambil data transaksi: {ex.Message}");
                return null; 
            }
        }

        public static DataTable GetTransaksiByAdmin(int idUser)
        {
            string query = @"
            SELECT 
                t.tanggaltransaksi AS Tanggal_Transaksi, 
                p.namaproduk AS Nama_Produk, 
                j.jenis AS Jenis_Produk, 
                dt.harga AS Harga_Satuan, 
                dt.qty AS Kuantitas, 
                t.totalharga AS Total_Harga,
                u.nama
            FROM
                detailtransaksi dt
            JOIN 
                transaksi t ON dt.id_transaksi = t.id_transaksi
            JOIN 
                produk p ON dt.id_produk = p.id_produk
            JOIN 
                jenis j ON p.id_jenis = j.id_jenis
            JOIN 
                users u ON t.id_user = u.id_user
            WHERE
                u.id_user = @id_user";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_user", idUser)
            };
            try
            {
                DataTable dataTable = queryExecutor(query, parameters);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengambil data transaksi: {ex.Message}");
                return null;
            }
        }

        public static DataTable GetMAXIdTransaksi(int id)
        {
            try
            {
                string query = @"SELECT * FROM transaksi
                         WHERE id_transaksi = (SELECT MAX(id_transaksi)
                         FROM transaksi)";

                NpgsqlParameter[] parameters = null;

                DataTable dataTransaksi = queryExecutor(query, parameters);
                return dataTransaksi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mendapatkan ID transaksi: " + ex.Message);
                return null; // Tambahkan return null agar semua kode mengembalikan nilai
            }
        }

        public static void insertDataTransaksi(M_transaksi transaksiBaru)
        {
            string query = $@"INSERT INTO transaksi (tanggaltransaksi, totalharga, id_user)
            VALUES (@tanggalTransaksi, @totalHarga, @id_user)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@tanggalTransaksi",transaksiBaru.tanggalTransaksi),
                new NpgsqlParameter("@totalharga", transaksiBaru.totalHarga),
                new NpgsqlParameter("@id_user", transaksiBaru.id_user)
            };
            commandExecutor(query, parameters);
        }

        public static void insertDetailTransaksi (M_detailTransaksi detailTransaksi)
        {
            string query = $@"INSERT INTO detailTransaksi (qty, harga, id_transaksi, id_produk)
            VALUES (@qty, @harga, @id_transaksi, @id_produk)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@qty",detailTransaksi.qty),
                new NpgsqlParameter("@harga", detailTransaksi.harga),
                new NpgsqlParameter("@id_transaksi", detailTransaksi.id_transaksi),
                new NpgsqlParameter("@id_produk", detailTransaksi.id_produk)
            };
            commandExecutor(query, parameters);
        }

        public static void DropTransaksi (int idTransaksi)
        {
            string query = $@"DELETE FROM transaksi WHERE id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_transaksi", idTransaksi)
            };
            commandExecutor(query, parameters);
        }
    }
}
