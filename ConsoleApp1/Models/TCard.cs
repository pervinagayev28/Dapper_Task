﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class TCard
    {
        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public int IdBook { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public int IdLib { get; set; }

    }
}
