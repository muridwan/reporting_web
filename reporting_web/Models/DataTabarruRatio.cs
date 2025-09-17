using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataTabarruRatio
    {
        public string BRANCH_DESCRIPTION { get; set; }
        public double Tabarru { get; set; }
        public double Klaim { get; set; }
        public double Ratio { get; set; }

    }
}