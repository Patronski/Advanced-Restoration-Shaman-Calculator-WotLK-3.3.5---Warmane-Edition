using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models
{
    public abstract class Spell
    {
        public Spell()
        {
            this.Modifiers = new List<Modifier>();
            this.CriticalMultiplier = 1;
        }

        public string Name { get; protected set; }

        public List<Modifier> Modifiers { get; set; }

        public double CriticalMultiplier { get; set; }

        public int RanksCount { get; set; }

        public abstract int CalculateHitFrom();

        public abstract int? CalculateHitTo();

        public abstract int CalculateAstralAwakening();

        public override string ToString()
        {
            return $"{this.Name} (Rank {this.RanksCount})";
        }

        public abstract void LoadModifiers(FlowLayoutPanel parentPanel);
    }
}
