using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataProduksi
    {
        public int ANO { get; set; }
        public string POLIS { get; set; }
        public string STATUS { get; set; }
        public string PolicyHolder { get; set; }
        public string NAMA_PESERTA { get; set; }
        public string OBJ_TERTANGGUNG { get; set; }
        public string OBJ_INFO { get; set; }
        public string Jenis_Pertanggungan { get; set; }
        public string Branch { get; set; }
        public string TOC { get; set; }
        public string TOC_NAME { get; set; }
        public string COB { get; set; }
        public string COB_NAME { get; set; }
        public DateTime TGLPRODUKSI { get; set; }
        public DateTime TGLAWAL { get; set; }
        public DateTime TGLAKHIR { get; set; }
        public double TSI { get; set; }
        public double PREMI { get; set; }
        public string Currency { get; set; }
        public double Tabarru { get; set; }
        public double Ujroh { get; set; }
        public double Premi_QS_Reas { get; set; }
        public double Tabarru_QS_Reas { get; set; }
        public double Ujro_QS_Reas { get; set; }
        public double CedantTabarru_QS_Nett { get; set; }
        public double CedantTabarru_QS_OR { get; set; }
        public string QSCODE { get; set; }
        public double CedantTabarru_S1_Nett { get; set; }
        public double CedantTabarru_S1_OR { get; set; }
        public double Tabarru_S1_Reas { get; set; }
        public double Ujroh_S1_Reas { get; set; }
        public double Premi_S1_Reas { get; set; }
        public string SP1CODE { get; set; }
        public double Premi_FO_Reas { get; set; }
        public double Tabarru_FO_Reas { get; set; }
        public double Ujroh_FO_Reas { get; set; }
        public string AID { get; set; }
        public double KOMISI { get; set; }
        public double DISKON { get; set; }
        public double BROKERFEE { get; set; }
    }
}