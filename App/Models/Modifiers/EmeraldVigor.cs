using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class EmeraldVigor : Modifier, IAncestralAwakeningModifier
    {
        public EmeraldVigor()
        {
            Display = Constants.ModEmeraldVigor;
            UseExtraNumber = true;

            InitCheckBox();
        }

        public override void Modify()
        {
            var emeraldVigorMultiplier = 1 + (Player.Instance.EmeraldVigorNumber / 10d);
            this.Value = emeraldVigorMultiplier;

            Player.Instance.Hit1From = (int)(emeraldVigorMultiplier * Player.Instance.Hit1From);
            Player.Instance.Hit1To = (int?)(emeraldVigorMultiplier * Player.Instance.Hit1To);
            Player.Instance.HotRiptide = (int?)(emeraldVigorMultiplier * Player.Instance.HotRiptide);
        }
    }
}
