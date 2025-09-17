using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataSettleKlaim
    {
      public int SortNo { get; set; }
      public int ano { get; set; }
      public string CLAIMNO { get; set; }
      public string POLICYNO { get; set; }
      public string CERTIFICATENO { get; set; }
      public string COB { get; set; }
      public string COB_Desc { get; set; }
      public string BRANCH_DESCRIPTION { get; set; }
      public string PolicyHolder { get; set; }
      public string INSURED { get; set; }
      public string OBJECT_INFORMATION { get; set; }
      public double TSI { get; set; }
      public string PERIOD { get; set; }
      public DateTime SDATE { get; set; }
      public DateTime EDATE { get; set; }
      public int UWYear { get; set; }
      public string TOC { get; set; }
      public string TOC_DESC { get; set; }
      public string CauseOfLoss { get; set; }
      public DateTime RegDate { get; set; }
      public DateTime ReportDate { get; set; }
      public DateTime LossDate { get; set; }
      public DateTime Settle_Date { get; set; }
      public string Description_Of_Loss { get; set; }
      public string CURRENCY { get; set; }
      public double Idemnitiy { get; set; }
      public double Deductible { get; set; }
      public double Salvage { get; set; }
      public double Expense { get; set; }
      public double Subrogation { get; set; }
      public double Adjusment { get; set; }
      public double TAX { get; set; }
      public double GROSS { get; set; }
      public double COOUT { get; set; }
      public double GROSSNET { get; set; }
      public double Compulsory { get; set; }
      public double ExcessPriority { get; set; }
      public double QuotaShare { get; set; }
      public double Surplus { get; set; }
      public double Decree { get; set; }
      public double AutoFacultative { get; set; }
      public double Facultative { get; set; }
      public double XOL { get; set; }
      public double ANR { get; set; }
      public DateTime BOD { get; set; }
      public string Employment { get; set; }
      public DateTime DOB { get; set; }
      public string Desc_NOC { get; set; }
      public string Usia { get; set; }
      public string KAT_USIA { get; set; }
      public double GROSSNET2 { get; set; }
      public double KLAIM { get; set; }
      public double Persentase { get; set; }   
      public double JUM_KLAIM { get; set; } 
      public string Kat_Jarak_Baru_Sd_Klaim { get; set; }
    }
}