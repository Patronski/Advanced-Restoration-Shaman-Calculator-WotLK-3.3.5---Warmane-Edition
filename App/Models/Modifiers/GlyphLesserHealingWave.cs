using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class GlyphOfLesserHealingWave : Modifier
    {
        public GlyphOfLesserHealingWave()
        {
            Display = Constants.ModGlyphLHW;
            Value = 1.2;

            InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HitFrom = (int)(Player.Instance.HitFrom * Value);
            Player.Instance.HitTo = (int?)(Player.Instance.HitTo * Value);
        }
    }
}
