using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaSMart_App.App.Context;

namespace TeaSMart_App.App.Models
{
    internal class M_jenis
    {
        [Key]
        public int id_jenis { get; set; }
        [Required]
        public string jenis { get; set; }

        public static List<M_jenis> GetJenisTeh()
        {
            return new List<M_jenis>
            {
                new M_jenis { id_jenis = 1, jenis = "Ekonomis" },
                new M_jenis { id_jenis = 2, jenis = "Premium" },
                new M_jenis { id_jenis = 3, jenis = "Limited-Edition" }
            };
        }

        // Mendapatkan ID berdasarkan nama jenis teh
        //public static int GetIdByNamaJenis(string namaJenis)
        //{
        //    switch (namaJenis)
        //    {
        //        case "Ekonomis":
        //            return 1;
        //        case "Premium":
        //            return 2;
        //        case "Limited-Edition":
        //            return 3;
        //        default:
        //            throw new ArgumentException("Jenis teh tidak valid");
        //    }
        //}
    }
}
