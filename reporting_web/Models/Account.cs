namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [Column("Account")]
        [StringLength(10)]
        public string Account1 { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Parent { get; set; }

        public bool? Post_Flag { get; set; }

        public short? Level { get; set; }

        [StringLength(1)]
        public string Type { get; set; }

        public bool? NL_Flag { get; set; }

        public double? Actual { get; set; }

        public bool? PL_Flag { get; set; }

        public bool? Open_ItemF { get; set; }

        public bool? Hold_Flag { get; set; }

        [StringLength(100)]
        public string Description1 { get; set; }

        public bool? Monetary_Flag { get; set; }

        public bool? PT_Flag { get; set; }

        public bool? Fiscal_Flag { get; set; }

        public bool? Suspend_Flag { get; set; }

        public bool? AllowedF { get; set; }

        [StringLength(50)]
        public string Last_Opr { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Update { get; set; }

        [StringLength(1)]
        public string AccGroup { get; set; }

        public bool? Inter_Flag { get; set; }
    }
}
