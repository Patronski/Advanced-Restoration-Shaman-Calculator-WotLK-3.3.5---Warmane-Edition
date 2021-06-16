namespace App.Models.Modifiers
{
    public class SteamcallersTotemBonus : Modifier
    {
        public SteamcallersTotemBonus()
        {
            Display = Constants.ModSteamcallersTotem;

            this.InitCheckBox();
        }
    }
}