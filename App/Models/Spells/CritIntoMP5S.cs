using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Spells
{
    public class CritIntoMP5S : Spell
    {
        public CritIntoMP5S() : base()
        {
            Name = Constants.SpellCritIntoMP5S;

            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            return 222;
        }

        public override double? CalculateMp5TotalDec()
        {
            var r = (Player.Instance.Mp5TimeMin ?? 0) + ((Player.Instance.Mp5TimeSec ?? 0) / 60d);
            return Math.Round(r, 2); ;
        }

        public override double? CalculateMp5RPM()
        {
            if (Player.Instance.Mp5TimeDec == null || Player.Instance.Mp5TimeDec == 0)
            {
                return null;
            }
            var r = Player.Instance.Mp5TotalRiptides ?? 0;
            var x = r / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(x, 2);
        }

        public override double? CalculateMp5HWPM()
        {
            if (Player.Instance.Mp5TimeDec == 0 || Player.Instance.Mp5TimeDec == null)
            {
                return null;
            }
            var r = (Player.Instance.Mp5TotalHW ?? 0) / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(r, 2);
        }

        public override double? CalculateMp5LHWPM()
        {
            if (Player.Instance.Mp5TimeDec == 0 || Player.Instance.Mp5TimeDec == null)
            {
                return null;
            }
            var r = (Player.Instance.Mp5TotalLHW ?? 0) / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(r, 2);
        }

        public override double? CalculateMp5CHPM()
        {
            if (Player.Instance.Mp5TimeDec == 0 || Player.Instance.Mp5TimeDec == null)
            {
                return null;
            }
            var r = (Player.Instance.Mp5TotalCH ?? 0) / (double)Player.Instance.Mp5TimeDec;
            return Math.Round(r, 2);
        }

        public override double? CalculateMp5Crit()
        {
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

        public override double? CalculateMp5TotalCrit()
        {
            var r = Player.Instance.CriticalPercent * 45.91 * (Player.Instance.Mp5Crit ?? 0);
            return Math.Round(r);
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
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
