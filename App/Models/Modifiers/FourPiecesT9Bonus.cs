using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class FourPiecesT9Bonus : Modifier, ICriticalModifier
    {
        public FourPiecesT9Bonus()
        {
            Display = Constants.Mod4PT9Bonus;
            Value = 5;
            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent + Value;
        }
    }
}