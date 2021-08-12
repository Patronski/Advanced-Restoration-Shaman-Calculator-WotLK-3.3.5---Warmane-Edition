using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class FourPiecesT10Bonus : Modifier, IHealingModifier
    {
        public FourPiecesT10Bonus()
        {
            Name = Constants.Mod4PT10Bonus;
        }
    }
}