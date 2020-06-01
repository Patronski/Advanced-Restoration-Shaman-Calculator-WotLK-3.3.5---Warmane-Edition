using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class HellscreamsWarsong : Modifier, IAncestralAwakeningModifier
    {
        public HellscreamsWarsong()
        {
            Display = Constants.ModHellscream;

            Value = 1.3;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
        }
    }
}
