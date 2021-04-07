using App.Models.Modifiers;
using App.Models.Modifiers.Interfaces;
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
            Name = Constants.SpellLHW;
            RanksCount = 9;

            this.Modifiers.Add(new RevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new GlyphOfLesserHealingWave());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new RapidCurrents());
            this.Modifiers.Add(new TidalWavesCrit());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)(0.906 * Player.Instance.SpellPower) + 1624;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            int rounded = (int)(0.906 * Player.Instance.SpellPower) + 1852;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override double? CalculateCastingTime()
        {
            var castingTime = 1.5 / (1 + Player.Instance.HastePercent / 100);
            //castingTime = Math.Round(castingTime, 3, MidpointRounding.ToEven);
            castingTime = Math.Truncate(castingTime * 1000) / 1000;

            return castingTime;
        }

        public override int? CalculateAverageHPS()
        {
            double hastePercent = (Player.Instance.HastePercent > 50) ? 50d : Player.Instance.HastePercent;

            var avgHps = ((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg * (1 + hastePercent / 100) * 0.6667; //god bless

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {

            double hastePercent = (Player.Instance.HastePercent > 50) ? 50d : Player.Instance.HastePercent;

            var avgHps = Player.Instance.CriticalChance / 100 * Player.Instance.AncestralAwaceningAvg *
                (1 + hastePercent / 100) * 0.6667;

            return (int?)avgHps; ;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Crit1From * 0.297;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IAncestralAwakeningModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = (int)aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Crit1To * 0.297;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IAncestralAwakeningModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = (int)aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningAvg()
        {
            return (Player.Instance.AncestralAwaceningFrom + Player.Instance.AncestralAwaceningTo) / 2;
        }

        public override int? CalculateAvgHpm()
        {
            var result = (Player.Instance.Hit1Avg * (Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue +
                (1 - Player.Instance.CriticalChance / 100)))
                /
                (626 - Player.Instance.CriticalChance * 2.952);

            
            return (int)Math.Round(result ?? 0);
        }
    }
}
