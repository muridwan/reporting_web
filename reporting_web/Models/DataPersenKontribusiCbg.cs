using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataPersenKontribusiCbg
    {
        public int SortNo { get; set; }
        public string branch { get; set; }
        public string Name { get; set; }
        public double Kontribusi { get; set; }
        public double Persentasi { get; set; }
        public double NilaiRKAP { get; set; }
        public double NilaiGS { get; set; }
        public double PersenRKAP { get; set; }
        public double PersenGS { get; set; }
    }
}