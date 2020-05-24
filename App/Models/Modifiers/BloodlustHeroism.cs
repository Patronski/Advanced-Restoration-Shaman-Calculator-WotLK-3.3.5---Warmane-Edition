using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class BloodlustHeroism : Modifier
    {
        public BloodlustHeroism()
        {
            Display = Constants.ModBloodlust;
            Value = 1.3;
            InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.HasteRating = (int)(Player.Instance.HasteRating * Value);
            return Player.Instance.HasteRating;
        }
    }
}
