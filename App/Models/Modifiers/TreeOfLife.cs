using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class TreeOfLife : Modifier, IHealingModifier
    {
        public TreeOfLife()
        {
            Name = Constants.ModTreeOfLife;

            Value = 1.06;
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
            Player.Instance.HotRiptide = (int?)(Player.Instance.HotRiptide * Value);
            Player.Instance.EarthlivingTick = (int)(Player.Instance.EarthlivingTick * Value);
        }
    }
}