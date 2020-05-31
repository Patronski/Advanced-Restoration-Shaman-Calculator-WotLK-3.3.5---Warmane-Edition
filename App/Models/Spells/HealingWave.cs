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

            this.Modifiers.Add(new RevitalizingSkyflareDiamond());
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

        public override int? CalculateAverageHPS()
        {
            var isTidalWaves = Modifiers
                .Any(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);

            double hastePercent;
            double multiplier;
            if (isTidalWaves)
            {
                hastePercent = (Player.Instance.HastePercent > 75) ? 75d : Player.Instance.HastePercent;
                multiplier = 0.57143;
            }
            else
            {
                hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;
                multiplier = 0.4;
            }

            var avgHps = (Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100) * Player.Instance.Hit1Avg * (1 + hastePercent / 100) * multiplier;

            return (int?)avgHps;
        }

        public override int? CalculateAverageHotHPS()
        {
            var isTidalWaves = Modifiers
                .Any(x => x.Display == Constants.ModTidalWavesHaste && x.IsCheckBoxChecked);

            double hastePercent;
            double multiplier;
            if (isTidalWaves)
            {
                hastePercent = (Player.Instance.HastePercent > 75) ? 75d : Player.Instance.HastePercent;
                multiplier = 0.57143;
            }
            else
            {
                hastePercent = (Player.Instance.HastePercent > 150) ? 150d : Player.Instance.HastePercent;
                multiplier = 0.4;
            }

            var avgHps = (Player.Instance.CriticalChance / 100 * Player.Instance.CriticalValue) +
                (1 - Player.Instance.CriticalChance / 100) * Player.Instance.Hit1Avg * (1 + hastePercent / 100) * multiplier;

            return (int?)avgHps; ;
        }

        public override int? CalculateAncestralAwakeningFrom()
        {
            var aa = Player.Instance.Hit1From * 0.33;
            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningTo()
        {
            var aa = Player.Instance.Hit1To * 0.33;
            return (int?)aa;
        }

        public override int? CalculateAncestralAwakeningAvg()
        {
            return (Player.Instance.AncestralAwaceningFrom + Player.Instance.AncestralAwaceningTo) / 2;
        }
    }
}
