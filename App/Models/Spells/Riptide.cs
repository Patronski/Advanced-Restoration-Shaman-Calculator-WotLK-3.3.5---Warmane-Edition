using App.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Spells
{
    public class Riptide : Spell
    {
        public Riptide() : base()
        {
            Name = Constants.SpellRiptide;
            RanksCount = 4;

            this.Modifiers.Add(new TreeOfLife());
            this.Modifiers.Add(new HellscreamsWarsong());
            this.Modifiers.Add(new EmeraldVigor());
            this.Modifiers.Add(new TidalMastery());
            this.Modifiers.Add(new MoonkinForm());

            modifierNames = this.Modifiers.Select(x => x.Display).ToList();
        }

        private Modifier treeOfLife { get; set; } = new TreeOfLife();
        private Modifier hellscreamsWarsong { get; set; } = new HellscreamsWarsong();
        private Modifier emeraldVigor { get; set; } = new EmeraldVigor();

        private Modifier tidalMastery { get; set; } = new TidalMastery();
        private Modifier moonkinForm { get; set; } = new MoonkinForm();

        public override int CalculateAstralAwakening()
        {
            throw new NotImplementedException();
        }

        public override int CalculateHitFrom()
        {
            int rounded = (int)(0.402 * Player.Instance.SpellPower) + 1604;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override int? CalculateHitTo()
        {
            int rounded = (int)(0.402 * Player.Instance.SpellPower) + 1736;

            rounded = (int)(rounded * 1.1);

            return rounded;
        }

        public override void LoadModifiers(FlowLayoutPanel parentPanel)
        {
            //parentPanel.Controls.Clear();

            //parentPanel.Controls.Add(new Label() { Text = "---HEALING MODIFIERS---", AutoSize = true });
            //parentPanel.Controls.Add(treeOfLife.CheckBox);
            //parentPanel.Controls.Add(hellscreamsWarsong.CheckBox);
            //parentPanel.Controls.Add(emeraldVigor.CheckBox);

            //parentPanel.Controls.Add(new Label() { Text = "---HASTE MODIFIERS---", AutoSize = true });
            //parentPanel.Controls.Add(tidalMastery.CheckBox);
            //parentPanel.Controls.Add(moonkinForm.CheckBox);
        }
    }
}
