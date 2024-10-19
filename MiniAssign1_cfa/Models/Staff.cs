using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniAssign1_cfa.Models
{
    public class Staff
    {

        [Key]
        public int StaffID { get; set; }

        [StringLength(250)]
        public string First_Name { get; set; }

        [StringLength(250)]
        public string Last_Name { get; set; }

        [EmailAddress]
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Phone { get; set; }

        [Required]
        public bool isActive { get; set; }

        // Store: Foreign Key
        [ForeignKey("Store")]
        public int? StoreID { get; set; }
        public virtual Store Store { get; set; }

    }
}