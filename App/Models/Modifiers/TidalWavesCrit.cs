using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class TidalWavesCrit : Modifier, ICriticalModifier
    {
        public TidalWavesCrit()
        {
            Name = Constants.ModTidalWavesCrit;

            Value = 25;
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.RealCriticalPercent + 25;
        }
    }
}