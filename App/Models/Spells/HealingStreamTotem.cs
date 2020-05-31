using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class HealingStreamTotem : Spell
    {
        public HealingStreamTotem() : base()
        {
            Name = Constants.SpellHST;

            RanksCount = 9;

            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new GlyphOfHealingStreamTotem());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)(12.408 * Player.Instance.SpellPower) + 3750;

            rounded = rounded / 150;

            return rounded;
        }

        public override int? CalculateAverageHPS()
        {
            var hps = Player.Instance.Hit1From / 13.2;

            return (int?)hps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var hps = Player.Instance.Hit1From / 2;

            return (int?)hps;
        }
    }
}
