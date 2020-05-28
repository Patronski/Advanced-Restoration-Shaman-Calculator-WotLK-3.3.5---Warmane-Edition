using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TidalWavesHaste : Modifier
    {
        public TidalWavesHaste()
        {
            Display = Constants.ModTidalWavesHaste;

            Value = 25;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            if (Player.Instance.CastingTime != null)
            {
                var castingTime = (double)Player.Instance.CastingTime * 0.7;
                Player.Instance.CastingTime = Math.Round(castingTime, 3, MidpointRounding.AwayFromZero);
            }
        }
    }
}
