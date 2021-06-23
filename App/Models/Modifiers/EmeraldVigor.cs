using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class EmeraldVigor : Modifier, IHealingModifier
    {
        public EmeraldVigor()
        {
            Display = Constants.ModEmeraldVigor;

            InitCheckBox();
        }

        public override void Modify()
        {
            var emeraldVigorMultiplier = 1 + (Player.Instance.EmeraldVigorNumber / 10d);
            this.Value = emeraldVigorMultiplier;

            Player.Instance.Hit1From = (int)(emeraldVigorMultiplier * Player.Instance.Hit1From);
            Player.Instance.Hit1To = (int?)(emeraldVigorMultiplier * Player.Instance.Hit1To);
            Player.Instance.HotRiptide = (int?)(emeraldVigorMultiplier * Player.Instance.HotRiptide);
            Player.Instance.EarthlivingTick = (int)(emeraldVigorMultiplier * Player.Instance.EarthlivingTick);
        }
    }
}