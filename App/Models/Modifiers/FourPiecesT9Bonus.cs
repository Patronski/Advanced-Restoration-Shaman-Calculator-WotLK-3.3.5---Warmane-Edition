using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class FourPiecesT9Bonus : Modifier
    {
        public FourPiecesT9Bonus()
        {
            Display = Constants.Mod4PT9Bonus;

            this.InitCheckBox();
        }

        public override void Modify()
        {
        }
    }
}
