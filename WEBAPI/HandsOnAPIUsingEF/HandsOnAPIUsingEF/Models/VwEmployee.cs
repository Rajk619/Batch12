using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class VwEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }
        public int? Salary { get; set; }
    }
}
