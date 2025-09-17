using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataPersenKontribusiCob
    {
        public int SortNo { get; set; }
        public string COB { get; set; }
        public string Description { get; set; }
        public double Kontribusi { get; set; }
        public double Persentasi { get; set; }

    }
}