using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaSMart_App.App.Core;
using TeaSMart_App.App.Models;

namespace TeaSMart_App.App.Context
{
    internal class C_User : DatabaseWrapper
    {
        private static string table = "users"; // pakai nama tabel di database
        public static bool IsUsernameUnique(string username)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username";

            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = username }
    };

            long count = Convert.ToInt64(DatabaseWrapper.ExecuteScalarQuery(query, parameters));
            return count == 0; // True jika username tidak ditemukan
        }

        public static void Register(M_Users userBaru)
        {
            userBaru.Validate();
            userBaru.password = userBaru.password;


            string query = $@"
                INSERT INTO {table} (nama, username, password, role) 
                VALUES (@nama, @username, @password, @role)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", userBaru.nama),
                new NpgsqlParameter("@username", userBaru.username),
                new NpgsqlParameter("@password", userBaru.password),
                new NpgsqlParameter("@role", userBaru.role)
            };

            commandExecutor(query, parameters);
        }

        public static M_Users Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username dan password tidak boleh kosong.");
            }

            M_Users user = null;

            // Query untuk mengecek username dan password
            string query = $@"
            SELECT id_user, nama, username, password, role 
            FROM {table} 
            WHERE username = @username AND password = @password";

            // Parameter untuk mencegah SQL Injection
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
            };

            try
            {
                // Eksekusi query
                DataTable result = queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    // Jika user ditemukan, buat objek M_Users
                    DataRow row = result.Rows[0];
                    user = new M_Users
                    {
                        id_user = Convert.ToInt32(row["id_user"]), // Sesuaikan nama kolom di sini
                        nama = row["nama"].ToString(),
                        username = row["username"].ToString(),
                        password = row["password"].ToString(),
                        role = row["role"].ToString()
                    };
                }
                else
                {
                    // Jika tidak ditemukan, lempar exception
                    throw new Exception("Username atau password salah.");
                }
            }
            catch (Exception ex)
            {
                // Tangani error (bisa log atau lempar ulang exception)
                throw new Exception($"Terjadi kesalahan saat login: {ex.Message}");
            }

            return user;
        }
    }
}