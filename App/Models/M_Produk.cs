using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_Produk
    {
        [Key]
        public int product_id { get; set; }
        [Required]
        public string product_name { get; set; }
        [Required]
        public Decimal unit_price { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        [Required]
        public Boolean isActive { get; set; }
    }
}
