using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataSumProduksiKlaim
    {
        public double Kontribusi { get; set; }
        public double Klaim { get; set; }
        public double RKAPKontribusi { get; set; }
        public double RKAPKlaimBruto { get; set; }
        public double GSKontribusi { get; set; }

    }
}