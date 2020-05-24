using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class HellscreamsWarsong : Modifier
    {
        public HellscreamsWarsong()
        {
            Display = Constants.ModHellscream;

            Value = 1.3;

            this.InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.Hit = (int)(Player.Instance.Hit * Value);
            return Player.Instance.Hit;
        }
    }
}
