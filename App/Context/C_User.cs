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
            // Query untuk mengecek username dan password
            string query = $@"
            SELECT nama, username, password, role 
            FROM {table} 
            WHERE username = @username AND password = @password";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
            };

            // Eksekusi query
            DataTable result = queryExecutor(query, parameters);

            if (result.Rows.Count > 0)
            {
                // Jika user ditemukan, kembalikan objek M_Users
                DataRow row = result.Rows[0];
                return new M_Users
                {
                    nama = row["nama"].ToString(),
                    username = row["username"].ToString(),
                    password = row["password"].ToString(),
                    role = row["role"].ToString()
                };
            }
            else
            {
                // Jika tidak ditemukan, kembalikan null atau throw exception
                throw new Exception("Username atau password salah.");
            }
        }

    }
}
