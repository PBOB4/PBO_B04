using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_transaksi
    {
        [Key]
        public int id_transaksi { get; set; }
        [Required]
        public DateTime tanggalTransaksi { get; set; }
        [Required]
        public Decimal totalBayar { get; set; }
        [ForeignKey("M_User")]
        public int id_user { get; set; }
    }
}
