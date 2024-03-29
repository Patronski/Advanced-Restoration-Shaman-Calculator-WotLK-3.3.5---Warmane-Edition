﻿using App.Models.Modifiers.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App.Models
{
    public abstract class Spell
    {
        public Spell()
        {
            this.Modifiers = new List<Modifier>();
        }

        protected List<string> modifierNames;

        public List<Modifier> Modifiers { get; set; }

        public string Name { get; protected set; }
        public int RanksCount { get; set; }

        public abstract int CalculateTarget1HitFrom();

        public virtual int? CalculateTarget1HitTo() => null;

        public virtual int? CalculateTarget1HitAvg() => (Player.Instance.Hit1From + Player.Instance.Hit1To) / 2;

        public virtual int? CalculateTarget1CritFrom() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit1From * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget1CritTo() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit1To * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget1CritAvg() => (Player.Instance.Crit1From + Player.Instance.Crit1To) / 2;

        public virtual int? CalculateTarget1AvgHot() => null;

        public virtual int? CalculateTarget2HitFrom() => null;

        public virtual int? CalculateTarget2HitTo() => null;

        public virtual int? CalculateTarget2HitAvg() => (Player.Instance.Hit2From + Player.Instance.Hit2To) / 2;

        public virtual int? CalculateTarget2CritFrom() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit2From * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget2CritTo() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit2To * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget2CritAvg() => (Player.Instance.Crit2From + Player.Instance.Crit2To) / 2;

        public virtual int? CalculateTarget2AvgHot() => null;

        public virtual int? CalculateTarget3HitFrom() => null;

        public virtual int? CalculateTarget3HitTo() => null;

        public virtual int? CalculateTarget3HitAvg() => (Player.Instance.Hit3From + Player.Instance.Hit3To) / 2;

        public virtual int? CalculateTarget3CritFrom() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit3From * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget3CritTo() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit3To * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget3CritAvg() => (Player.Instance.Crit3From + Player.Instance.Crit3To) / 2;

        public virtual int? CalculateTarget3AvgHot() => null;

        public virtual int? CalculateTarget4HitFrom() => null;

        public virtual int? CalculateTarget4HitTo() => null;

        public virtual int? CalculateTarget4HitAvg() => (Player.Instance.Hit4From + Player.Instance.Hit4To) / 2;

        public virtual int? CalculateTarget4CritFrom() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit4From * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget4CritTo() => Player.Instance.CriticalPercent == 0 ? 0 : (int?)(Player.Instance.Hit4To * Player.Instance.CriticalMultiplier);

        public virtual int? CalculateTarget4CritAvg() => (Player.Instance.Crit4From + Player.Instance.Crit4To) / 2;

        public virtual int? CalculateTarget4AvgHot() => null;

        public virtual int? CalculateAverageHOT1() => null;

        public virtual int? CalculateAverageHOT2() => null;

        public virtual int? CalculateAverageHOT3() => null;

        public virtual int? CalculateAverageHOT4() => null;

        public virtual int? CalculateAncestralAwakeningFrom() { return null; }
        public virtual int? CalculateAncestralAwakeningTo() { return null; }
        public virtual int? CalculateAncestralAwakeningAvg() { return null; }

        public virtual int? CalculateAverageHPS() { return null; }
        public virtual int? CalculateAverageHotHPS() { return null; }
        public virtual int? CalculateAverageAAHPS() { return null; }

        public virtual double? CalculateCastingTime() { return null; }

        public virtual int? CalculateAvgGlyphOfHealingWave() { return null; }

        public virtual int? CalculateEarthlivingAvgHpsCH() { return null; }
        public virtual int? CalculateEarthlivingAvgHpsHW() { return null; }
        public virtual int? CalculateEarthlivingAvgHpsLHW() { return null; }
        public virtual int? CalculateEarthlivingAvgHpsRP() { return null; }

        public virtual double CalculateMp5TotalDec() { return 0; }
        public virtual double? CalculateMp5RPM() { return null; }
        public virtual double? CalculateMp5HWPM() { return null; }
        public virtual double? CalculateMp5LHWPM() { return null; }
        public virtual double? CalculateMp5CHPM() { return null; }
        public virtual double? CalculateMp5Crit() { return null; }
        public virtual double? CalculateMp5Percent() { return null; }
        public virtual double CalculateMp5TotalCrit() { return 0; }
        public virtual double CalculateMp5Totems() { return 0; }
        public virtual double CalculateMp5Innervates() { return 0; }
        public virtual double CalculateMp5Replenish() { return 0; }
        public virtual double CalculateMp5Diamond() { return 0; }
        public virtual int CalculateMp5TotalManaGain() { return 0; }
        public virtual int CalculateMp5TotalManaSpent() { return 0; }
        public virtual int CalculateMp5RevitalizeMana() { return 0; }
        public virtual int CalculateMp5RaptureMana() { return 0; }
        public virtual int CalculateMp5ManaDifference() { return 0; }
        public virtual int CalculateEarthlivingEHPS() { return 0; }

        public virtual int CalculateEarthlivingTick() 
            => (int)((int)(0.1692 * Player.Instance.SpellPower + 163) * 1.1);

        public virtual void CalculateOnCritChanceInsert(double newCritValue)
        {
            var critModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(ICriticalModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            double sumOfModifierValues = 0;
            foreach (var item in critModifiers)
            {
                sumOfModifierValues += item.Value;
            }
            Player.Instance.CriticalPercent = newCritValue - sumOfModifierValues;
        }

        public virtual void Calculate()
        {
            Player.Instance.Recalculate();
            Player.Instance.Hit1From = CalculateTarget1HitFrom();
            Player.Instance.Hit1To = CalculateTarget1HitTo();
            Player.Instance.CastingTime = CalculateCastingTime();
            Player.Instance.HotRiptide = CalculateAverageHOT1();
            Player.Instance.EarthlivingTick = CalculateEarthlivingTick();

            ModifyWithModifiers();

            Player.Instance.CastingTime = CalculateCastingTime();

            Modifiers.FirstOrDefault(x => x.Name == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked)?.Modify();

            Player.Instance.EarthlivingAvgHpsCH = CalculateEarthlivingAvgHpsCH();
            Player.Instance.EarthlivingAvgHpsHW = CalculateEarthlivingAvgHpsHW();
            Player.Instance.EarthlivingAvgHpsLHW = CalculateEarthlivingAvgHpsLHW();
            Player.Instance.EarthlivingAvgHpsRP = CalculateEarthlivingAvgHpsRP();
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
            Player.Instance.AvgHpm = CalculateAvgHpm();
            Player.Instance.AvgHpmOneTarget = CalculateAvgHpmOneTarget();
            Player.Instance.EarthlivingEHPS = CalculateEarthlivingEHPS();

            Modifiers
                .FirstOrDefault(x => x.Name == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked == false)
                ?.Modify();
        }

        public virtual double CalculateAvgHpm() { return 0; }
        public virtual double CalculateAvgHpmOneTarget() { return 0; }

        protected void ModifyWithModifiers()
        {
            foreach (var modifier in Modifiers)
            {
                if (modifier.IsCheckBoxChecked && modifier.Name != Constants.ModTidalWavesHaste)
                {
                    modifier.Modify();
                }
            }
        }

        public void CheckModifiers(List<string> checkedModifierNames)
        {
            foreach (var modifier in this.Modifiers)
            {
                if (checkedModifierNames.Contains(modifier.Name))
                {
                    modifier.IsCheckBoxChecked = true;
                }
                else
                {
                    modifier.IsCheckBoxChecked = false;
                }
            }
        }

        public virtual void EnableDisableModifiers(List<CheckBox> checks)
        {
            foreach (var check in checks)
            {
                if (this.modifierNames.Contains(check.Name))
                {
                    check.Enabled = true;
                }
            }
        }

        public virtual void CalculateOnModifierChange(string modName, bool isChecked)
        {
            foreach (var modifier in Modifiers)
            {
                if (modName == modifier.Name)
                {
                    if (isChecked != modifier.IsCheckBoxChecked)
                    {
                        modifier.IsCheckBoxChecked = isChecked;
                    }
                }
            }

            Calculate();
        }

        public override string ToString()
        {
            return $"{this.Name} (Rank {this.RanksCount})";
        }
    }
}