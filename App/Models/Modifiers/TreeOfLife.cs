﻿using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TreeOfLife : Modifier, IAncestralAwakeningModifier
    {
        public TreeOfLife()
        {
            Display = Constants.ModTreeOfLife;

            Value = 1.06;

            this.InitCheckBox();
        }
        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * 1.06);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * 1.06);
        }
    }
}
