namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaldoAwalBjlLalu")]
    public partial class SaldoAwalBjlLalu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tahun { get; set; }

        public double? SaldoAwalBerjalan { get; set; }

        public double? SaldoAwalLalu { get; set; }
    }
}
