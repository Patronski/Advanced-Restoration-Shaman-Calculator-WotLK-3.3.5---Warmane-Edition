using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class FourPiecesT10Bonus : Modifier, IHealingModifier
    {
        public FourPiecesT10Bonus()
        {
            Display = Constants.Mod4PT10Bonus;
            this.InitCheckBox();
        }

        public override void Modify()
        {
        }
    }
}
