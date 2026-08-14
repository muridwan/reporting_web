using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataGrowthKontribusi
    {
        public int Tahun { get; set; }
        public double Kontribusi { get; set; }
        public double Klaim { get; set; }
        public double LossRatio { get; set; }
        public double GrowthKontribusi { get; set; }
    }
}