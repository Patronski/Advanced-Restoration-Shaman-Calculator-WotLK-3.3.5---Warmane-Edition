using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class RevitalizingSkyflareDiamond : Modifier
    {
        public RevitalizingSkyflareDiamond()
        {
            Display = Constants.ModMetaRevitalizingSkyflareDiamond;
            Value = 1.03;
        }

        public override void Modify()
        {
            Player.Instance.CriticalMultiplier = Constants.BaseCriticalMultiplier * Value;
        }
    }
}
