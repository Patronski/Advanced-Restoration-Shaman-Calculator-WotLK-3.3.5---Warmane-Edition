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
            Display = Constants.ModGlyphHST;
            Value = 1.2;

            InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HitFrom = (int)(Player.Instance.HitFrom * Value);
            Player.Instance.HitTo = (int)(Player.Instance.HitTo * Value);
        }
    }
}
