using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class HealingWave : Spell
    {
        public HealingWave() : base()
        {
            Name = Constants.SpellHW;
            RanksCount = 14;

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

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int? CalculateAstralAwakening()
        {
            throw new NotImplementedException();
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
            var castingTime = 2.5 / (1 + Player.Instance.HastePercent / 100);
            castingTime = Math.Round(castingTime, 3, MidpointRounding.AwayFromZero);

            return castingTime;
        }
    }
}
