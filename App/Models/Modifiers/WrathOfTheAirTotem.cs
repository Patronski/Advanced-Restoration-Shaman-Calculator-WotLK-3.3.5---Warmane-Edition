namespace App.Models.Modifiers
{
    public class WrathOfTheAirTotem : Modifier
    {
        public WrathOfTheAirTotem()
        {
            Display = Constants.ModWrathOfTheAirTotem;

            Value = 1.05;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Player.Instance.HastePercent * 1.05 + 5;
        }
    }
}