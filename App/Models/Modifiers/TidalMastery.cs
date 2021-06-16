using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class TidalMastery : Modifier, ICriticalModifier
    {
        public TidalMastery()
        {
            Display = Constants.ModTidalMastery;

            Value = 5;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent + 5;

            if (Player.Instance.CriticalPercent > 100)
            {
                Player.Instance.CriticalPercent = 100;
            }
        }
    }
}