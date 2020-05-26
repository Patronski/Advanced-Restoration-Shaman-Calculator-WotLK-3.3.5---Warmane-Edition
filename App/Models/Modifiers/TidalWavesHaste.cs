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
            Player.Instance.HastePercent = Player.Instance.HastePercent + 25;
        }
    }
}
