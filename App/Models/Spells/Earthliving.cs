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
            this.Modifiers.Add(new GlyphOfEarthliving());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)((int)(0.1692 * Player.Instance.SpellPower + 163) * 1.1);

            return rounded;
        }

        public override int? CalculateAverageHPS()
        {
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            if (isGlyphOfEarthliving)
            {
                return (int)(Player.Instance.Hit1From * 0.25 / 3);
            }

            return (int)(Player.Instance.Hit1From * 0.2 / 3);
        }

        public override int? CalculateAverageHotHPS()
        {
            return (int)(Player.Instance.Hit1From / 3);
        }
    }
}
