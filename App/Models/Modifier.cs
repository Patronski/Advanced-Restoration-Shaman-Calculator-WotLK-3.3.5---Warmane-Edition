﻿using App.Models.Enums;
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
        public Modifier()
        {
            this.CheckBox = new System.Windows.Forms.CheckBox();
        }

        public ModifierType Type { get; set; }

        public double Value { get; set; }

        public string Display { get; set; }

        public bool UseExtraNumber { get; set; }

        public CheckBox CheckBox { get; set; }

        public abstract int Modify();
    }
}
