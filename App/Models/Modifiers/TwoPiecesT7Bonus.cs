using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TwoPiecesT7Bonus : Modifier
    {
        public TwoPiecesT7Bonus()
        {
            Display = Constants.Mod2PT7Bonus;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            
        }
    }
}
