using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniAssign1_cfa.Models
{
    public class Category
    {

        [Key]
        public int CategoryID { get; set; }

        [StringLength(250)]
        public string Category_Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}