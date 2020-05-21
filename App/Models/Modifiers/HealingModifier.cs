using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class HealingModifier : Modifier
    {
        public HealingModifier()
        {
            this.CheckBox = new System.Windows.Forms.CheckBox();
        }

        public override int Modify()
        {
            throw new NotImplementedException();
        }
    }
}
