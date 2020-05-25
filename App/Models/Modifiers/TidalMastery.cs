using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TidalMastery : Modifier
    {
        public TidalMastery()
        {
            Display = Constants.ModTidalMastery;

            Value = 5;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalChance = Player.Instance.CriticalChance + 5;
            if (Player.Instance.CriticalChance > 100)
            {
                Player.Instance.CriticalChance = 100;
            }
        }
    }
}
