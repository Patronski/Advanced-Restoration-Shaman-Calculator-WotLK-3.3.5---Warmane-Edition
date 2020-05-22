using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class GlyphOfHealingStreamTotem : Modifier
    {
        public GlyphOfHealingStreamTotem()
        {
            Display = "Glyph Of Healing Stream Totem";
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
