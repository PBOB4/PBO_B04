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
        public int transaction_id { get; set; }
        [Required]
        public DateTime transaction_date { get; set; }
        [Required]
        public Decimal total_amount { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [ForeignKey("M_Users")]
        public int users_id { get; set; }
    }
}
