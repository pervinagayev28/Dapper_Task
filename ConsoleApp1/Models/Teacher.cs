﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Teacher
    {
     
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdDep { get; set; }

 
    }
}
