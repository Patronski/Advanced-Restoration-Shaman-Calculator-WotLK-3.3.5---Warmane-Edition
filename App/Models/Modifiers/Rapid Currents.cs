using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class Rapid_Currents : Modifier
    {
        public override int Modify()
        {
            Player.Instance.HasteRating = (int)(Player.Instance.HasteRating * 1.2);
            return Player.Instance.HasteRating;
        }
    }
}
