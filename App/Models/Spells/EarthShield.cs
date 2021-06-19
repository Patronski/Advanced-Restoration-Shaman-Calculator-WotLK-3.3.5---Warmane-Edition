using App.Models.Modifiers;
using System;
using System.Linq;

namespace App.Models.Spells
{
    public class EarthShield : Spell
    {
        public EarthShield() : base()
        {
            Name = Constants.SpellESh;
            RanksCount = 5;

            this.Modifiers.Add(new MetaRevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new GlyphOfEarthShield());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new Berserking());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new BloodlustHeroism());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)Math.Round(4.304 * Player.Instance.SpellPower) + 2696;

            rounded = (int)Math.Round(rounded / 8d);

            rounded = (int)Math.Round(rounded * 1.25);

            rounded = (int)Math.Round(rounded * 1.1);

            return rounded;
        }

        public override int? CalculateAverageHPS()
        {
            var hps = ((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier) +
                (1 - Player.Instance.CriticalPercent / 100)) * Player.Instance.Hit1From;

            hps = hps / 3.83;

            return (int?)hps;
        }

        public override double CalculateAvgHpm()
        {
            // ES TICK * [Crtit% / 100 * 1.5 + (1 - Crit% / 100)] * 8 / 626[/color]
            var result = Player.Instance.Hit1From *
                (Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier +
                (1 - Player.Instance.CriticalPercent / 100))
                *
                8 / 626;
            return Math.Round(result ?? 0, 1);
        }
    }
}