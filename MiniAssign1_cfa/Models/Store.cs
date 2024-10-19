using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniAssign1_cfa.Models
{
    public class Store
    {

        [Key]
        public int StoreID { get; set; }

        [StringLength(250)]
        public string Store_Name { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(250)]
        public string Street { get; set; }

        [StringLength(250)]
        public string City { get; set; }

        [StringLength(250)]
        public string State { get; set; }

        [StringLength(4)]
        public string Zip_Code { get; set; }
    }
}