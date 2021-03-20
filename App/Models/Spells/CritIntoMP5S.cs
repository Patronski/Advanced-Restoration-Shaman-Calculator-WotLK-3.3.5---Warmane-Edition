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

        public override void Calculate()
        {
            Player.Instance.Recalculate();
            Player.Instance.Hit1From = CalculateTarget1HitFrom();
            Player.Instance.Hit1To = CalculateTarget1HitTo();
            Player.Instance.CastingTime = CalculateCastingTime();
            Player.Instance.HotRiptide = CalculateAverageHOT1();

            ModifyWithModifiers();

            var modifier = Modifiers
                .FirstOrDefault(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);
            if (modifier != null)
            {
                modifier.Modify();
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
