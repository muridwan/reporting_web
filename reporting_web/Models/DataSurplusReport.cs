using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataSurplusReport
    {
        public string Uraian { get; set; }
        public double TahunBerjalan { get; set; }
        public double TahunLalu { get; set; }
    }
}