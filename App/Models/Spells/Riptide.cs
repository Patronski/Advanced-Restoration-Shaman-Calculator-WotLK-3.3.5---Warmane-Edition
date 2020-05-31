using App.Models.Modifiers;
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
            double hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;

            var avgHps = (Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100) * Player.Instance.Hit1Avg * (1 + hastePercent / 100) * 0.6667; //god bless

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {

            double hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;

            var avgHps = Player.Instance.CriticalChance / 100 * Player.Instance.AncestralAwaceningAvg *
                (1 + hastePercent / 100) * 0.6667;

            return (int?)avgHps; ;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Crit1From * 0.33;
            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Crit1To * 0.33;
            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningAvg()
        {
            return (Player.Instance.AncestralAwaceningFrom + Player.Instance.AncestralAwaceningTo) / 2;
        }

        public override int? CalculateAverageAAHPS()
        {
            return base.CalculateAverageAAHPS();
        }
    }
}
