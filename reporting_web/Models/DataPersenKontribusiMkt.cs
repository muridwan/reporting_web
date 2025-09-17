using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataPersenKontribusiMkt
    {
        public int SortNo { get; set; }
        public string MKT { get; set; }
        public double Kontribusi { get; set; }
        public double Persentasi { get; set; }
    }
}