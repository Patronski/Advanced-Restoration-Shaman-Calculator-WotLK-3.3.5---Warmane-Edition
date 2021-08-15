using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class FourPiecesT9Bonus : Modifier, ICriticalModifier
    {
        public FourPiecesT9Bonus()
        {
            Name = Constants.Mod4PT9Bonus;
            Value = 5;
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.RealCriticalPercent + Value;
        }
    }
}