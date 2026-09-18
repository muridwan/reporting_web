using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class DataTablePagedResult<T>
    {
        public int RecordsTotal { get; set; }

        public int RecordsFiltered { get; set; }

        public List<T> Data { get; set; }
    }
}