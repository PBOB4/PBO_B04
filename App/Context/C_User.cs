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
            userBaru.password = userBaru.HashPassword(userBaru.password);


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
    }
}
