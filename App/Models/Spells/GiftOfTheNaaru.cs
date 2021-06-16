using App.Models.Modifiers;
using System.Linq;

namespace App.Models.Spells
{
    public class GiftOfTheNaaru : Spell
    {
        public GiftOfTheNaaru()
        {
            Name = Constants.SpellGiftOfTheNaaru;

            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new Berserking());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            // [(0.376 * SP) + 247] * 1.1
            var result = (0.376d * Player.Instance.SpellPower + 247) * 1.1;
            return (int)result;
        }

        public override int? CalculateAverageHPS()
        {
            var tick = Player.Instance.Hit1From;
            var result = tick * 0.4166667d;
            return (int)result;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}