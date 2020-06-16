using App.Models.Modifiers;
using App.Models.Modifiers.Interfaces;
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
            this.Modifiers.Add(new TwoPiecesT9Bonus());
            this.Modifiers.Add(new TwoPiecesT8Bonus());

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
            var isGlyphOfRiptide = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfRiptide && x.IsCheckBoxChecked);
            var is2PT8Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod2PT8Bonus && x.IsCheckBoxChecked);

            int cooldown = is2PT8Equiped ? 5 : 6;

            double? avgHps;

            if (isGlyphOfRiptide)
            {
                avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg + (7 * Player.Instance.HotRiptide)) / cooldown;
            }
            else
            {
                avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg + (5 * Player.Instance.HotRiptide)) / cooldown;
            }

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var is2PT8Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod2PT8Bonus && x.IsCheckBoxChecked);

            int cooldown = is2PT8Equiped ? 5 : 6;
            int hotMultiplier = is2PT8Equiped ? 1 : 2;

            var avgHps = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100)) * Player.Instance.Hit1Avg + (hotMultiplier * Player.Instance.HotRiptide)) / cooldown;

            return (int?)avgHps; ;
        }

        public override int? CalculateAverageAAHPS()
        {
            var is2PT8Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod2PT8Bonus && x.IsCheckBoxChecked);

            int cooldown = is2PT8Equiped ? 500 : 600;

            var hps = Player.Instance.CriticalChance * Player.Instance.AncestralAwaceningAvg / cooldown;
            return (int?)hps;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Crit1From * 0.33;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IAncestralAwakeningModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = (int)aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Crit1To * 0.33;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IAncestralAwakeningModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = (int)aa * modifier.Value;
            }

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

        public override int? CalculateAvgHpm()
        {
            // {Rip HIT * [Crtit% / 100 * 1.5 + (1 - Crit% / 100)] + [5 * Rip TICK]} / [751 - (Crit% * 4.92 )]
            var isGlyphOfRiptide = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfRiptide && x.IsCheckBoxChecked);
            var critChance = Player.Instance.CriticalChance;
            var critValue = Player.Instance.CriticalValue;

            double? avgHps;

            if (isGlyphOfRiptide)
            {
                avgHps = (((critChance / 100 * critValue) +
                (1 - critChance / 100)) * Player.Instance.Hit1Avg + (7 * Player.Instance.HotRiptide)) / (751 - critChance * 4.92);
            }
            else
            {
                avgHps = (((critChance / 100 * critValue) +
                (1 - critChance / 100)) * Player.Instance.Hit1Avg + (5 * Player.Instance.HotRiptide)) / (751 - critChance * 4.92);
            }

            return (int)Math.Round(avgHps ?? 0);
        }
    }
}
