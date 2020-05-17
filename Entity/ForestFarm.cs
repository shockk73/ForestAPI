using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{

    [Table("Admin_Leshos")]
    public class ForestFarm
    {
        [Key]
        [Column("LeshosKod")]
        public int ForestFarmCode { get; set; }

        [Column("Leshos")]
        public string ForestFarmName { get; set; }

        [Column("PlhoKod")]
        public int? ForestryProductionAssociationCode { get; set; }
    }
}