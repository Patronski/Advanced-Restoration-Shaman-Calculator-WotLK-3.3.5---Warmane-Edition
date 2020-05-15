using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Spells
{
    public class Riptide : Spell
    {
        public Riptide() : base()
        {
            Name = "Riptide";
            RanksCount = 4;
        }

        public Riptide(int spellPower) : base(spellPower) { }

        public override int CalculateAstralAwakening(int rankNum, Rank rank)
        {
            throw new NotImplementedException();
        }

        public override int CalculateHot(int rankNum, Rank rank)
        {
            throw new NotImplementedException();
        }

        public override int CalculateRank(int rankNum, Rank rank)
        {
            throw new NotImplementedException();
        }
    }
}
