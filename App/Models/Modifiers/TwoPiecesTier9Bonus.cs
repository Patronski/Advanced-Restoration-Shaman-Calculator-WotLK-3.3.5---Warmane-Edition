﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TwoPiecesT9Bonus : Modifier
    {
        public TwoPiecesT9Bonus()
        {
            Display = Constants.Mod2PT9Bonus;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            
        }
    }
}
