﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public abstract class Spell
    {
        public Spell(int spellPower)
        {
            this.Ranks = new List<Rank>();
            this.PlayerSpellPower = spellPower;
        }

        public string Name { get; set; }

        public List<double> Multipliers { get; set; }

        public double Critical { get; set; }

        public int RanksCount { get; set; }

        public int PlayerSpellPower { get; set; }

        public List<Rank> Ranks { get; set; }

        public bool IsDamageVarying { get; set; }

        public abstract int Calculate(Rank rank);

        public class Rank
        {
            public double Num1 { get; set; }

            public int NumFrom { get; set; }

            public int NumTo { get; set; }

            public int Divider { get; set; }
        }
    }
}
