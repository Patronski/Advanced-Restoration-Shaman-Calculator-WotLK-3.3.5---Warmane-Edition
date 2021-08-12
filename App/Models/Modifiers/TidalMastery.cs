using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class TidalMastery : Modifier, ICriticalModifier
    {
        public TidalMastery()
        {
            Name = Constants.ModTidalMastery;

            Value = 5;
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.RealCriticalPercent + 5;
        }
    }
}