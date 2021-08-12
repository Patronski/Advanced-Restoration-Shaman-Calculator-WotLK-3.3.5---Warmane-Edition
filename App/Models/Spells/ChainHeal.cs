using App.Models.Modifiers;
using System;
using System.Linq;

namespace App.Models.Spells
{
    public class ChainHeal : Spell
    {
        public ChainHeal() : base()
        {
            Name = Constants.SpellChainHeal;
            RanksCount = 7;

            this.Modifiers.Add(new MetaRevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new RiptidesConsumption());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new RapidCurrents());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new GlyphOfChainHeal());
            this.Modifiers.Add(new SteamcallersTotemBonus());
            this.Modifiers.Add(new TotemOfForestGrowth());
            this.Modifiers.Add(new TotemOfTheBay());
            this.Modifiers.Add(new TwoPiecesT7Bonus());
            this.Modifiers.Add(new FourPiecesT7Bonus());
            this.Modifiers.Add(new FourPiecesT8Bonus());
            this.Modifiers.Add(new FourPiecesT9Bonus());
            this.Modifiers.Add(new FourPiecesT10Bonus());
            this.Modifiers.Add(new Berserking());
            this.Modifiers.Add(new GlyphOfEarthliving());
            this.Modifiers.Add(new FocusMagic());
            this.Modifiers.Add(new TalentsCriticalDepression());
            this.Modifiers.Add(new TwoPiecesTier6Bonus());

            modifierNames = this.Modifiers.Select(x => x.Name).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            var isSteamcallerTotem = Modifiers
                .Any(x => x.Name == Constants.ModSteamcallersTotem && x.IsCheckBoxChecked);
            var isTotemOfTheBay = Modifiers
                .Any(x => x.Name == Constants.ModTotemOfTheBay && x.IsCheckBoxChecked);

