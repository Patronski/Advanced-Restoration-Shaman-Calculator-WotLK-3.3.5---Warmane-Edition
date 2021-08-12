using App.Models.Modifiers;
using App.Models.Modifiers.Interfaces;
using System;
using System.Linq;

namespace App.Models.Spells
{
    public class LesserHealingWave : Spell
    {
        public LesserHealingWave() : base()
        {
            Name = Constants.SpellLHW;
            RanksCount = 9;

            this.Modifiers.Add(new MetaRevitalizingSkyflareDiamond());
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
            this.Modifiers.Add(new TwoPiecesT7Bonus());
            this.Modifiers.Add(new Berserking());
            this.Modifiers.Add(new GlyphOfEarthliving());
            this.Modifiers.Add(new FocusMagic());
            this.Modifiers.Add(new TalentsCriticalDepression());

            modifierNames = this.Modifiers.Select(x => x.Name).ToList();
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

            var avgHps = ((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier) +
                (1 - Player.Instance.CriticalPercent / 100)) * Player.Instance.Hit1Avg * (1 + hastePercent / 100) * 0.6667; //god bless

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            double hastePercent = (Player.Instance.HastePercent > 50) ? 50d : Player.Instance.HastePercent;

            var avgHps = Player.Instance.CriticalPercent / 100 * Player.Instance.AncestralAwaceningAvg *
                (1 + hastePercent / 100) * 0.6667;

            return (int?)avgHps; ;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Crit1From * 0.297;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IHealingModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Crit1To * 0.297;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IHealingModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningAvg()
        {
            return (Player.Instance.AncestralAwaceningFrom + Player.Instance.AncestralAwaceningTo) / 2;
        }

        public override double CalculateAvgHpm()
        {
            var mod2Pt7 = Modifiers.FirstOrDefault(x => x.Name == Constants.Mod2PT7Bonus).IsCheckBoxChecked;

            var result = (Player.Instance.Hit1Avg * (Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier +
                (1 - Player.Instance.CriticalPercent / 100)));

            result += Player.Instance.EarthlivingAvgHpsLHW;

            result += Player.Instance.AncestralAwaceningAvg * Player.Instance.CriticalPercent / 100;

            result /= 626;
            return Math.Round(result ?? 0, 1);
        }

        public override int? CalculateEarthlivingAvgHpsLHW()
        {
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Name == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double multiplier = isGlyphOfEarthliving ? 0.25 : 0.2;

            var result = Player.Instance.EarthlivingTick * multiplier * 4;

            return (int?)result;
        }

        public override int CalculateEarthlivingEHPS()
        {
            double hasteBorder = 50;
            double coefficientHaste = 0.6667;

            var hastePercent = (Player.Instance.HastePercent > hasteBorder) ? hasteBorder : Player.Instance.HastePercent;

            var formula = Player.Instance.EarthlivingAvgHpsLHW * (1 + hastePercent / 100) * coefficientHaste;

            return (int)formula;
        }
    }
}