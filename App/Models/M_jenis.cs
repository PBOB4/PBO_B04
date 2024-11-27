using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaSMart_App.App.Models
{
    internal class M_jenis
    {
        [Key]
        public int id_jenis { get; set; }
        [Required]
        public string jenis { get; set; }
    }
}
