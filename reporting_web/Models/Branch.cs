namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch
    {
        [Key]
        [Column("Branch", Order = 0)]
        [StringLength(10)]
        public string Branch1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime Start_Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? End_Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LockedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FLockedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BackDatedDate { get; set; }

        public short? Month { get; set; }

        public short? Year { get; set; }

        [StringLength(10)]
        public string RE_Account { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string PL_Account { get; set; }

        [StringLength(10)]
        public string GL_Account { get; set; }

        [StringLength(10)]
        public string TX_Account { get; set; }

        [StringLength(10)]
        public string DV_Account { get; set; }

        [StringLength(10)]
        public string IO_Account { get; set; }

        public bool? Op_Flag { get; set; }

        public bool? ShariaF { get; set; }

        [StringLength(10)]
        public string Parent { get; set; }

        [StringLength(70)]
        public string PIC { get; set; }

        [StringLength(50)]
        public string PICTitle { get; set; }

        public short? CMonth { get; set; }

        public short? CYear { get; set; }

        public bool? Active_Flag { get; set; }

        [StringLength(10)]
        public string CCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Combine_Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Elimination_Date { get; set; }

        public bool? UC_Flag { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string TaxID { get; set; }

        [StringLength(10)]
        public string KPPID { get; set; }

        [StringLength(50)]
        public string KPP { get; set; }

        [StringLength(50)]
        public string Last_Opr { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Update { get; set; }

        [StringLength(10)]
        public string BAlias { get; set; }

        public int? SignerImageID { get; set; }

        [StringLength(255)]
        public string SignerName { get; set; }

        [StringLength(255)]
        public string SignerTitle { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public double? VAT { get; set; }

        public int? SignerImageID_1 { get; set; }

        [StringLength(255)]
        public string SignerName_1 { get; set; }

        [StringLength(255)]
        public string SignerTitle_1 { get; set; }

        public int? SignerImageID_2 { get; set; }

        [StringLength(255)]
        public string SignerName_2 { get; set; }

        [StringLength(255)]
        public string SignerTitle_2 { get; set; }
        [StringLength(10)]
        public string BranchGroup { get; set; }
    }
}
