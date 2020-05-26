using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class EmeraldVigor : Modifier
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

            Player.Instance.HitFrom = (int)(emeraldVigorMultiplier * Player.Instance.HitFrom);
            Player.Instance.HitTo = (int?)(emeraldVigorMultiplier * Player.Instance.HitTo);
        }
    }
}
