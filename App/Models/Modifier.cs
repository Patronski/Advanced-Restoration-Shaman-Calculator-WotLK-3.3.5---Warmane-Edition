using App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models
{
    public abstract class Modifier
    {
        public ModifierType Type { get; set; }

        public double Value { get; set; }

        public string Display { get; set; }

        public bool UseExtraNumber { get; set; }

        //public int NumberY { get; set; } // * (1 + (Y / 10)) - Y is from 0 to 100

        public CheckBox CheckBox { get; set; }

        public abstract int Modify();
    }
}
