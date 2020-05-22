using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class GlyphLesserHealingWave : Modifier
    {
        public GlyphLesserHealingWave()
        {
            Display = "Glyph Lesser Healing Wave";
            Value = 1.2;

            InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.Hit = (int)(Player.Instance.Hit * Value);
            return Player.Instance.Hit;
        }
    }
}
