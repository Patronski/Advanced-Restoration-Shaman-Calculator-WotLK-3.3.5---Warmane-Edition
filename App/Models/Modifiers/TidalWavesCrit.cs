using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TidalWavesCrit : Modifier
    {
        public TidalWavesCrit()
        {   
            Display = Constants.ModTidalWavesCrit;

            Value = 25;

            this.InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.CriticalChance = Player.Instance.CriticalChance + 25;
            if (Player.Instance.CriticalChance > 100)
            {
                Player.Instance.CriticalChance = 100;
            }

            return (int)Player.Instance.CriticalChance;
        }
    }
}
