using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class FourPiecesT7Bonus : Modifier
    {
        public FourPiecesT7Bonus()
        {
            Display = Constants.Mod4PT7Bonus;

            this.InitCheckBox();
        }

        public override void Modify()
        {
        }
    }
}
