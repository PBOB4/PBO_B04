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
        private static string table = "products";

        public static DataTable AddProducts(int product_id) //JOIN KAH?
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

        public static DataTable All(int product_id)
        {
            string query = @"
                select product_name, unit_price, image from products ";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@product_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = product_id }
            };

            DataTable dataUsers = queryExecutor(query, parameters);
            return dataUsers;
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
