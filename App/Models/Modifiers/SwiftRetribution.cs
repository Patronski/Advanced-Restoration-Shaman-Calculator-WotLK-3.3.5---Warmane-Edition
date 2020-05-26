using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class SwiftRetribution : Modifier
    {
        public SwiftRetribution()
        {
            Display = Constants.ModSwiftRetrubution;

            Value = 1.03;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = (Player.Instance.HastePercent * 1.03);
        }
    }
}
