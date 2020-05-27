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
            this.CriticalMultiplier = 1.5;

            var modifierFields = this.GetType().GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Instance)
                .Where(x => x.FieldType.IsAssignableFrom(typeof(Modifier)));

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

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int? CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateTarget1HitFrom()
        {
            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1055) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1205) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget2HitFrom()
        {
            return (int)(CalculateTarget1HitFrom() * 0.6);
        }

        public override int? CalculateTarget2HitTo()
        {
            return (int)(CalculateTarget1HitTo() * 0.6);
        }
    }
}
