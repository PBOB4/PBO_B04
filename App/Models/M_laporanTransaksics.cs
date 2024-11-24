using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_laporanTransaksi
    {
        [Key]
        public int report_id { get; set; }
        [Required]
        public int month { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public int total_transaction { get; set; }
        [Required]
        public decimal total_revenue { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [ForeignKey("M_Users")]
        public int user_id { get; set; }
    }
}
