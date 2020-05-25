using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class LesserHealingWave : Spell
    {
        public LesserHealingWave() : base()
        {
            Name = Constants.SpellLHW;
            RanksCount = 9;

            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new GlyphOfLesserHealingWave());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new RapidCurrents());
            this.Modifiers.Add(new TidalWavesCrit());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHitFrom()
        {
            int rounded = (int)(0.906 * Player.Instance.SpellPower) + 1624;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override int? CalculateHitTo()
        {
            int rounded = (int)(0.906 * Player.Instance.SpellPower) + 1852;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }
    }
}
