﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mh.model
{
    public class Skill
    {
        public int _Id { get; set; }
        public string Name { get; set; }
        public int Levels { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
