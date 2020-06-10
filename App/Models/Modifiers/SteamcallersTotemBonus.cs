using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class SteamcallersTotemBonus : Modifier
    {
        public SteamcallersTotemBonus()
        {
            Display = Constants.ModSteamcallersTotem;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            
        }
    }
}
