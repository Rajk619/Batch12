﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int? Age { get; set; }
    }
}
