using App.Models.Modifiers;
using App.Models.Modifiers.Interfaces;
using System;
using System.Linq;

namespace App.Models.Spells
{
    public class Riptide : Spell
    {
        public Riptide() : base()
        {
            Name = Constants.SpellRiptide;
            RanksCount = 4;

            this.Modifiers.Add(new MetaRevitalizingSkyflareDiamond());
            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());
            this.Modifiers.Add(new GlyphOfRiptide());
            this.Modifiers.Add(new TwoPiecesT7Bonus());
            this.Modifiers.Add(new TwoPiecesT8Bonus());
            this.Modifiers.Add(new TwoPiecesT9Bonus());
            this.Modifiers.Add(new Berserking());
            this.Modifiers.Add(new GlyphOfEarthliving());
            this.Modifiers.Add(new WrathOfTheAirTotem());
            this.Modifiers.Add(new SwiftRetribution());
            this.Modifiers.Add(new BloodlustHeroism());
            this.Modifiers.Add(new FocusMagic());

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
                avgHps = (((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier) +
                (1 - Player.Instance.CriticalPercent / 100)) * Player.Instance.Hit1Avg + (7 * Player.Instance.HotRiptide)) / cooldown;
            }
            else
            {
                avgHps = (((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier) +
                (1 - Player.Instance.CriticalPercent / 100)) * Player.Instance.Hit1Avg + (5 * Player.Instance.HotRiptide)) / cooldown;
            }

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var is2PT8Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod2PT8Bonus && x.IsCheckBoxChecked);

            int cooldown = is2PT8Equiped ? 5 : 6;
            int hotMultiplier = is2PT8Equiped ? 1 : 2;

            var avgHps = (((Player.Instance.CriticalPercent / 100 * Player.Instance.CriticalMultiplier) +
                (1 - Player.Instance.CriticalPercent / 100)) * Player.Instance.Hit1Avg + (hotMultiplier * Player.Instance.HotRiptide)) / cooldown;

            return (int?)avgHps; ;
        }

        public override int? CalculateAverageAAHPS()
        {
            var is2PT8Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod2PT8Bonus && x.IsCheckBoxChecked);

            int cooldown = is2PT8Equiped ? 500 : 600;

            var hps = Player.Instance.CriticalPercent * Player.Instance.AncestralAwaceningAvg / cooldown;
            return (int?)hps;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Crit1From * 0.297;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IHealingModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = aa * modifier.Value;
            }

            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Crit1To * 0.297;

            var healingModifiers = Modifiers.Where(x => x.GetType().GetInterface(typeof(IHealingModifier).Name) != null && x.IsCheckBoxChecked).ToList();

            foreach (var modifier in healingModifiers)
            {
                aa = aa * modifier.Value;
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

        public override double CalculateAvgHpm()
        {
            var mod2Pt7 = Modifiers.FirstOrDefault(x => x.Display == Constants.Mod2PT7Bonus).IsCheckBoxChecked;
            var multiplier = mod2Pt7 ? 5.35 : 4.92;

            // {Rip HIT * [Crtit% / 100 * 1.5 + (1 - Crit% / 100)] + [5 * Rip TICK]} / [751 - (Crit% * 4.92 )]
            var isGlyphOfRiptide = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfRiptide && x.IsCheckBoxChecked);

            var critChance = Player.Instance.CriticalPercent;
            var critValue = Player.Instance.CriticalMultiplier;

            double? avgHps;

            if (isGlyphOfRiptide)
            {
                avgHps = (((critChance / 100 * critValue) +
                (1 - critChance / 100)) * Player.Instance.Hit1Avg + (7 * Player.Instance.HotRiptide));
            }
            else
            {
                avgHps = (((critChance / 100 * critValue) +
                (1 - critChance / 100)) * Player.Instance.Hit1Avg + (5 * Player.Instance.HotRiptide));
            }

            avgHps += Player.Instance.EarthlivingAvgHpsRP;
            avgHps += Player.Instance.AncestralAwaceningAvg * Player.Instance.CriticalPercent / 100;

            avgHps /= 751;

            return Math.Round(avgHps ?? 0, 1);
        }

        public override double CalculateAvgHpmOneTarget()
        {
            var critChance = Player.Instance.CriticalPercent;
            var critValue = Player.Instance.CriticalMultiplier;

            double? avgHps = (((critChance / 100 * critValue) +
                (1 - critChance / 100)) * Player.Instance.Hit1Avg + (2 * Player.Instance.HotRiptide));

            avgHps += Player.Instance.EarthlivingAvgHpsRP;
            avgHps += Player.Instance.AncestralAwaceningAvg * Player.Instance.CriticalPercent / 100;

            avgHps /= 751;

            return Math.Round(avgHps ?? 0, 1);
        }

        public override int? CalculateEarthlivingAvgHpsRP()
        {
            var isGlyphOfEarthliving = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfEarthliving && x.IsCheckBoxChecked);

            double multiplier = isGlyphOfEarthliving ? 0.25 : 0.2;

            var result = Player.Instance.EarthlivingTick * multiplier * 4;

            return (int?)result;
        }

        public override int CalculateEarthlivingEHPS()
        {
            var is2PT8Equiped = Modifiers
                .Any(x => x.Display == Constants.Mod2PT8Bonus && x.IsCheckBoxChecked);

            int cooldown = is2PT8Equiped ? 5 : 6;

            var formula = Player.Instance.EarthlivingAvgHpsRP / cooldown;

            return (int)formula;
        }
    }
}