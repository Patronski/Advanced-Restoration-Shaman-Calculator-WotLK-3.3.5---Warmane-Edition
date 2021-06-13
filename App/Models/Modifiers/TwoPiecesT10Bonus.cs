using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TwoPiecesT10Bonus : Modifier
    {
        public TwoPiecesT10Bonus()
        {
            Display = Constants.Mod2PT10Bonus_RapidCurrents;

            this.InitCheckBox();
        }
    }
}
