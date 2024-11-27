using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_batch
    {
        [Key]
        public int batch_id { get; set; }
        [Required]
        public DateOnly tanggalMasuk { get; set; }
        [Required]
        public int stok { get; set; }
        [Required]
        public DateOnly tanggalProduksi { get; set; }
        [Required]
        public DateOnly Kadaluarsa { get; set; }
    }
}
