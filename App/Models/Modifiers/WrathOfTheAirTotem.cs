using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class WrathOfTheAirTotem : Modifier
    {
        public WrathOfTheAirTotem()
        {
            Display = "Wrath Of The Air Totem";

            Value = 1.05;

            this.InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.HasteRating = (int)(Player.Instance.HasteRating * 1.05);
            return Player.Instance.HasteRating;
        }
    }
}
