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

        public HealingStreamTotem(int spellPower): base(spellPower) { }

        private HealingModifier treeOfLife { get; set; } = new HealingModifier
        {
            Display = "Tree of Life Improved Devotion Aura",
            Type = Enums.ModifierType.HealingModifier,
            Value = 1.06,
            CheckBox = new CheckBox
            {
                AutoSize = true,
                Text = "Tree of Life Improved Devotion Aura"
            }
        };

        private HealingModifier hellscreamsWarsong { get; set; } = new HealingModifier
        {
            Display = "Hellscream's Warsong Strength of Wrynn",
            Type = Enums.ModifierType.HealingModifier,
            Value = 1.3,
            CheckBox = new CheckBox
            {
                AutoSize = true,
                Text = "Hellscream's Warsong Strength of Wrynn"
            }
        };

        private HealingModifier emeraldVigor { get; set; } = new HealingModifier
        {
            Display = "Emerald Vigor",
            Type = Enums.ModifierType.HealingModifier,
            UseExtraNumber = true,
            CheckBox = new CheckBox
            {
                AutoSize = true,
                Text = "Emerald Vigor"
            }
        };

        private HealingModifier glyphOfHealingStreamTotem { get; set; } = new HealingModifier
        {
            Display = "Glyph of Healing Stream Totem",
            Type = Enums.ModifierType.HealingModifier,
            Value = 1.2,
            CheckBox = new CheckBox
            {
                AutoSize = true,
                Text = "Glyph of Healing Stream Totem"
            }
        };

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            parentPanel.Controls.Clear();

            parentPanel.Controls.Add(new Label() { Text = "HEALING MODIFIERS" });

            var m1 = new CheckBox()
            {
                Text = "Tree of Life Improved Devotion Aura",
                AutoSize = true
            };
            var m2 = new CheckBox()
            {
                Text = "Hellscream's Warsong Strength of Wrynn",
                AutoSize = true
            };
            var m3 = new CheckBox()
            {
                Text = "Emerald Vigor",
                AutoSize = true
            };
            var m4 = new CheckBox()
            {
                Text = "Glyph of Healing Stream Totem",
                AutoSize = true
            };
            parentPanel.Controls.Add(m1);
            parentPanel.Controls.Add(m2);
            parentPanel.Controls.Add(m3);
            parentPanel.Controls.Add(m4);
        }

        public override int CalculateAstralAwakening(int rankNum, Rank rank)
        {
            throw new NotImplementedException();
        }

        public override int CalculateHot(int rankNum, Rank rank)
        {
            throw new NotImplementedException();
        }

        public override int CalculateRank(int rankNum, Rank rank)
        {
            int rounded = (int)(rank.Num1 * PlayerSpellPower) + rank.NumFrom;

            return rounded / rank.Divider;
        }
    }
}
