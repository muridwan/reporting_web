using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reporting_web.Models
{
    [Table("vBranch")]
    public class BranchGroup
    {
        [Key]
        [Column("Branch", Order = 0)]
        [StringLength(10)]
        public string Branch1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(70)]
        public string Name { get; set; }
    }
}