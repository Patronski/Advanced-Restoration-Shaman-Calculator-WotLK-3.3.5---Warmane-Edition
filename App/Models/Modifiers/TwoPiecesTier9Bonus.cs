namespace App.Models.Modifiers
{
    public class TwoPiecesT9Bonus : Modifier
    {
        public TwoPiecesT9Bonus()
        {
            Display = Constants.Mod2PT9Bonus;
            Value = 1.2;
            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int?)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
            Player.Instance.HotRiptide = (int?)(Player.Instance.HotRiptide * Value);
        }
    }
}