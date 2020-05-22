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
            Name = "Healing Wave";
            RanksCount = 14;
        }

        private Modifier treeOfLife { get; set; } = new TreeOfLife();
        private Modifier hellscreamsWarsong { get; set; } = new HellscreamsWarsong();
        private Modifier emeraldVigor { get; set; } = new EmeraldVigor();

        private Modifier wrathOfTheAirTotem { get; set; } = new WrathOfTheAirTotem();
        private Modifier swiftRetribution { get; set; } = new SwiftRetribution();
        private Modifier rapidCurrents { get; set; } = new RapidCurrents();
        private Modifier tridalWaves { get; set; } = new TidalWaves();
        private Modifier bloodlustHeroism { get; set; } = new BloodlustHeroism();

        private Modifier tridalMastery { get; set; } = new TidalMastery();
        private Modifier moonkinForm { get; set; } = new MoonkinForm();

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHitFrom()
        {
            int rounded = (int)(1.811 * Player.Instance.SpellPower) + 3034;

            rounded = (int)(rounded * 1.375);

            return rounded;
        }

        public override int? CalculateHitTo()
        {
            int rounded = (int)(1.811 * Player.Instance.SpellPower) + 3466;

            rounded = (int)(rounded * 1.375);

            return rounded;
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            parentPanel.Controls.Clear();

            parentPanel.Controls.Add(new Label() { Text = "---HEALING MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(treeOfLife.CheckBox);
            parentPanel.Controls.Add(hellscreamsWarsong.CheckBox);
            parentPanel.Controls.Add(emeraldVigor.CheckBox);

            parentPanel.Controls.Add(new Label() { Text = "---HASTE MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(wrathOfTheAirTotem.CheckBox);
            parentPanel.Controls.Add(swiftRetribution.CheckBox);
            parentPanel.Controls.Add(rapidCurrents.CheckBox);
            parentPanel.Controls.Add(tridalWaves.CheckBox);
            parentPanel.Controls.Add(bloodlustHeroism.CheckBox);

            parentPanel.Controls.Add(new Label() { Text = "---CRIT MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(tridalMastery.CheckBox);
            parentPanel.Controls.Add(moonkinForm.CheckBox);
        }
    }
}
