﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class GlyphOfEarthShield : Modifier
    {
        public GlyphOfEarthShield()
        {
            Display = Constants.ModGlyphESH;
            Value = 1.2;

            InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HitFrom = (int)(Player.Instance.HitFrom * Value);
            Player.Instance.HitTo = (int?)(Player.Instance.HitTo * Value);
        }
    }
}