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

        public abstract int CalculateHitFrom();

        public abstract int? CalculateHitTo();

        public abstract int CalculateAstralAwakening();

        public virtual void Calculate()
        {
            Player.Instance.Recalculate();
            Player.Instance.HitFrom = CalculateHitFrom();
            Player.Instance.HitTo = CalculateHitTo();

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
