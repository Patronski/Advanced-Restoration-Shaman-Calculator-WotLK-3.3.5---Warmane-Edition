using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TotemOfTheBay : Modifier
    {
        public TotemOfTheBay()
        {
            Display = Constants.ModTotemOfTheBay;

            this.InitCheckBox();
        }
    }
}
