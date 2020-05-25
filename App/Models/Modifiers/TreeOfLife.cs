using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TreeOfLife : Modifier
    {
        public TreeOfLife()
        {
            Display = Constants.ModTreeOfLife;

            Value = 1.06;

            this.InitCheckBox();
        }
        public override void Modify()
        {
            Player.Instance.HitFrom = (int)(Player.Instance.HitFrom * 1.06);
            Player.Instance.HitTo = (int?)(Player.Instance.HitTo * 1.06);
        }
    }
}
