using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class HellscreamsWarsong : Modifier, IHealingModifier
    {
        public HellscreamsWarsong()
        {
            Display = Constants.ModHellscream;

            Value = 1.3;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
            Player.Instance.HotRiptide = (int?)(Player.Instance.HotRiptide * Value);
        }
    }
}