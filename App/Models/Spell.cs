using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public abstract class Spell
    {
        public Spell()
        {
            this.Ranks = new List<Rank>();
            this.Multipliers = new List<Multiplier>();
            this.CriticalMultiplier = 1;
        }

        public Spell(int spellPower) : this()
        {
            this.PlayerSpellPower = spellPower;
        }

        public string Name { get; protected set; }

        public List<Multiplier> Multipliers { get; set; }

        public double CriticalMultiplier { get; set; }

        public int RanksCount { get; set; }

        public int PlayerSpellPower { get; set; }

        public List<Rank> Ranks { get; set; }

        public bool IsDamageVarying { get; set; }

        public abstract int CalculateRank(int rankNum, Rank rank);

        public abstract int CalculateHot(int rankNum, Rank rank); // HealingOverTime

        public abstract int CalculateAstralAwakening(int rankNum, Rank rank);

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
