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
        public int id_detail { get; set; }
        [Required]
        public int qty { get; set; }
        [Required]
        public Decimal harga { get; set; }
        [ForeignKey("M_Produk")]
        public int id_produk { get; set; }
        [ForeignKey("M_transaski")]
        public int id_transaksi { get; set; }
    }
}
