using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class HellscreamsWarsong : Modifier
    {
        public override int Modify()
        {
            Player.Instance.Hit = (int)(Player.Instance.Hit * 1.3);
            return Player.Instance.Hit;
        }
    }
}
