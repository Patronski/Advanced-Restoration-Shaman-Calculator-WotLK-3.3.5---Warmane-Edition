using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TidalWavesCrit : Modifier, ICriticalModifier
    {
        public TidalWavesCrit()
        {   
            Display = Constants.ModTidalWavesCrit;

            Value = 25;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent + 25;

            if (Player.Instance.CriticalPercent > 100)
            {
                Player.Instance.CriticalPercent = 100;
            }
        }
    }
}
