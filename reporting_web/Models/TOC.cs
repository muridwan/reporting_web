namespace reporting_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOC")]
    public partial class TOC
    {
        [Key]
        [Column("TOC")]
        [StringLength(10)]
        public string TOC1 { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(10)]
        public string COB { get; set; }

        [StringLength(10)]
        public string TOCGroup { get; set; }

        [StringLength(150)]
        public string POLICYTITLE { get; set; }

        public bool? VOYAGE { get; set; }

        public bool? AllowedF { get; set; }

        public bool? RenewableF { get; set; }

        public bool? ReallocationF { get; set; }

        public bool? ReinstatementF { get; set; }

        public bool? ReLimitRTypeF { get; set; }

        public bool? AnnualTreatyF { get; set; }

        public bool? ConsortiumF { get; set; }

        public bool? ConjunctionF { get; set; }

        public bool? BusinessResultF { get; set; }

        public bool? RenewalDataF { get; set; }

        public bool? ClaimOnCancelF { get; set; }

        public bool? ShariaF { get; set; }

        public bool? UniqueRefNoF { get; set; }

        public int? IACCREG { get; set; }

        [StringLength(10)]
        public string REGID { get; set; }

        public int? MPREMIUM { get; set; }

        public int? RPREMIUM { get; set; }

        public int? DPREMIUM { get; set; }

        public short? VALIDATION { get; set; }

        public short? WPC { get; set; }

        public short? RNDAYS { get; set; }

        public short? ELTDAYS { get; set; }

        public short? RQDAYS { get; set; }

        public short? COVERAGE { get; set; }

        public short? PTERM { get; set; }

        public double? Ujroh { get; set; }

        public double? WaadSurplus { get; set; }

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

        [StringLength(10)]
        public string PTOC { get; set; }

        [StringLength(10)]
        public string RFLDID1 { get; set; }

        [StringLength(10)]
        public string RFLDID2 { get; set; }

        [StringLength(10)]
        public string RFLDID3 { get; set; }

        [StringLength(10)]
        public string RFLDID4 { get; set; }

        [StringLength(10)]
        public string RFLDID5 { get; set; }

        [StringLength(50)]
        public string Last_Opr { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Update { get; set; }

        public bool? PrecedeFacCessionF { get; set; }

        public int? CPDAYS { get; set; }

        public bool? ConjunctionAF { get; set; }

        public bool? CancelOnTotalLossF { get; set; }

        public bool? RiskPoolingF { get; set; }

        [StringLength(100)]
        public string LBL_PHOLDER { get; set; }

        [StringLength(100)]
        public string LBL_AID { get; set; }

        [StringLength(150)]
        public string POLICYTITLE_1 { get; set; }

        public bool? EXCLUSIVEF { get; set; }

        public short? Prorata { get; set; }

        public int? EXTPERIOD { get; set; }

        public bool? EXTPERIODINDAYSF { get; set; }

        public double? WaadSurplusOp { get; set; }

        public bool? CommPoolBSF { get; set; }

        public short? CRDAYS { get; set; }

        public bool? WeightedAvgUjrohF { get; set; }

        public bool? ApplyQRCodeF { get; set; }

        public bool? ApplyeStampDutyF { get; set; }

        public bool? ApplyApprLimitByTOLF { get; set; }

        public double? RValue { get; set; }

        public int BlanketTypeVer { get; set; }

        public bool? ApplyeSignF { get; set; }

        public bool? NoRiskAccumulationF { get; set; }

        public short? CSDAYS { get; set; }

        public bool? AutoParsingFieldF { get; set; }

        public bool? CreditLimitF { get; set; }

        public bool? VATBUSINESSF { get; set; }

        [StringLength(10)]
        public string FLDID16 { get; set; }

        [StringLength(30)]
        public string FLDTAG16 { get; set; }

        [StringLength(30)]
        public string FLDTAGA16 { get; set; }

        [StringLength(10)]
        public string FLDID17 { get; set; }

        [StringLength(30)]
        public string FLDTAG17 { get; set; }

        [StringLength(30)]
        public string FLDTAGA17 { get; set; }

        [StringLength(10)]
        public string FLDID18 { get; set; }

        [StringLength(30)]
        public string FLDTAG18 { get; set; }

        [StringLength(30)]
        public string FLDTAGA18 { get; set; }

        [StringLength(10)]
        public string FLDID19 { get; set; }

        [StringLength(30)]
        public string FLDTAG19 { get; set; }

        [StringLength(30)]
        public string FLDTAGA19 { get; set; }

        [StringLength(10)]
        public string FLDID20 { get; set; }

        [StringLength(30)]
        public string FLDTAG20 { get; set; }

        [StringLength(30)]
        public string FLDTAGA20 { get; set; }

        [StringLength(10)]
        public string FLDID21 { get; set; }

        [StringLength(30)]
        public string FLDTAG21 { get; set; }

        [StringLength(30)]
        public string FLDTAGA21 { get; set; }

        [StringLength(10)]
        public string FLDID22 { get; set; }

        [StringLength(30)]
        public string FLDTAG22 { get; set; }

        [StringLength(30)]
        public string FLDTAGA22 { get; set; }

        [StringLength(10)]
        public string FLDID23 { get; set; }

        [StringLength(30)]
        public string FLDTAG23 { get; set; }

        [StringLength(30)]
        public string FLDTAGA23 { get; set; }

        [StringLength(10)]
        public string FLDID24 { get; set; }

        [StringLength(30)]
        public string FLDTAG24 { get; set; }

        [StringLength(30)]
        public string FLDTAGA24 { get; set; }

        [StringLength(10)]
        public string FLDID25 { get; set; }

        [StringLength(30)]
        public string FLDTAG25 { get; set; }

        [StringLength(30)]
        public string FLDTAGA25 { get; set; }

        [StringLength(10)]
        public string FLDID26 { get; set; }

        [StringLength(30)]
        public string FLDTAG26 { get; set; }

        [StringLength(30)]
        public string FLDTAGA26 { get; set; }

        [StringLength(10)]
        public string FLDID27 { get; set; }

        [StringLength(30)]
        public string FLDTAG27 { get; set; }

        [StringLength(30)]
        public string FLDTAGA27 { get; set; }

        [StringLength(10)]
        public string FLDID28 { get; set; }

        [StringLength(30)]
        public string FLDTAG28 { get; set; }

        [StringLength(30)]
        public string FLDTAGA28 { get; set; }

        [StringLength(10)]
        public string FLDID29 { get; set; }

        [StringLength(30)]
        public string FLDTAG29 { get; set; }

        [StringLength(30)]
        public string FLDTAGA29 { get; set; }

        [StringLength(10)]
        public string FLDID30 { get; set; }

        [StringLength(30)]
        public string FLDTAG30 { get; set; }

        [StringLength(30)]
        public string FLDTAGA30 { get; set; }

        public bool? SECURITYNOF { get; set; }

        [StringLength(8)]
        public string DEFSTIME { get; set; }

        [StringLength(8)]
        public string DEFETIME { get; set; }

        public double? InvResult { get; set; }

        public double? InvResultOp { get; set; }

        public bool? TAXINVOICEF { get; set; }

        public bool? NOINPUTF { get; set; }

        public bool? NOCANCELF { get; set; }

        public bool? COMPULSORYF { get; set; }

        [StringLength(255)]
        public string VATDESCRIPTION { get; set; }

        public double? VAT { get; set; }

        public bool? ObjectRestrictionF { get; set; }

        public bool? EachAccRegF { get; set; }

        public bool? VATInstallmentF { get; set; }

        public short? CDDAYS { get; set; }

        public bool? AutoEmailClaimProcessF { get; set; }

        public bool? AutoEmailRenewalNoticeF { get; set; }

        public bool? AutoEmailPolicyExpiredF { get; set; }

        public bool? CLPaymentInvoiceF { get; set; }

        public short? AGEMETHOD { get; set; }

        public bool? ClaimDeductionRefundF { get; set; }

        public bool? ApplyApprLimitByAccRegF { get; set; }

        public bool? AutoClaimPaymentF { get; set; }

        public bool? PremiumFullPaymentOnClaimF { get; set; }

        public bool? CashCallOnPartialPaymentF { get; set; }

        public int? MaxNumDuplReg { get; set; }
    }
}
