namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COB")]
    public partial class COB
    {
        [Key]
        [Column("COB")]
        [StringLength(10)]
        public string COB1 { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(10)]
        public string FLDID1 { get; set; }

        [StringLength(30)]
        public string FLDTAG1 { get; set; }

        [StringLength(30)]
        public string FLDTAGA1 { get; set; }

        [StringLength(10)]
        public string FLDID2 { get; set; }

        [StringLength(30)]
        public string FLDTAG2 { get; set; }

        [StringLength(30)]
        public string FLDTAGA2 { get; set; }

        [StringLength(10)]
        public string FLDID3 { get; set; }

        [StringLength(30)]
        public string FLDTAG3 { get; set; }

        [StringLength(30)]
        public string FLDTAGA3 { get; set; }

        [StringLength(10)]
        public string FLDID4 { get; set; }

        [StringLength(30)]
        public string FLDTAG4 { get; set; }

        [StringLength(30)]
        public string FLDTAGA4 { get; set; }

        [StringLength(10)]
        public string FLDID5 { get; set; }

        [StringLength(30)]
        public string FLDTAG5 { get; set; }

        [StringLength(30)]
        public string FLDTAGA5 { get; set; }

        [StringLength(10)]
        public string FLDID6 { get; set; }

        [StringLength(30)]
        public string FLDTAG6 { get; set; }

        [StringLength(30)]
        public string FLDTAGA6 { get; set; }

        [StringLength(10)]
        public string FLDID7 { get; set; }

        [StringLength(30)]
        public string FLDTAG7 { get; set; }

        [StringLength(30)]
        public string FLDTAGA7 { get; set; }

        [StringLength(10)]
        public string FLDID8 { get; set; }

        [StringLength(30)]
        public string FLDTAG8 { get; set; }

        [StringLength(30)]
        public string FLDTAGA8 { get; set; }

        [StringLength(10)]
        public string FLDID9 { get; set; }

        [StringLength(30)]
        public string FLDTAG9 { get; set; }

        [StringLength(30)]
        public string FLDTAGA9 { get; set; }

        [StringLength(10)]
        public string FLDID10 { get; set; }

        [StringLength(30)]
        public string FLDTAG10 { get; set; }

        [StringLength(30)]
        public string FLDTAGA10 { get; set; }

        [StringLength(10)]
        public string FLDID11 { get; set; }

        [StringLength(30)]
        public string FLDTAG11 { get; set; }

        [StringLength(30)]
        public string FLDTAGA11 { get; set; }

        [StringLength(10)]
        public string FLDID12 { get; set; }

        [StringLength(30)]
        public string FLDTAG12 { get; set; }

        [StringLength(30)]
        public string FLDTAGA12 { get; set; }

        [StringLength(10)]
        public string FLDID13 { get; set; }

        [StringLength(30)]
        public string FLDTAG13 { get; set; }

        [StringLength(30)]
        public string FLDTAGA13 { get; set; }

        [StringLength(10)]
        public string FLDID14 { get; set; }

        [StringLength(30)]
        public string FLDTAG14 { get; set; }

        [StringLength(30)]
        public string FLDTAGA14 { get; set; }

        [StringLength(10)]
        public string FLDID15 { get; set; }

        [StringLength(30)]
        public string FLDTAG15 { get; set; }

        [StringLength(30)]
        public string FLDTAGA15 { get; set; }

        [StringLength(50)]
        public string Last_Opr { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Update { get; set; }
    }
}
