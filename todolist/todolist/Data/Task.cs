﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todolist.Data
{
    public class Task
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

    }
}
