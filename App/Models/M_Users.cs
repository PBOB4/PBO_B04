using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_Users
    {
        [Key]
        public int user_id { get; set; }
        [Required, MinLength(4), MaxLength(20)]
        public string username { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Konfirmasi password harus diisi.")]
        public string konfirmasiPassword { get; set; } // Properti untuk validasi konfirmasi password

        [Required]
        public string role { get; set; } = "admin";
        public DateTime created_at { get; set; } = DateTime.Now;

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
            if (string.IsNullOrWhiteSpace(username))
                throw new ValidationException("Username tidak boleh kosong.");
            if (string.IsNullOrWhiteSpace(nama))
                throw new ValidationException("Nama lengkap tidak boleh kosong.");
            if (string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Password tidak boleh kosong.");
            if (password.Length < 6)
                throw new ValidationException("Password harus memiliki minimal 6 karakter.");
            if (password != konfirmasiPassword)
                throw new ValidationException("Password dan konfirmasi password tidak cocok.");
        }
    }
}
