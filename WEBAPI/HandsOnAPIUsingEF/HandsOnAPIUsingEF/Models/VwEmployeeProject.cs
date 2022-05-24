using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class VwEmployeeProject
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
    }
}
