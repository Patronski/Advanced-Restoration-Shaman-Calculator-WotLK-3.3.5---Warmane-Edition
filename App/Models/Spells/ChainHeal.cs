using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class ChainHeal : Spell
    {
        public ChainHeal() : base()
        {
            Name = Constants.SpellChainHeal;
            RanksCount = 7;

            this.Modifiers.Add(new RevitalizingSkyflareDiamond());
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
            this.Modifiers.Add(new FourPiecesT7Bonus());
            this.Modifiers.Add(new SteamcallersTotemBonus());
            this.Modifiers.Add(new FourPiecesT8Bonus());
            this.Modifiers.Add(new FourPiecesT9Bonus());
            this.Modifiers.Add(new FourPiecesT10Bonus());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            var isSteamcallerTotem = Modifiers
                .Any(x => x.Display == Constants.ModSteamcallersTotem && x.IsCheckBoxChecked);

            int a = isSteamcallerTotem ? 243 : 0;

            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1055 + a) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            var isSteamcallerTotem = Modifiers
                .Any(x => x.Display == Constants.ModSteamcallersTotem && x.IsCheckBoxChecked);

            int a = isSteamcallerTotem ? 243 : 0;

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
                .Any(x => x.Display == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }
        public override int? CalculateAverageHOT2()
        {
            var hot = (int)(Player.Instance.Crit2Avg * 0.25 / 3);
            var is4PiecesEquiped = Modifiers
                .Any(x => x.Display == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }
        public override int? CalculateAverageHOT3()
        {
            var hot = (int)(Player.Instance.Crit3Avg * 0.25 / 3);
            var is4PiecesEquiped = Modifiers
                .Any(x => x.Display == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }
        public override int? CalculateAverageHOT4()
        {
            var hot = (int)(Player.Instance.Crit4Avg * 0.25 / 3);

            var is4PiecesEquiped = Modifiers
                .Any(x => x.Display == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);

            if (!is4PiecesEquiped) hot = 0;

            return hot;
        }

        public override double? CalculateCastingTime()
        {
            var is4PT8 = Modifiers.Any(x => x.Display == Constants.Mod4PT8Bonus && x.IsCheckBoxChecked);

            double baseCastingTime = is4PT8 ? 2.3 : 2.5;

            var castingTime = baseCastingTime / (1 + Player.Instance.HastePercent / 100);
            castingTime = Math.Truncate(castingTime * 1000) / 1000;

            return castingTime;
        }

        public override int? CalculateAverageHPS()
        {
            var is4PT8 = Modifiers.Any(x => x.Display == Constants.Mod4PT8Bonus && x.IsCheckBoxChecked);

            double hasteBorder = is4PT8 ? 130 : 150;
            double coefficientHaste = is4PT8 ? 0.435 : 0.4;

            var hastePercent = (Player.Instance.HastePercent > hasteBorder) ? hasteBorder : Player.Instance.HastePercent;

            var formula = (((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier)
                + (1 - Player.Instance.CriticalPercent / 100 ) )
                * Player.Instance.Hit1Avg * coefficientHaste * (1 + hastePercent / 100));

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            var result = (int)(formula + formula * 0.6 + formula * 0.36 + formula * 0.216);

            if (!isGlyphOfChainHeal)
            {
                result = (int)(formula + formula * 0.6 + formula * 0.36);
            }

            return result;
        }

        public override int? CalculateAverageHotHPS()
        {
            var hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;

            var formula = Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier * Player.Instance.Hit1Avg * 0.01111 * (1 + hastePercent / 100);

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            var result = (int)(formula + formula * 0.6 + formula * 0.36 + formula * 0.216);

            if (!isGlyphOfChainHeal)
            {
                result = (int)(formula + formula * 0.6 + formula * 0.36);
            }

            var is4PT10Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod4PT10Bonus && x.IsCheckBoxChecked);
            
            if (!is4PT10Equiped) result = 0;

            return result;
        }

        public override void CalculateOnModifierChange(string modName, bool isChecked)
        {
            if (modName == Constants.Mod4PT7Bonus)
            {
                if (Forms.Instance.FormCalculator.checkBox4PT8Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox4PT9Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox2PT10Bonus.Checked)
                {
                    Forms.Instance.FormCalculator.skipEventChanged = true;
                }

                Forms.Instance.FormCalculator.checkBox4PT8Bonus.Checked = false;
                var modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT8Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox4PT9Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT9Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox2PT10Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod2PT10Bonus_RapidCurrents);
                modifier.IsCheckBoxChecked = false;
            }
            else if (modName == Constants.Mod4PT8Bonus)
            {
                if (Forms.Instance.FormCalculator.checkBox4PT7Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox4PT9Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox2PT10Bonus.Checked)
                {
                    Forms.Instance.FormCalculator.skipEventChanged = true;
                }

                Forms.Instance.FormCalculator.checkBox4PT7Bonus.Checked = false;
                var modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT7Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox4PT9Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT9Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox2PT10Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod2PT10Bonus_RapidCurrents);
                modifier.IsCheckBoxChecked = false;
            }
            else if (modName == Constants.Mod4PT9Bonus)
            {
                if (Forms.Instance.FormCalculator.checkBox4PT7Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox4PT8Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox2PT10Bonus.Checked)
                {
                    Forms.Instance.FormCalculator.skipEventChanged = true;
                }

                Forms.Instance.FormCalculator.checkBox4PT7Bonus.Checked = false;
                var modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT7Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox4PT8Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT8Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox2PT10Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod2PT10Bonus_RapidCurrents);
                modifier.IsCheckBoxChecked = false;
            }
            else if (modName == Constants.Mod2PT10Bonus_RapidCurrents)
            {
                if (Forms.Instance.FormCalculator.checkBox4PT7Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox4PT8Bonus.Checked ||
                    Forms.Instance.FormCalculator.checkBox4PT9Bonus.Checked)
                {
                    Forms.Instance.FormCalculator.skipEventChanged = true;
                }

                Forms.Instance.FormCalculator.checkBox4PT7Bonus.Checked = false;
                var modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT7Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox4PT8Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT8Bonus);
                modifier.IsCheckBoxChecked = false;

                Forms.Instance.FormCalculator.checkBox4PT9Bonus.Checked = false;
                modifier = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod4PT9Bonus);
                modifier.IsCheckBoxChecked = false;
            }

            base.CalculateOnModifierChange(modName, isChecked);
        }

        public override int? CalculateAvgHpm()
        {
            var isGlyphOfChainHeal = Modifiers
                .Any(x => (x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked));

            var avgHit = Player.Instance.Hit1Avg + Player.Instance.Hit2Avg + Player.Instance.Hit3Avg;
            var multiplier = isGlyphOfChainHeal ? 5.904 : 4.428;
            if (isGlyphOfChainHeal)
            {
                avgHit += Player.Instance.Hit4Avg;
            }

            //* [Crtit% / 100 * 1.5 + (1 - Crit% / 100)]} / [793 - (Crit% * 5.904)]
            var result = (avgHit * (Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier +
                (1 - Player.Instance.CriticalPercent / 100))) 
                /
                (793 - Player.Instance.CriticalPercent * multiplier);
            
            return (int)Math.Round(result ?? 0);
        }
    }
}
