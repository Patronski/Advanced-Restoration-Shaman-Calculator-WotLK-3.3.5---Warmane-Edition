using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Spells
{
    public class Healing_Stream_Totem : Spell
    {
        public Healing_Stream_Totem(int spellPower) 
            : base(spellPower)
        {
            RanksCount = 9;

            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 900, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 1200, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 1500, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 1800, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 2100, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 2700, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 3000, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 3450, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 3750, Divider = 150 });
        }

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
            int rounded = (int)(rank.Num1 * PlayerSpellPower) + rank.NumFrom;

            return rounded / rank.Divider;
        }

        public override string ToString()
        {
            return $"{base.ToString()}(Rank 1 - {RanksCount})";
        }
    }
}
