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
            Display = Constants.ModRapidConsumption;

            Value = 1.25;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
        }
    }
}
