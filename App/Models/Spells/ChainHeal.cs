using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Spells
{
    public class ChainHeal : Spell
    {
        public ChainHeal() : base()
        {
            Name = "Chain Heal";
            RanksCount = 7;
        }

        public ChainHeal(int spellPower) : base(spellPower) { }

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
