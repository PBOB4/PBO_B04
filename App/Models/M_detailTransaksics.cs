using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_detailTransaksi
    {
        [Key]
        public int detail_id { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public Decimal price { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [ForeignKey("M_Produk")]
        public int product_id { get; set; }
        [ForeignKey("M_transaski")]
        public int transaction_id { get; set; }
        [ForeignKey("M_batchproduk")]
        public int batch_id { get; set; }
    }
}
