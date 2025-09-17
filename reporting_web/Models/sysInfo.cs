namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    [Table("vSysInfo")]
    public partial class sysInfo
    {
        [Key]
        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? SDate { get; set; }
        public DateTime? EDate { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        
        public DateTime? DateExecute { get; set; }
        public DateTime? DateComplete { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
        
    }
}
