using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataKlaimSumbis
    {
        public string KANTOR_OPERASIONAL { get; set; }

        public int BPD_JUMLAH_KLAIM { get; set; }
        public double BPD_NILAI_KLAIM { get; set; }

        public int BSI_JUMLAH_KLAIM { get; set; }
        public double BSI_NILAI_KLAIM { get; set; }

        public int PEGADAIAN_JUMLAH_KLAIM { get; set; }
        public double PEGADAIAN_NILAI_KLAIM { get; set; }

        public int PNM_JUMLAH_KLAIM { get; set; }
        public double PNM_NILAI_KLAIM { get; set; }

        public int TRAVEL_JUMLAH_KLAIM { get; set; }
        public double TRAVEL_NILAI_KLAIM { get; set; }

        public int LAIN_JUMLAH_KLAIM { get; set; }
        public double LAIN_NILAI_KLAIM { get; set; }

        public double TOTAL_JUMLAH_KLAIM { get; set; }
        public double TOTAL_NILAI_KLAIM { get; set; }
    }
}