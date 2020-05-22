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
            Name = "Lesser Healing Wave";
            RanksCount = 9;
        }

        private Modifier treeOfLife { get; set; } = new TreeOfLife();
        private Modifier hellscreamsWarsong { get; set; } = new HellscreamsWarsong();
        private Modifier emeraldVigor { get; set; } = new EmeraldVigor();
        private Modifier glyphOfLeserHealingWave { get; set; } = new GlyphOfLesserHealingWave();

        private Modifier wrathOfTheAirTotem { get; set; } = new WrathOfTheAirTotem();
        private Modifier swiftRetribution { get; set; } = new SwiftRetribution();
        private Modifier rapidCurrents { get; set; } = new RapidCurrents();
        private Modifier tidalWaves { get; set; } = new TidalWaves();
        private Modifier bloodlustHeroism { get; set; } = new BloodlustHeroism();

        private Modifier tidalMastery { get; set; } = new TidalMastery();
        private Modifier moonkinForm { get; set; } = new MoonkinForm();

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

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            parentPanel.Controls.Clear();

            parentPanel.Controls.Add(new Label() { Text = "---HEALING MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(treeOfLife.CheckBox);
            parentPanel.Controls.Add(hellscreamsWarsong.CheckBox);
            parentPanel.Controls.Add(emeraldVigor.CheckBox);
            parentPanel.Controls.Add(glyphOfLeserHealingWave.CheckBox);

            parentPanel.Controls.Add(new Label() { Text = "---HASTE MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(wrathOfTheAirTotem.CheckBox);
            parentPanel.Controls.Add(swiftRetribution.CheckBox);
            parentPanel.Controls.Add(rapidCurrents.CheckBox);
            parentPanel.Controls.Add(bloodlustHeroism.CheckBox);

            parentPanel.Controls.Add(new Label() { Text = "---CRIT MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(tidalMastery.CheckBox);
            parentPanel.Controls.Add(moonkinForm.CheckBox);
            parentPanel.Controls.Add(new Label() { Text = "---missing ---", AutoSize = true });
        }
    }
}
