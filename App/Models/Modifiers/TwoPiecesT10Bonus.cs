namespace App.Models.Modifiers
{
    public class TwoPiecesT10Bonus : Modifier
    {
        public TwoPiecesT10Bonus()
        {
            Display = Constants.Mod2PT10Bonus_RapidCurrents;

            this.InitCheckBox();
        }
    }
}