using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{
    [Table("ref_10200050")]
    public class GroundCover
    {
        [Key]
        [Column("RefValue_ID")]
        public double Code { get; set; }

        [Column("RefValue_txt")]
        public string Name { get; set; }
    }
}