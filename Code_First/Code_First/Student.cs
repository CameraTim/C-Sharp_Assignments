﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Code_First
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Grade Grade { get; set; }
    }
}
