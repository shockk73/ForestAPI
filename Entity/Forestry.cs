using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{
    [Table("Admin_Lesnich")]
    public class Forestry
    {

        [Column("LeshosKod")]
        public int? ForestFarmCode { get; set; }

        [Key]
        [Column("LesnichKod")]
        public double ForestryCode { get; set; }

        [Column("LesnichName")]
        public string ForestyName { get; set; }
    }
}