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
            Player.Instance.CriticalPercent = Player.Instance.RealCriticalPercent - Player.Instance.TallentsCriticalDepression;
        }
    }
}
