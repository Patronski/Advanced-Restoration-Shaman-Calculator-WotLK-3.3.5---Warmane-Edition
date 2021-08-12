using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class TalentsCriticalDepression : Modifier, ICriticalModifier
    {
        public TalentsCriticalDepression()
        {
            Name = Constants.ModTCD;

            Value = 1;
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent - Player.Instance.TallentsCriticalDepression;

            if (Player.Instance.CriticalPercent > 100)
            {
                Player.Instance.CriticalPercent = 100;
            }
            if (Player.Instance.CriticalPercent < 0)
            {
                Player.Instance.CriticalPercent = 0;
            }
        }
    }
}
