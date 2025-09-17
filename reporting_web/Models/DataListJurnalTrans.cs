using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataListJurnalTrans
    {
        public string Voucher { get; set; }
        public DateTime date_trans {get; set;}
        public string Account { get; set; }
        public string Currency { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public string Description { get; set; }
        public string Branch { get; set; }
        public string NameBranch { get; set; }
        public string Remarks { get; set; }

    }
}