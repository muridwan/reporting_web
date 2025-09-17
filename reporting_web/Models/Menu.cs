namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdMenu { get; set; }
        [StringLength(255)]
        public string CodeMenu { get; set; }
        [StringLength(255)]
        public string Title { get; set; }

        public int? Parent { get; set; }

        [StringLength(255)]
        public string UrlMenu { get; set; }

        public int? levelMenu { get; set; }

        public int? SortMenu { get; set; }

        public Boolean DisplayMenu { get; set; }
    }
}
