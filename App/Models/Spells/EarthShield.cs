using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class EarthShield : Spell
    {
        public EarthShield() : base()
        {
            Name = Constants.SpellESh;
            RanksCount = 5;

            this.Modifiers.Add(new RevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new GlyphOfEarthShield());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)(3.223 * Player.Instance.SpellPower) + 2022;

            rounded = rounded / 6;

            rounded = (int)(rounded * 1.1);

            rounded = (int)(rounded * 1.1);

            rounded = (int)(rounded * 1.15);

            return rounded;
        }

        public override int? CalculateAverageHPS()
        {
            var hps = ((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1From;
            hps = hps / 4.28;

            return (int?)hps;
        }

        public override int? CalculateAvgHpm()
        {
            // ES TICK * [Crtit% / 100 * 1.5 + (1 - Crit% / 100)] * 8 / 626[/color]
            var result = Player.Instance.Hit1From *
                (Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue +
                (1 - Player.Instance.CriticalChance / 100))
                *
                8 / 626;
            return (int)Math.Round(result ?? 0);
        }
    }
}
