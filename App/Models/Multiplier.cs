using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Multiplier
    {
        public double Value { get; set; }

        public string Display { get; set; }

        public int NumberY { get; set; } // * (1 + (Y / 10)) - Y is from 0 to 100

        public bool IsOnlyForCritical { get; set; }
    }
}
