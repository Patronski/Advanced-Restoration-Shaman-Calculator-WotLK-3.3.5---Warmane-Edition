using App.Models.Modifiers;
using App.Models.Modifiers.Interfaces;
using System;
using System.Linq;

namespace App.Models.Spells
{
    public class HealingWave : Spell
    {
        public HealingWave() : base()
        {
            Name = Constants.SpellHW;
            RanksCount = 14;

            this.Modifiers.Add(new GlyphOfHealingWave());
            this.Modifiers.Add(new MetaRevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new RapidCurrents());
            this.Modifiers.Add(new TidalWavesHaste());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new TwoPiecesT7Bonus());
            this.Modifiers.Add(new FourPiecesT7Bonus());
            this.Modifiers.Add(new TotemOfMisery());
            this.Modifiers.Add(new Berserking());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)(1.811 * Player.Instance.SpellPower) + 3034;

            rounded = (int)(rounded * 1.375);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            int rounded = (int)(1.811 * Player.Instance.SpellPower) + 3466;

            rounded = (int)(rounded * 1.375);

            return rounded;
        }

        public override double? CalculateCastingTime()
        {
            var castingTime = (decimal)(2.5 / (1 + Player.Instance.HastePercent / 100));
            //castingTime = Math.Round(castingTime, 3, MidpointRounding.ToEven);
            castingTime = Math.Truncate(castingTime * 1000) / 1000;

            return (double)castingTime;
        }

        public override int? CalculateAverageHPS()
        {
            var isTidalWaves = Modifiers
                .Any(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);

            double hastePercent;
            double multiplier;
            if (isTidalWaves)
            {
                hastePercent = (Player.Instance.HastePercent > 75) ? 75d : Player.Instance.HastePercent;
                multiplier = 0.57143;
            }
            else
            {
                hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;
                multiplier = 0.4;
            }

            var avgHps = ((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier) +
                (1 - Player.Instance.CriticalPercent / 100)) * Player.Instance.Hit1Avg * (1 + hastePercent / 100) * multiplier;

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var isTidalWaves = Modifiers
                .Any(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);

            double hastePercent;
            double multiplier;
            if (isTidalWaves)
            {
                hastePercent = (Player.Instance.HastePercent > 75) ? 75d : Player.Instance.HastePercent;
                multiplier = 0.57143;
            }
            else
            {
                hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;
                multiplier = 0.4;
            }

            var avgHps = (Player.Instance.CriticalPercent / 100 * Player.Instance.AncestralAwaceningAvg) *
                 (1 + hastePercent / 100) * multiplier;

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

        public override int? CalculateAvgGlyphOfHealingWave()
        {
            var isGlyphOfHealingWave = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfHealingWave && x.IsCheckBoxChecked);
            if (!isGlyphOfHealingWave) return 0;

            var result = CalculateAverageHPS() * 0.2;

            return (int?)result;
        }

        public override double CalculateAvgHpm()
        {
            var isGlyphHealingWave = Modifiers.FirstOrDefault(x => x.Display == Constants.ModGlyphOfHealingWave).IsCheckBoxChecked;

            var mod2Pt7 = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod2PT7Bonus).IsCheckBoxChecked;
            var multiplier = mod2Pt7 ? 5.35 : 4.92;

            var isTotemOfMisery = Modifiers.Any(x => x.Display == Constants.ModTotemOfMisery && x.IsCheckBoxChecked);
            var totemModifier = isTotemOfMisery ? 969 : 1044;

            // HPM = HW HIT * [Crtit% / 100 * 1.5 + (1 - Crit% / 100)] / [1044 - (Crit% * 4.92)]
            var result = (Player.Instance.Hit1Avg * (Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier +
                (1 - Player.Instance.CriticalPercent / 100)));
            ///
            //(totemModifier /*- Player.Instance.CriticalPercent * multiplier*/);
            if (isGlyphHealingWave)
            {
                result += result * 0.2;
            }
            result += Player.Instance.AncestralAwaceningAvg * Player.Instance.CriticalPercent / 100;
            result /= totemModifier;

            return Math.Round(result ?? 0, 1);
        }
    }
}