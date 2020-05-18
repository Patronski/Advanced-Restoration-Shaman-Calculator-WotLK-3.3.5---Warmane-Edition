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

            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 900, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 1200, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 1500, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 1800, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 2100, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 2700, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 3000, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 3450, Divider = 150 });
            Ranks.Add(new Rank { Num1 = 12.408, NumFrom = 3750, Divider = 150 });

            this.Modifiers.Add(new Modifier 
            { 
                Display = "Tree of Life Improved Devotion Aura", 
                Type = Enums.ModifierType.HealingModifier, 
                Value = 1.06,
                
            });
            this.Modifiers.Add(new Modifier 
            {
                Display = "Hellscream's Warsong Strength of Wrynn", 
                Type = Enums.ModifierType.HealingModifier,
                Value = 1.3 
            });
            this.Modifiers.Add(new Modifier 
            {
                Display = "Emerald Vigor", 
                Type = Enums.ModifierType.HealingModifier, 
                UseExtraNumber = true 
            });
            this.Modifiers.Add(new Modifier 
            { 
                Display = "Glyph of Healing Stream Totem", 
                Type = Enums.ModifierType.HealingModifier, 
                Value = 1.2 
            });
        }

        public HealingStreamTotem(int spellPower): base(spellPower) { }

        private CheckBox modifier1 { get; set; }
        private CheckBox modifier2 { get; set; }
        private CheckBox modifier3 { get; set; }
        private CheckBox modifier4 { get; set; }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            parentPanel.Controls.Clear();

            parentPanel.Controls.Add(new Label() { Text = "Healing modifiers" });

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
