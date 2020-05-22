using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class EarthShield : Spell
    {
        public EarthShield() : base()
        {
            Name = "Earth Shield";
            RanksCount = 5;
        }

        private Modifier treeOfLife { get; set; } = new TreeOfLife();
        private Modifier hellscreamsWarsong { get; set; } = new HellscreamsWarsong();
        private Modifier emeraldVigor { get; set; } = new EmeraldVigor();
        private Modifier glyphOfEarthShield { get; set; } = new GlyphOfEarthShield();

        private Modifier tridalMastery { get; set; } = new TidalMastery();
        private Modifier moonkinForm { get; set; } = new MoonkinForm();

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHitFrom()
        {
            int rounded = (int)(3.223 * Player.Instance.SpellPower) + 2022;

            rounded = rounded / 6;

            rounded = (int)(rounded * 1.1);

            rounded = (int)(rounded * 1.15);

            return rounded;
        }

        public override int? CalculateHitTo()
        {
            return null;
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            parentPanel.Controls.Clear();

            parentPanel.Controls.Add(new Label() { Text = "---HEALING MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(treeOfLife.CheckBox);
            parentPanel.Controls.Add(hellscreamsWarsong.CheckBox);
            parentPanel.Controls.Add(emeraldVigor.CheckBox);
            parentPanel.Controls.Add(glyphOfEarthShield.CheckBox);

            parentPanel.Controls.Add(new Label() { Text = "---HASTE MODIFIERS---", AutoSize = true });
            parentPanel.Controls.Add(tridalMastery.CheckBox);
            parentPanel.Controls.Add(moonkinForm.CheckBox);
        }
    }
}
