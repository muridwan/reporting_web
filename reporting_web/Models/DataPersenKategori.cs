using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataPersenKategori
    {
        public int NO_KATEGORI_USIA { get; set; }
        public int NO_KATEGORI_TSI { get; set; }
        public int NO_KATEGORI_KONTRIBUSI { get; set; }
        public string KATEGORI_USIA { get; set; }
        public string KATEGORI_TSI { get; set; }
        public string KATEGORI_KONTRIBUSI { get; set; }
        public double Kontribusi { get; set; }
        public double Persentase { get; set; }
        public double Jumlah { get; set; }
    }
}