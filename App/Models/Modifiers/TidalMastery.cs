using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TidalMastery : Modifier, ICriticalModifier
    {
        /// <summary>
        ///  have to be removed
        /// </summary>
        public TidalMastery()
        {
            Display = Constants.ModTidalMastery;

            Value = 5;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent + 5;

            if (Player.Instance.CriticalPercent > 100)
            {
                Player.Instance.CriticalPercent = 100;
            }
        }
    }
}
