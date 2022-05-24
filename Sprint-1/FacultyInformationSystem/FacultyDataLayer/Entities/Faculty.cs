using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyDataLayer.Entities
{
    public partial class Faculty
    {
        public string FacultyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
