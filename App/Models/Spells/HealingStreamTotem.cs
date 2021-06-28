using App.Models.Modifiers;
using System;
using System.Linq;

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
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new Berserking());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new FocusMagic());


            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)(12.408 * Player.Instance.SpellPower) + 3750;

            rounded = rounded / 150;

            rounded = (int)(rounded * 1.1);

            rounded = (int)(rounded * 1.45);

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

        public override double CalculateAvgHpm()
        {
            var result = (Player.Instance.Hit1From ?? 0) * 150 / 131d;
            return Math.Round(result, 1);
        }
    }
}