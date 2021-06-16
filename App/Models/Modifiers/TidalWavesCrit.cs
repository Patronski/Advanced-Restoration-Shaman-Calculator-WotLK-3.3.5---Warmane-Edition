using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class TidalWavesCrit : Modifier, ICriticalModifier
    {
        public TidalWavesCrit()
        {
            Display = Constants.ModTidalWavesCrit;

            Value = 25;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent + 25;

            if (Player.Instance.CriticalPercent > 100)
            {
                Player.Instance.CriticalPercent = 100;
            }
        }
    }
}