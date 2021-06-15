using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class Berserking : Modifier
    {
        public Berserking()
        {
            Display = Constants.ModBerserking;
            Value = 1.2;
            InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Player.Instance.HastePercent * Value + 20;
        }
    }
}
