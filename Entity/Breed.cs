using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForestInfo.Entity
{
    [Table("ref_10200003")]
    public class Breed
    {
        [Key]
        [Column("RefValue_ID")]
        public int Code { get; set; }

        [Column("RefValue_txt")]
        public string Name { get; set; }
    }
}