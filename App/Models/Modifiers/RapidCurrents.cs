using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class RapidCurrents : Modifier
    {
        public RapidCurrents()
        {
            Display = Constants.ModRapidCurrents;

            Value = 1.2;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Player.Instance.HastePercent * 1.2;
        }
    }
}
