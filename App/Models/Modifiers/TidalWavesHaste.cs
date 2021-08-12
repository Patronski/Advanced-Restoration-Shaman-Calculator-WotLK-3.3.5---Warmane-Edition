using System;

namespace App.Models.Modifiers
{
    public class TidalWavesHaste : Modifier
    {
        public TidalWavesHaste()
        {
            Name = Constants.ModTidalWavesHaste;

            Value = 25;
        }

        public override void Modify()
        {
            if (Player.Instance.CastingTime != null)
            {
                var castingTime = (double)Player.Instance.CastingTime * 0.7;
                Player.Instance.CastingTime = Math.Round(castingTime, 3, MidpointRounding.ToEven);
            }
        }
    }
}