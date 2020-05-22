using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class HealingStreamTotem : Spell
    {
        public HealingStreamTotem() : base()
        {
            Name = "Healing Stream Totem";

            RanksCount = 9;

            CurrentRank = new Rank { Num1 = 12.408, NumFrom = 3750, Divider = 150 };

            this.Modifiers.Add(treeOfLife);
            this.Modifiers.Add(hellscreamsWarsong);
            this.Modifiers.Add(emeraldVigor);
            this.Modifiers.Add(glyphOfHealingStreamTotem);
        }

        private Modifier treeOfLife { get; set; } = new TreeOfLife();

        private Modifier hellscreamsWarsong { get; set; } = new HellscreamsWarsong();

        private Modifier emeraldVigor { get; set; } = new EmeraldVigor();

        private Modifier glyphOfHealingStreamTotem { get; set; } = new GlyphOfHealingStreamTotem();

        public override void LoadModifiers(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            panel.Controls.Add(new Label() { Text = "---HEALING MODIFIERS---", AutoSize = true });
            panel.Controls.Add(treeOfLife.CheckBox);
            panel.Controls.Add(this.hellscreamsWarsong.CheckBox);
            panel.Controls.Add(emeraldVigor.CheckBox);
            panel.Controls.Add(glyphOfHealingStreamTotem.CheckBox);
        }

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHit()
        {
            int rounded = (int)(CurrentRank.Num1 * Player.Instance.SpellPower) + CurrentRank.NumFrom;

            return rounded / CurrentRank.Divider;
        }

        public override int CalculateRank()
        {
            int rounded = (int)(CurrentRank.Num1 * Player.Instance.SpellPower) + CurrentRank.NumFrom;

            return rounded / CurrentRank.Divider;
        }
    }
}
