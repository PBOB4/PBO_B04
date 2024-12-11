using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    public class M_Produk
    {
        [Key]
        public int id_produk { get; set; }
        [Required]
        public string namaProduk { get; set; }
        [Required]
        public Decimal hargaProduk { get; set; }
        [ForeignKey("M_jenis")]
        public int id_jenis { get; set; }
        [Required]
        public DateTime Diperbarui { get; set; }
        [Required]
        public int Stok { get; set; }
        [Required]
        public string gambar { get; set; }
        [Required]
        public Boolean isActive { get; set; }

        [NotMapped] // Jangan simpan ke database
        public int SelectedQty { get; set; } = 0;

    }
}
