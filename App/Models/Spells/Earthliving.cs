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

            this.Modifiers.Add(new GlyphOfChainHeal());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new GlyphOfEarthliving());
            this.Modifiers.Add(new MoonkinForm());
            //this.Modifiers.Add(new WrathOfTheAirTotem());
            //this.Modifiers.Add(new SwiftRetribution());
            //this.Modifiers.Add(new BloodlustHeroism());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)((int)(0.1692 * Player.Instance.SpellPower + 163) * 1.1);

            return rounded;
        }

        public override int? CalculateEarthlivingAvgHpsCH()
        {
            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double a = isGlyphOfChainHeal ? 4 : 3;
            double b = isGlyphOfEarthliving ? 0.25 : 0.2;
            double multiplier = a * b;

            var result = Player.Instance.Hit1From * multiplier * 4;

            return (int?)result;
        }

        public override int? CalculateEarthlivingAvgHpsHW()
        {
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double multiplier = isGlyphOfEarthliving ? 0.25 : 0.2;

            var result = Player.Instance.Hit1From * multiplier * 4;

            return (int?)result;
        }

        public override int? CalculateEarthlivingAvgHpsLHW()
        {
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double multiplier = isGlyphOfEarthliving ? 0.25 : 0.2;

            var result = Player.Instance.Hit1From * multiplier * 4;

            return (int?)result;
        }

        public override int? CalculateEarthlivingAvgHpsRP()
        {
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double multiplier = isGlyphOfEarthliving ? 0.25 : 0.2;

            var result = Player.Instance.Hit1From * multiplier * 4;

            return (int?)result;
        }

        public override int? CalculateEarthlivingAvgHpsTotal()
        {
            var result = (CalculateEarthlivingAvgHpsCH() + CalculateEarthlivingAvgHpsHW() + CalculateEarthlivingAvgHpsLHW() + CalculateEarthlivingAvgHpsRP()) / 4;
            return result;
        }
    }
}
