namespace App.Models.Modifiers
{
    public class RapidCurrents : Modifier
    {
        public RapidCurrents()
        {
            Display = Constants.Mod2PT10Bonus_RapidCurrents;

            Value = 1.2;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Player.Instance.HastePercent * 1.2 + 20;
        }
    }
}