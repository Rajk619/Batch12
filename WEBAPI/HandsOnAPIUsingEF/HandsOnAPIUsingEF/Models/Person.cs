using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? Age { get; set; }
        public string City { get; set; }
    }
}
