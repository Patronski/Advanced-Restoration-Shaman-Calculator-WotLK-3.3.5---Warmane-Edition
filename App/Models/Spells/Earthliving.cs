using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class Earthliving : Spell
    {
        public Earthliving() : base()
        {
            Name = Constants.SpellEarthliving;
            RanksCount = 6;

            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        private Modifier treeOfLife { get; set; } = new TreeOfLife();
        private Modifier hellscreamsWarsong { get; set; } = new HellscreamsWarsong();
        private Modifier emeraldVigor { get; set; } = new EmeraldVigor();

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHitFrom()
        {
            int rounded = (int)((int)(0.1692 * Player.Instance.SpellPower + 163) * 1.1);

            return rounded;
        }

        public override int? CalculateHitTo()
        {
            return null;
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            //parentPanel.Controls.Clear();

            //parentPanel.Controls.Add(new Label() { Text = "---HEALING MODIFIERS---", AutoSize = true });
            //parentPanel.Controls.Add(treeOfLife.CheckBox);
            //parentPanel.Controls.Add(hellscreamsWarsong.CheckBox);
            //parentPanel.Controls.Add(emeraldVigor.CheckBox);
        }
    }
}
