namespace App.Models.Modifiers
{
    public class Berserking : Modifier
    {
        public Berserking()
        {
            Name = Constants.ModBerserking;
            Value = 1.2;
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Player.Instance.HastePercent * Value + 20;
        }
    }
}