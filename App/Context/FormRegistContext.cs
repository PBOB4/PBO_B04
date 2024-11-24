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
    internal class FormRegistContext : DatabaseWrapper
    {
        private static string table = "users"; // pakai nama tabel di database

        public static DataTable getUsersById(int user_id)
        {
            string query = @"
                SELECT user_id, username, nama, role  
                FROM users
                WHERE user_id = @user_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = user_id }
            };

            DataTable dataUsers = queryExecutor(query, parameters);
            return dataUsers;
        }

        public static void Register(M_Users userBaru)
        {
            if (string.IsNullOrWhiteSpace(userBaru.nama) || string.IsNullOrWhiteSpace(userBaru.username) || string.IsNullOrWhiteSpace(userBaru.password))
            {
                throw new ArgumentException("Semua field harus diisi.");
            }

            if (userBaru.password.Length < 6)
            {
                throw new ArgumentException("Password harus memiliki minimal 6 karakter.");
            }

            // Hash password
            userBaru.password = userBaru.HashPassword(userBaru.password);


            string query = $@"
                INSERT INTO {table} (nama, username, password, role, created_at) 
                VALUES (@nama, @username, @password, @role, @created_at)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", userBaru.nama),
                new NpgsqlParameter("@username", userBaru.username),
                new NpgsqlParameter("@password", userBaru.password),
                new NpgsqlParameter("@role", userBaru.role),
                new NpgsqlParameter("@created_at", userBaru.created_at)
            };

            commandExecutor(query, parameters);
        }
    }
}
