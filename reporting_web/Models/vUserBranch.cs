namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vUserBranch")]
    public partial class vUserBranch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(10)]
        public string Branch { get; set; }

        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Token { get; set; }
    }
}
