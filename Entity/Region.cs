using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{
    [Table("Admin_Obl")]
    public class Region
    {
        [Key]
        [Column("Kod_Obl")]
        public int RegionCode { get; set; }

        [Column("Name_Obl")]
        public string RegionName { get; set;  }
    }
}