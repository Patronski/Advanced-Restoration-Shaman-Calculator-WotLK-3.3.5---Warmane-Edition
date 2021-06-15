using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TotemOfForestGrowth : Modifier
    {
        public TotemOfForestGrowth()
        {
            Display = Constants.ModTotemOfForestGrowth;

            this.InitCheckBox();
        }
    }
}
