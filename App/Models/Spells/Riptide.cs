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
            var avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100) * Player.Instance.Hit1Avg) + 2 * Player.Instance.AvgHot1) / 6;
                

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var isGlyphOfRiptide = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfRiptide && x.IsCheckBoxChecked);

            double? avgHps;

            if (isGlyphOfRiptide)
            {
                avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100) * Player.Instance.Hit1Avg) * 4 + (16 * Player.Instance.AvgHot1)) / 21;
            }
            else
            {
                avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100) * Player.Instance.Hit1Avg) * 3 + (9 * Player.Instance.AvgHot1)) / 15;
            }

            return (int?)avgHps; ;
        }

        public override int? CalculateAverageAAHPS()
        {
            var hps = Player.Instance.CriticalChance * Player.Instance.AncestralAwaceningAvg / 600;
            return (int?)hps;
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

        public override int? CalculateAverageHOT1()
        {
            var round = (int)(0.18 * Player.Instance.SpellPower + 334);
            round = (int)(round * 1.1);
            return round;
        }
    }
}
