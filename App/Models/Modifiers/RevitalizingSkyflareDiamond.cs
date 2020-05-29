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
            Display = Constants.ModRevitalizingSkyflareDiamond;
        }
        public override void Modify()
        {
            Player.Instance.CriticalValue = 1.5 * 1.03;
        }
    }
}
