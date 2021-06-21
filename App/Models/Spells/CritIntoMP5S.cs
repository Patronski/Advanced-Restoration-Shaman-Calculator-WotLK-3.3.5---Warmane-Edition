using App.Models.Modifiers;
using System;
using System.Linq;

namespace App.Models.Spells
{
    public class CritIntoMP5S : Spell
    {
        public CritIntoMP5S() : base()
        {
            Name = Constants.SpellCritIntoMP5S;

            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new TwoPiecesT7Bonus());
            this.Modifiers.Add(new GlyphOfManaTideTotem());
            this.Modifiers.Add(new MetaInsightfulEarthsiegeDiamond());
            this.Modifiers.Add(new Berserking());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new TotemOfForestGrowth());
            this.Modifiers.Add(new TotemOfMisery());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            return 222;
        }

        public override double CalculateMp5TotalDec()
        {
            var r = Player.Instance.Mp5TimeMin + (Player.Instance.Mp5TimeSec / 60d);
            return Math.Round(r, 2); ;
        }

        public override double? CalculateMp5RPM()
        {
            if (Player.Instance.Mp5TimeDec == 0)
            {
                return null;
            }

            var x = Player.Instance.Mp5TotalRiptides / (double)Player.Instance.Mp5TimeDec;

            return Math.Round(x, 2);
        }

        public override double? CalculateMp5HWPM()
        {
            if (Player.Instance.Mp5TimeDec == 0)
            {
                return null;
            }
            var r = (Player.Instance.Mp5TotalHW) / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(r, 2);
        }

        public override double? CalculateMp5LHWPM()
        {
            if (Player.Instance.Mp5TimeDec == 0)
            {
                return null;
            }
            var r = (Player.Instance.Mp5TotalLHW) / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(r, 2);
        }

        public override double? CalculateMp5CHPM()
        {
            if (Player.Instance.Mp5TimeDec == 0)
            {
                return null;
            }
            var r = (Player.Instance.Mp5TotalCH) / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(r, 2);
        }

        public override double? CalculateMp5Crit()
        {
            var mod2Pt7 = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod2PT7Bonus).IsCheckBoxChecked;
            var multiplier = mod2Pt7 ? 5.35 : 4.92;

            //RPM * 0.00971 + HWPM * 0.00971 + LHWPM * 0.005826 + CHPM * 0.002913
            if (mod2Pt7)
            {
                var rezult = (Player.Instance.Mp5RPM ?? 0) * 0.00971 +
                (Player.Instance.Mp5HWPM ?? 0) * 0.00971 +
                (Player.Instance.Mp5LHWPM ?? 0) * 0.005826 +
                (Player.Instance.Mp5CHPM ?? 0) * 0.002913;
                return Math.Round(rezult, 4);
            }

            //RPM * 0.00893 + HWPM * 0.00893 + LHWPM * 0.005358 + CHPM * 0.00268
            var r = (Player.Instance.Mp5RPM ?? 0) * 0.00893 +
                (Player.Instance.Mp5HWPM ?? 0) * 0.00893 +
                (Player.Instance.Mp5LHWPM ?? 0) * 0.005358 +
                (Player.Instance.Mp5CHPM ?? 0) * 0.00268;
            return Math.Round(r, 4);
        }

        public override double? CalculateMp5Percent()
        {
            var r = (Player.Instance.Mp5Crit ?? 0) * 200;
            return Math.Round(r, 2);
        }

        public override double CalculateMp5TotalCrit()
        {
            var r = Player.Instance.CriticalPercent * 45.91 * (Player.Instance.Mp5Crit ?? 0);
            return Math.Round(r);
        }

        public override double CalculateMp5Totems()
        {
            var isGlyphOfManaTideTotem = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfManaTideTotem && x.IsCheckBoxChecked);

            var rezult = Player.Instance.Mana * (isGlyphOfManaTideTotem ? 0.28d : 0.24d) * Player.Instance.Mp5TotemsCount;
            return Math.Round(rezult);
        }

        public override double CalculateMp5Innervates()
        {
            return Player.Instance.Mp5InnervatesCount * 7866;
        }

        public override double CalculateMp5Replenish()
        {
            var result = Player.Instance.Mana / 100d * Player.Instance.Mp5ReplenishCount / 100;
            return Math.Round(result, 2);
        }

        public override double CalculateMp5Diamond()
        {
            var isInsightfulDiamond = Modifiers
                .Any(x => x.Display == Constants.ModMetaInsightfulEarthsiegeDiamond && x.IsCheckBoxChecked);
            if (!isInsightfulDiamond)
            {
                return 0;
            }

            var totalSomething = Player.Instance.Mp5TotalHW + Player.Instance.Mp5TotalLHW + Player.Instance.Mp5TotalRiptides + Player.Instance.Mp5TotalCHCasts;
            var result = totalSomething * 0.05 * 600;
            return result;
        }

        public override int CalculateMp5TotalManaGain()
        {
            var a = (Player.Instance.Mp5TimeMin * 60 + Player.Instance.Mp5TimeSec) *
                (Player.Instance.MP5S + Player.Instance.Mp5Replenish + Player.Instance.Mp5TotalCrit);
            a /= 5;
            a += Player.Instance.Mp5Totems + Player.Instance.Mp5Innervates + Player.Instance.Mp5Diamond;
            a += Player.Instance.Mp5TotemicRecall * (0.25d * Player.Instance.Mp5SelectedTotemTotalMana);
            a += Player.Instance.Mp5RevitalizeMana;
            a += Player.Instance.Mp5RaptureMana;

            return (int)Math.Round(a);
        }

        public override int CalculateMp5TotalManaSpent()
        {
            var isTotemOfMisery = Modifiers
                .Any(x => x.Display == Constants.ModTotemOfMisery && x.IsCheckBoxChecked);
            var isTotemOfForest = Modifiers
                .Any(x => x.Display == Constants.ModTotemOfForestGrowth && x.IsCheckBoxChecked);

            var result = Player.Instance.Mp5TotalRiptides * 751 +
                Player.Instance.Mp5TotalHW * (isTotemOfMisery ? 969 : 1044) +
                Player.Instance.Mp5TotalLHW * 626 +
                Player.Instance.Mp5TotalCHCasts * (isTotemOfForest ? 719 : 793) +
                Player.Instance.Mp5TotalESHCasts * 626 +
                Player.Instance.Mp5BloodlustHeroism * 1142 +
                Player.Instance.Mp5SelectedTotemTotalMana * Player.Instance.Mp5CallOfElements;

            return result;
        }

        public override int CalculateMp5RevitalizeMana()
        {
            return (int)(0.0015 * Player.Instance.Mana * Player.Instance.Mp5RevitalizeTicks);
        }

        public override int CalculateMp5RaptureMana()
        {
            return (int)(Player.Instance.Mp5RaptureProcs * Player.Instance.Mana * 0.02);
        }

        public override int CalculateMp5ManaDifference()
        {
            return Player.Instance.Mana + (Player.Instance.Mp5TotalManaGain - Player.Instance.Mp5TotalManaSpent);
        }

        public override void Calculate()
        {
            Player.Instance.Recalculate();

            ModifyWithModifiers();

            var modifier = Modifiers
                .FirstOrDefault(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);
            if (modifier != null)
            {
                modifier.Modify();
            }

            Player.Instance.Mp5TimeDec = CalculateMp5TotalDec();
            Player.Instance.Mp5RPM = CalculateMp5RPM();
            Player.Instance.Mp5HWPM = CalculateMp5HWPM();
            Player.Instance.Mp5LHWPM = CalculateMp5LHWPM();
            Player.Instance.Mp5CHPM = CalculateMp5CHPM();
            Player.Instance.Mp5Crit = CalculateMp5Crit();
            Player.Instance.Mp5Percent = CalculateMp5Percent();
            Player.Instance.Mp5TotalCrit = CalculateMp5TotalCrit();
            Player.Instance.Mp5Totems = CalculateMp5Totems();
            Player.Instance.Mp5Innervates = CalculateMp5Innervates();
            Player.Instance.Mp5Replenish = CalculateMp5Replenish();
            Player.Instance.Mp5Diamond = CalculateMp5Diamond();
            Player.Instance.Mp5RevitalizeMana = CalculateMp5RevitalizeMana();
            Player.Instance.Mp5RaptureMana = CalculateMp5RaptureMana();
            Player.Instance.Mp5TotalManaGain = CalculateMp5TotalManaGain();
            Player.Instance.Mp5TotalManaSpent = CalculateMp5TotalManaSpent();
            Player.Instance.Mp5ManaDifference = CalculateMp5ManaDifference();
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}