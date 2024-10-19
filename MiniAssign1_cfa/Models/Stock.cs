using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniAssign1_cfa.Models
{
    public class Stock
    {
        [Key, Column(Order = 0)]
        public int? StoreID { get; set; }
        public virtual Store Store { get; set; }

        [Key, Column(Order = 1)]
        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}