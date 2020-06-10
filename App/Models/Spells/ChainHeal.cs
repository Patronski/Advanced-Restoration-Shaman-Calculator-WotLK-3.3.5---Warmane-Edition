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

            var modifierFields = this.GetType().GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Instance)
                .Where(x => x.FieldType.IsAssignableFrom(typeof(Modifier)));

            this.Modifiers.Add(new RevitalizingSkyflareDiamond());
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
            this.Modifiers.Add(new GlyphOfChainHeal());
            this.Modifiers.Add(new FourPiecesT7Bonus());
            this.Modifiers.Add(new SteamcallersTotemBonus());
            this.Modifiers.Add(new FourPiecesT8Bonus());
            this.Modifiers.Add(new FourPiecesT9Bonus());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        public override int CalculateTarget1HitFrom()
        {
            int a = 0;
            //if (Steamcaller's Totem )
            //{
            //    a = 243
            //}
            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1055 + a) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget1HitTo()
        {
            int a = 0;
            //if (Steamcaller's Totem )
            //{
            //    a = 243
            //}
            int rounded = (int)((int)(1.342 * Player.Instance.SpellPower + 1205 + a) * 1.32);

            return rounded;
        }

        public override int? CalculateTarget2HitFrom()
        {
            return (int?)(Player.Instance.Hit1From * 0.6);
        }

        public override int? CalculateTarget2HitTo()
        {
            return (int?)(Player.Instance.Hit1To * 0.6);
        }

        public override int? CalculateTarget3HitFrom()
        {
            return (int?)(Player.Instance.Hit1From * 0.36);
        }

        public override int? CalculateTarget3HitTo()
        {
            return (int?)(Player.Instance.Hit1To * 0.36);
        }

        public override int? CalculateTarget4HitFrom()
        {
            return (int?)(Player.Instance.Hit1From * 0.216);
        }

        public override int? CalculateTarget4HitTo()
        {
            return (int?)(Player.Instance.Hit1To * 0.216);
        }

        public override int? CalculateAverageHOT1()
        {
            if (Player.Instance.Crit1Avg == null) return null;
            var hot = (int)(Player.Instance.Crit1Avg * 0.25 / 3);
            return hot;
        }
        public override int? CalculateAverageHOT2()
        {
            var hot = (int)(Player.Instance.Crit2Avg * 0.25 / 3);
            return hot;
        }
        public override int? CalculateAverageHOT3()
        {
            var hot = (int)(Player.Instance.Crit3Avg * 0.25 / 3);
            return hot;
        }
        public override int? CalculateAverageHOT4()
        {
            var hot = (int)(Player.Instance.Crit4Avg * 0.25 / 3);
            return hot;
        }

        public override double? CalculateCastingTime()
        {
            var castingTime = 2.5 / (1 + Player.Instance.HastePercent / 100); // 4p/T8 2.5 -> 2.3
            castingTime = Math.Truncate(castingTime * 1000) / 1000;

            return castingTime;
        }

        public override int? CalculateAverageHPS()
        {
            var hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;

            var formula = (((Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue)
                + (1 - Player.Instance.CriticalChance / 100 ) )
                * Player.Instance.Hit1Avg * 0.4 * (1 + hastePercent / 100));

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            var result = (int)(formula + formula * 0.6 + formula * 0.36 + formula * 0.216);

            if (!isGlyphOfChainHeal)
            {
                result = (int)(formula + formula * 0.6 + formula * 0.36);
            }

            return result;
        }

        public override int? CalculateAverageHotHPS()
        {
            var hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;

            var formula = Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue * Player.Instance.Hit1Avg * 0.01111 * (1 + hastePercent / 100);

            var isGlyphOfChainHeal = Modifiers
                .Any(x => x.Display == Constants.ModGlyphOfChainHeal && x.IsCheckBoxChecked);

            var result = (int)(formula + formula * 0.6 + formula * 0.36 + formula * 0.216);

            if (!isGlyphOfChainHeal)
            {
                result = (int)(formula + formula * 0.6 + formula * 0.36);
            }

            return result;
        }
    }
}
