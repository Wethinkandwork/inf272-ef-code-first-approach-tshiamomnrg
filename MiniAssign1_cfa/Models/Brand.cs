using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniAssign1_cfa.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        [Required]
        [StringLength(250)]
        public string Brand_Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}