            int a = isSteamcallerTotem ? 243 : 0;
            a = isTotemOfTheBay ? 102 : a;

            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1055 + a) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            var isSteamcallerTotem = Modifiers
                .Any(x => x.Name == Constants.ModSteamcallersTotem && x.IsCheckBoxChecked);
            var isTotemOfTheBay = Modifiers
                .Any(x => x.Name == Constants.ModTotemOfTheBay && x.IsCheckBoxChecked);

            int a = isSteamcallerTotem ? 243 : 0;
            a = isTotemOfTheBay ? 102 : a;

            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1205 + a) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget2HitFrom()
        {
            return (int?)(Player.Instance.Hit1From * 0.6);
        }

        public override int? CalculateTarget2HitTo()
        {
            return (int?)(Player.Instance.Hit1To * 0.6);
        }

        public override int? CalculateTarget3HitFrom()
        {
            return (int?)(Player.Instance.Hit1From * 0.36);
        }

        public override int? CalculateTarget3HitTo()
        {
            return (int?)(Player.Instance.Hit1To * 0.36);
        }

        public override int? CalculateTarget4HitFrom()
        {
            return (int?)(Player.Instance.Hit1From * 0.216);
        }

        public override int? CalculateTarget4HitTo()
        {
            return (int?)(Player.Instance.Hit1To * 0.216);
        }

        public override int? CalculateAverageHOT1()
        {
            if (Player.Instance.Crit1Avg == null) return null;
            var hot = (int)(Player.Instance.Crit1Avg * 0.25 / 3);

            var is4PiecesEquiped = Modifiers
                .Any(x => x.Name == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }

        public override int? CalculateAverageHOT2()
        {
            var hot = (int)(Player.Instance.Crit2Avg * 0.25 / 3);
            var is4PiecesEquiped = Modifiers
                .Any(x => x.Name == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }

        public override int? CalculateAverageHOT3()
        {
            var hot = (int)(Player.Instance.Crit3Avg * 0.25 / 3);
            var is4PiecesEquiped = Modifiers
                .Any(x => x.Name == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }

        public override int? CalculateAverageHOT4()
        {
            var hot = (int)(Player.Instance.Crit4Avg * 0.25 / 3);

            var is4PiecesEquiped = Modifiers
                .Any(x => x.Name == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Name == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped || !isGlyphOfChainHeal) hot = 0;

            return hot;
        }

        public override double? CalculateCastingTime()
        {
            var is4PT8 = Modifiers.Any(x => x.Name == Constants.Mod4PT8Bonus && x.IsCheckBoxChecked);

            double baseCastingTime = is4PT8 ? 2.3 : 2.5;

            var castingTime = baseCastingTime / (1 + Player.Instance.HastePercent / 100);
            castingTime = Math.Truncate(castingTime * 1000) / 1000;

            return castingTime;
        }

        public override int? CalculateAverageHPS()
        {
            var is4PT8 = Modifiers.Any(x => x.Name == Constants.Mod4PT8Bonus && x.IsCheckBoxChecked);

            double hasteBorder = is4PT8 ? 130 : 150;
            double coefficientHaste = is4PT8 ? 0.4347826 : 0.4;

            var hastePercent = (Player.Instance.HastePercent > hasteBorder) ? hasteBorder : Player.Instance.HastePercent;

            var formula = (((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier)
                + (1 - Player.Instance.CriticalPercent / 100))
                * Player.Instance.Hit1Avg * coefficientHaste * (1 + hastePercent / 100));

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Name == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            var result = (int)(formula + formula * 0.6 + formula * 0.36 + formula * 0.216);

            if (!isGlyphOfChainHeal)
            {
                result = (int)(formula + formula * 0.6 + formula * 0.36);
            }

            return result;
        }

        public override int? CalculateAverageHotHPS()
        {
            var is4PT8 = Modifiers.Any(x => x.Name == Constants.Mod4PT8Bonus && x.IsCheckBoxChecked);

            double hasteBorder = is4PT8 ? 130 : 150;
            double coefficientHaste = is4PT8 ? 0.4347826 : 0.4;

            var hastePercent = (Player.Instance.HastePercent > hasteBorder) ? hasteBorder : Player.Instance.HastePercent;

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Name == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            var formula = (1 + hastePercent / 100) 
                * (Player.Instance.AvgHot1 + Player.Instance.AvgHot2 + Player.Instance.AvgHot3 + Player.Instance.AvgHot4) 
                * 3 * coefficientHaste
                * Player.Instance.CriticalPercent / 100;

            var is4PT10Equiped = Modifiers
                .Any(x => x.Name == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PT10Equiped) formula = 0;

            return (int)formula;
        }

        public override double CalculateAvgHpm()
        {
            var isGlyphOfChainHeal = Modifiers.Any(x => x.Name == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);
            var isTotemOfForest = Modifiers.Any(x => x.Name == Constants.ModTotemOfForestGrowth && x.IsCheckBoxChecked);
            var is2PT6 = Modifiers.Any(x => x.Name == Constants.Mod2PT6Bonus && x.IsCheckBoxChecked);

            var avgHit = Player.Instance.Hit1Avg + Player.Instance.Hit2Avg + Player.Instance.Hit3Avg;

            if (isGlyphOfChainHeal)
            {
                avgHit += Player.Instance.Hit4Avg;
            }

            var manaChainHeal = 793;
            if (isTotemOfForest && is2PT6)
            {
                manaChainHeal = 643;
            }
            else if (isTotemOfForest)
            {
                manaChainHeal = 719;
            }
            else if (is2PT6)
            {
                manaChainHeal = 709;
            }

            var result = avgHit * (Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier +
                (1 - Player.Instance.CriticalPercent / 100));

            result += Player.Instance.EarthlivingAvgHpsCH;

            result += (Player.Instance.AvgHot1 + Player.Instance.AvgHot2 + Player.Instance.AvgHot3 + Player.Instance.AvgHot4)
                * 3 * Player.Instance.CriticalPercent / 100;

            result /= manaChainHeal;

            return Math.Round(result ?? 0, 1);
        }

        public override int? CalculateEarthlivingAvgHpsCH()
        {
            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Name == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Name == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double a = isGlyphOfChainHeal ? 4 : 3;
            double b = isGlyphOfEarthliving ? 0.25 : 0.2;
            double multiplier = a * b;

            // tick * (3 * 0.2) *4
            var result = Player.Instance.EarthlivingTick * multiplier * 4;

            return (int?)result;
        }

        public override int CalculateEarthlivingEHPS()
        {
            var is4PT8 = Modifiers.Any(x => x.Name == Constants.Mod4PT8Bonus && x.IsCheckBoxChecked);

            double hasteBorder = is4PT8 ? 130 : 150;
            double coefficientHaste = is4PT8 ? 0.4347826 : 0.4;

            var hastePercent = (Player.Instance.HastePercent > hasteBorder) ? hasteBorder : Player.Instance.HastePercent;

            var formula = Player.Instance.EarthlivingAvgHpsCH * (1 + hastePercent / 100) * coefficientHaste;

            return (int)formula;
        }
    }
}