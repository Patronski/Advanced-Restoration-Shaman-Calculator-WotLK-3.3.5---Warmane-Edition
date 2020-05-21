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

        public Spell(int spellPower) : this()
        {
            this.PlayerSpellPower = spellPower;
        }

        public string Name { get; protected set; }

        public List<Modifier> Modifiers { get; set; }

        public double CriticalMultiplier { get; set; }

        public int RanksCount { get; set; }

        public int PlayerSpellPower { get; set; }

        public Rank CurrentRank { get; set; }

        public bool IsDamageVarying { get; set; }

        public abstract int CalculateRank(int rankNum, Rank rank);

        public abstract int CalculateHot(int rankNum, Rank rank); // HealingOverTime

        public abstract int CalculateAstralAwakening(int rankNum, Rank rank);

        public override string ToString()
        {
            return $"{this.Name} (Rank {this.RanksCount})";
        }

        public abstract void LoadModifiers(FlowLayoutPanel parentPanel);
    }
}
