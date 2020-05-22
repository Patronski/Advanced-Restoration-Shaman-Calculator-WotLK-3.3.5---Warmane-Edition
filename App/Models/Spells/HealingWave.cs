using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class HealingWave : Spell
    {
        public HealingWave() : base()
        {
            Name = "Healing Wave";
            RanksCount = 14;
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
            throw new NotImplementedException();
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            throw new NotImplementedException();
        }
    }
}
