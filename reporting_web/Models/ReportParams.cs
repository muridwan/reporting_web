using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class ReportParams<T>
    {
        public string RptFileName { get; set; }

        public string ReportTitle { get; set; }

        public List<T> DataSource { get; set; }
        public Boolean IsPassParamToCr { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public DateTime dtTimeParam1 { get; set; }
        public DateTime dtTimeParam2 { get; set; }
    }
}