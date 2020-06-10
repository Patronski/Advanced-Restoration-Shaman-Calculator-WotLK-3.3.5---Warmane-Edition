using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class FourPiecesT8Bonus : Modifier
    {
        public FourPiecesT8Bonus()
        {
            Display = Constants.Mod4PT8Bonus;

            this.InitCheckBox();
        }

        public override void Modify()
        {

        }
    }
}
