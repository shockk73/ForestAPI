using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{
    [Table("Admin_Plho")]
    public class ForestryProductionAssociation
    {
        [Key]
        [Column("PlhoKod")]
        public int ForestryProductionAssociationCode { get; set; }

        [Column("Plho")]
        public string ForestryProductionAssociationName { get; set; }

        [Column("Kod_Obl")]
        public int? RegionCode { get; set; }

    }
}