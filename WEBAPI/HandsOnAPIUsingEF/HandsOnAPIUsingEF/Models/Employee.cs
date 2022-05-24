using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseManagerNavigation = new HashSet<Employee>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }
        public int? Salary { get; set; }
        public string ProjectCode { get; set; }
        public int? Manager { get; set; }

        public virtual Employee ManagerNavigation { get; set; }
        public virtual Project ProjectCodeNavigation { get; set; }
        public virtual ICollection<Employee> InverseManagerNavigation { get; set; }
    }
}
