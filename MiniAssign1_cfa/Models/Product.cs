using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniAssign1_cfa.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(250)]
        public string Product_Name { get; set; }

        [StringLength(4)]
        public string ModelYear { get; set; }


        public decimal ListPrice { get; set; }

        // Brand: Foreign key
        [ForeignKey("Brand")]
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }

        // Category: Foreign key
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        // referenced by the stock entity
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}