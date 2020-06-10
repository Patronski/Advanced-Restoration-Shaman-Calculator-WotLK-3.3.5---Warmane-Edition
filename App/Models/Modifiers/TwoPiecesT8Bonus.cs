using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TwoPiecesT8Bonus : Modifier
    {
        public TwoPiecesT8Bonus()
        {
            Display = Constants.Mod2PT8Bonus;

            this.InitCheckBox();
        }

        public override void Modify()
        {

        }
    }
}
