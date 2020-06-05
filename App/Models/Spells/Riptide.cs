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
    public class Riptide : Spell
    {
        public Riptide() : base()
        {
            Name = Constants.SpellRiptide;
            RanksCount = 4;

            this.Modifiers.Add(new RevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new GlyphOfRiptide());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)(0.402 * Player.Instance.SpellPower) + 1604;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            int rounded = (int)(0.402 * Player.Instance.SpellPower) + 1736;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override int? CalculateAverageHPS()
        {
            var isGlyphOfRiptide = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfRiptide && x.IsCheckBoxChecked);

            double? avgHps;

            if (isGlyphOfRiptide)
            {
                avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg + (7 * Player.Instance.HotRiptide)) / 6;
            }
            else
            {
                avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg + (5 * Player.Instance.HotRiptide)) / 6;
            }

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg + (2 * Player.Instance.HotRiptide)) / 6;

            return (int?)avgHps; ;
        }

        public override int? CalculateAverageAAHPS()
        {
            var hps = Player.Instance.CriticalChance * Player.Instance.AncestralAwaceningAvg / 600;
            return (int?)hps;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Crit1From * 0.33;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IAncestralAwakeningModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = (int)aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Crit1To * 0.33;

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

        public override int? CalculateAverageHOT1()
        {
            var round = (int)(0.18 * Player.Instance.SpellPower + 334);
            round = (int)(round * 1.1);
            return round;
        }

        public override void Calculate()
        {
            Player.Instance.Recalculate();
            Player.Instance.Hit1From = CalculateTarget1HitFrom();
            Player.Instance.Hit1To = CalculateTarget1HitTo();
            Player.Instance.CastingTime = CalculateCastingTime();
            Player.Instance.HotRiptide = CalculateAverageHOT1();

            ModifyWithModifiers();
            Player.Instance.CastingTime = CalculateCastingTime();
            var modifier = Modifiers
                .FirstOrDefault(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);
            if (modifier != null)
            {
                modifier.Modify();
            }

            Player.Instance.EarthlivingAvgHpsCH = CalculateEarthlivingAvgHpsCH();
            Player.Instance.EarthlivingAvgHpsHW = CalculateEarthlivingAvgHpsHW();
            Player.Instance.EarthlivingAvgHpsLHW = CalculateEarthlivingAvgHpsLHW();
            Player.Instance.EarthlivingAvgHpsRP = CalculateEarthlivingAvgHpsRP();
            Player.Instance.EarthlivingAvgHpsTotal = CalculateEarthlivingAvgHpsTotal();
            Player.Instance.Hit2From = CalculateTarget2HitFrom();
            Player.Instance.Hit3From = CalculateTarget3HitFrom();
            Player.Instance.Hit4From = CalculateTarget4HitFrom();
            Player.Instance.Hit2To = CalculateTarget2HitTo();
            Player.Instance.Hit3To = CalculateTarget3HitTo();
            Player.Instance.Hit4To = CalculateTarget4HitTo();
            Player.Instance.Hit1Avg = CalculateTarget1HitAvg();
            Player.Instance.Hit2Avg = CalculateTarget2HitAvg();
            Player.Instance.Hit3Avg = CalculateTarget3HitAvg();
            Player.Instance.Hit4Avg = CalculateTarget4HitAvg();
            Player.Instance.Crit1To = CalculateTarget1CritTo();
            Player.Instance.Crit2To = CalculateTarget2CritTo();
            Player.Instance.Crit3To = CalculateTarget3CritTo();
            Player.Instance.Crit4To = CalculateTarget4CritTo();
            Player.Instance.Crit1From = CalculateTarget1CritFrom();
            Player.Instance.Crit2From = CalculateTarget2CritFrom();
            Player.Instance.Crit3From = CalculateTarget3CritFrom();
            Player.Instance.Crit4From = CalculateTarget4CritFrom();
            Player.Instance.Crit1Avg = CalculateTarget1CritAvg();
            Player.Instance.Crit2Avg = CalculateTarget2CritAvg();
            Player.Instance.Crit3Avg = CalculateTarget3CritAvg();
            Player.Instance.Crit4Avg = CalculateTarget4CritAvg();
            Player.Instance.AvgHot1 = CalculateAverageHOT1();
            Player.Instance.AvgHot2 = CalculateAverageHOT2();
            Player.Instance.AvgHot3 = CalculateAverageHOT3();
            Player.Instance.AvgHot4 = CalculateAverageHOT4();
            Player.Instance.AncestralAwaceningFrom = CalculateAncestralAwakeningFrom();
            Player.Instance.AncestralAwaceningTo = CalculateAncestralAwakeningTo();
            Player.Instance.AncestralAwaceningAvg = CalculateAncestralAwakeningAvg();
            Player.Instance.AvgHps = CalculateAverageHPS();
            Player.Instance.AvgHotHps = CalculateAverageHotHPS();
            Player.Instance.AvgAAHps = CalculateAverageAAHPS();
            Player.Instance.AvgGlyphOfHealingWave = CalculateAvgGlyphOfHealingWave();

            var modChainHeal = Modifiers
                .FirstOrDefault(x => x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked == false);
            if (modChainHeal != null)
            {
                modChainHeal.Modify();
            }
        }
    }
}
