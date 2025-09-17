namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class DataSysLog 
    {
        public string Type { get; set; }
        public DateTime SDate { get; set; }
        public DateTime EDate { get; set; }
        public DateTime DateExecute { get; set; }
        public DateTime DateComplete { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public int CountRecord { get; set; }
    }
}
