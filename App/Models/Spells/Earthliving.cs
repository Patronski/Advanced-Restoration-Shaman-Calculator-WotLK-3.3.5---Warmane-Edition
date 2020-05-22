using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class Earthliving : Spell
    {
        public Earthliving() : base()
        {
            Name = "Earthliving";
            RanksCount = 6;
        }

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHitFrom()
        {
            throw new NotImplementedException();
        }

        public override int? CalculateHitTo()
        {
            throw new NotImplementedException();
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            throw new NotImplementedException();
        }
    }
}
