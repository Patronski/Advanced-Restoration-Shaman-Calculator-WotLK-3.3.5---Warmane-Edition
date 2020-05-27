using App.Models.Modifiers;
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
            Name = Constants.SpellEarthliving;
            RanksCount = 6;

            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int? CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)((int)(0.1692 * Player.Instance.SpellPower + 163) * 1.1);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            return null;
        }
    }
}
