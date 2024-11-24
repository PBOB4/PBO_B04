using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_batchproduk
    {
        [Key]
        public int batch_id { get; set; }
        [Required]
        public string batch_code { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public DateOnly tanggalProduksi { get; set; }
        [Required]
        public DateOnly tanggalKadaluarsa { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [ForeignKey("M_Produk")]
        public int product_id { get; set; }
    }
}
