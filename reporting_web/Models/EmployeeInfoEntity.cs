using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reporting_web.Models
{
    public class EmployeeInfoEntity
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
    }
}