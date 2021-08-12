namespace App.Models.Modifiers
{
    public class WrathOfTheAirTotem : Modifier
    {
        public WrathOfTheAirTotem()
        {
            Name = Constants.ModWrathOfTheAirTotem;

            Value = 1.05;
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Player.Instance.HastePercent * 1.05 + 5;
        }
    }
}