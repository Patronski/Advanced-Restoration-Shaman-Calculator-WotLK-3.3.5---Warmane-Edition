﻿using App.Models.Modifiers.Interfaces;
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
            Player.Instance.CriticalChance = Player.Instance.CriticalChance + 25;

            if (Player.Instance.CriticalChance > 100)
            {
                Player.Instance.CriticalChance = 100;
            }
        }
    }
}
