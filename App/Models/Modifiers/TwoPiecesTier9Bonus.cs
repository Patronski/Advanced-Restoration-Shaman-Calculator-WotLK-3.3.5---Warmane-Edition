using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TwoPiecesTier9Bonus : Modifier
    {
        public TwoPiecesTier9Bonus()
        {
            Display = Constants.ModWrathOfTheAirTotem;

            Value = 1.05;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            throw new NotImplementedException();
        }
    }
}
