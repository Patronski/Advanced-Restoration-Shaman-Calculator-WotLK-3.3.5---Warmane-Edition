using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class SwiftRetribution : Modifier
    {
        public SwiftRetribution()
        {
            Display = Constants.ModSwiftRetrubution;

            Value = 1.03;

            this.InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.HasteRating = (int)(Player.Instance.HasteRating * 1.03);
            return Player.Instance.HasteRating;
        }
    }
}
