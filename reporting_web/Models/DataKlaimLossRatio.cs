using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataKlaimLossRatio
    {
        public string Branch { get; set; }
        public string Branch_Name { get; set; }
        public string TOC { get; set; }
        public string TOC_NAME { get; set; }
        public string Segmen { get; set; }
        public double Premi { get; set; }
        public double Potongan { get; set; }
        public double PremiNet { get; set; }
        public double SettleKlaim { get; set; }
        public double Subrogasi { get; set; }
        public double KlaimNet { get; set; }
        public double OSKlaim { get; set; }
        public double LR_SettleKlaim { get; set; }

        // INTERNAL
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public double TotalClaim { get; set; }

        public double LR_Gross_Total { get; set; }

        public double LR_Gross_SettledNet { get; set; }

        public double LR_Net_Settled { get; set; }

        public double LR_Net_Total { get; set; }

        public double LR_Net_SettledNet { get; set; }
    }
}
