﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Totems
{
    public class Totem
    {
        public int Mana { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}