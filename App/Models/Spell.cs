using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models
{
    public abstract class Spell
    {
        public Spell()
        {
            this.Modifiers = new List<Modifier>();
            this.CriticalMultiplier = 1;
        }

        public string Name { get; protected set; }

        public List<Modifier> Modifiers { get; set; }

        protected List<string> modifierNames;

        public double CriticalMultiplier { get; set; }

        public int RanksCount { get; set; }

        public abstract int CalculateTarget1HitFrom();
        public virtual int? CalculateTarget1HitTo() => null;
        public virtual int? CalculateTarget1HitAvg() => null;
        public virtual int? CalculateTarget1CritFrom() => null;
        public virtual int? CalculateTarget1CritTo() => null;
        public virtual int? CalculateTarget1CritAvg() => null;
        public virtual int? CalculateTarget1AvgHot() => null;

        public virtual int? CalculateTarget2HitFrom() => null;
        public virtual int? CalculateTarget2HitTo() => null;
        public virtual int? CalculateTarget2HitAvg() => null;
        public virtual int? CalculateTarget2CritFrom() => null;
        public virtual int? CalculateTarget2CritTo() => null;
        public virtual int? CalculateTarget2CritAvg() => null;
        public virtual int? CalculateTarget2AvgHot() => null;

        public virtual int? CalculateTarget3HitFrom() => null;
        public virtual int? CalculateTarget3HitTo() => null;
        public virtual int? CalculateTarget3HitAvg() => null;
        public virtual int? CalculateTarget3CritFrom() => null;
        public virtual int? CalculateTarget3CritTo() => null;
        public virtual int? CalculateTarget3CritAvg() => null;
        public virtual int? CalculateTarget3AvgHot() => null;

        public virtual int? CalculateTarget4HitFrom() => null;
        public virtual int? CalculateTarget4HitTo() => null;
        public virtual int? CalculateTarget4HitAvg() => null;
        public virtual int? CalculateTarget4CritFrom() => null;
        public virtual int? CalculateTarget4CritTo() => null;
        public virtual int? CalculateTarget4CritAvg() => null;
        public virtual int? CalculateTarget4AvgHot() => null;
        public virtual int? CalculateAverageHOT1() => null;
        public virtual int? CalculateAverageHOT2() => null;
        public virtual int? CalculateAverageHOT3() => null;
        public virtual int? CalculateAverageHOT4() => null;

        public virtual int? CalculateAstralAwakening() { return null; }
        public virtual int? CalculateAverageHPS() { return null; }
        public virtual decimal? CalculateCastingTime() { return null; }

        public virtual void Calculate()
        {
            Player.Instance.Recalculate();
            Player.Instance.Hit1From = CalculateTarget1HitFrom();
            Player.Instance.Hit2From = CalculateTarget2HitFrom();
            Player.Instance.Hit3From = CalculateTarget3HitFrom();
            Player.Instance.Hit4From = CalculateTarget4HitFrom();
            Player.Instance.Hit1To = CalculateTarget1HitTo();
            Player.Instance.Hit2To = CalculateTarget2HitTo();
            Player.Instance.Hit3To = CalculateTarget3HitTo();
            Player.Instance.Hit4To = CalculateTarget4HitTo();
            Player.Instance.Hit1Avg = CalculateTarget1HitAvg();
            Player.Instance.Hit2Avg = CalculateTarget2HitAvg();
            Player.Instance.Hit3Avg = CalculateTarget3HitAvg();
            Player.Instance.Hit4Avg = CalculateTarget4HitAvg();
            Player.Instance.Crit1Avg = CalculateTarget1CritAvg();
            Player.Instance.Crit2Avg = CalculateTarget2CritAvg();
            Player.Instance.Crit3Avg = CalculateTarget3CritAvg();
            Player.Instance.Crit4Avg = CalculateTarget4CritAvg();
            Player.Instance.Crit1To = CalculateTarget1CritTo();
            Player.Instance.Crit2To = CalculateTarget2CritTo();
            Player.Instance.Crit3To = CalculateTarget3CritTo();
            Player.Instance.Crit4To = CalculateTarget4CritTo();
            Player.Instance.Crit1From = CalculateTarget1CritFrom();
            Player.Instance.Crit2From = CalculateTarget2CritFrom();
            Player.Instance.Crit3From = CalculateTarget3CritFrom();
            Player.Instance.Crit4From = CalculateTarget4CritFrom();
            Player.Instance.AvgHPS = CalculateAverageHPS();
            Player.Instance.AvgHot1 = CalculateAverageHOT1();
            Player.Instance.AvgHot2 = CalculateAverageHOT2();
            Player.Instance.AvgHot3 = CalculateAverageHOT3();
            Player.Instance.AvgHot4 = CalculateAverageHOT4();
            Player.Instance.CastingTime = CalculateCastingTime();

            ModifyWithModifiers();
        }

        public override string ToString()
        {
            return $"{this.Name} (Rank {this.RanksCount})";
        }

        protected void ModifyWithModifiers()
        {
            foreach (var modifier in Modifiers)
            {
                if (modifier.IsCheckBoxChecked)
                {
                    modifier.Modify();
                }
            }
        }

        public void CheckModifiers(List<string> checkedModifierNames)
        {
            foreach (var modifier in this.Modifiers)
            {
                if (checkedModifierNames.Contains(modifier.Display))
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
                if (this.modifierNames.Contains(check.Text))
                {
                    check.Enabled = true;
                }
                else
                {
                    check.Enabled = false;
                }
            }
        }

        public void CalculateOnModifierChange(string name, bool isChecked)
        {
            foreach (var modifier in Modifiers)
            {
                if (name == modifier.Display)
                {
                    if (isChecked != modifier.IsCheckBoxChecked)
                    {
                        modifier.IsCheckBoxChecked = isChecked;
                        break;
                    }
                }
            }

            Calculate();
        }
    }
}
