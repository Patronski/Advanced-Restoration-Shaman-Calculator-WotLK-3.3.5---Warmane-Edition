using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class LesserHealingWave : Spell
    {
        public LesserHealingWave() : base()
        {
            Name = "Lesser Healing Wave";
            RanksCount = 9;
        }

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHit()
        {
            throw new NotImplementedException();
        }

        public override int CalculateRank()
        {
            throw new NotImplementedException();
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            throw new NotImplementedException();
        }
    }
}
