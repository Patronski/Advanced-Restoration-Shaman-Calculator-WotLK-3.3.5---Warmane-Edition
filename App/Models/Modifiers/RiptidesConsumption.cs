using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class RiptidesConsumption : Modifier
    {
        public RiptidesConsumption()
        {
            Display = "Riptides Consumption";

            Value = 1.25;

            this.InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.Hit = (int)(Player.Instance.Hit * Value);
            return Player.Instance.Hit;
        }
    }
}
