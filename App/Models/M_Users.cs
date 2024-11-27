using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaSMart_App.App.Context;

namespace TeaSMart_App.App.Models
{
    internal class M_Users
    {
        [Key]
        public int id_user { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [NotMapped]
        public string konfirmasiPassword { get; set; }
        [Required]
        public string role { get; set; } = "admin";

        public string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(nama))
                throw new ValidationException("Nama tidak boleh kosong.");
            if (string.IsNullOrWhiteSpace(username))
                throw new ValidationException("Username tidak boleh kosong.");
            string usernamePattern = @"^[a-zA-Z0-9_.]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, usernamePattern))
                throw new ValidationException("Username hanya boleh mengandung huruf, angka, '_' atau '.'");
            if (username.Contains(" "))
                throw new ValidationException("Username tidak boleh mengandung spasi.");
            if (!C_User.IsUsernameUnique(username))
                throw new ValidationException("Username sudah digunakan. Silakan pilih username lain.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Password tidak boleh kosong.");
            if (password.Length < 6)
                throw new ValidationException("Password harus memiliki minimal 6 karakter.");
            if (password != konfirmasiPassword)
                throw new ValidationException("Password dan konfirmasi password tidak cocok.");
        }
    }
}
