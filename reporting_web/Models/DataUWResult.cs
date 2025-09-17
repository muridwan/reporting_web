using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataUWResult
    {
        public string Uraian { get; set; }
        public double Property { get; set; }
        public double Motor { get; set; }
        public double Marine_Cargo { get; set; }
        public double Marine_Hull { get; set; }
        public double Aviation_Hull { get; set; }
        public double Satellite { get; set; }
        public double Energy { get; set; }
        public double Engineering { get; set; }
        public double Liability { get; set; }
        public double General_Accident { get; set; }
        public double Surety_Bond { get; set; }
        public double Miscellaneous { get; set; }
        public double Health { get; set; }
        public string Keterangan { get; set; }

    }
}