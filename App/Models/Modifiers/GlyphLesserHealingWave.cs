using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class GlyphLesserHealingWave : Modifier
    {
        public override int Modify()
        {
            Player.Instance.Hit = (int)(Player.Instance.Hit * 1.2);
            return Player.Instance.Hit;
        }
    }
}
