using App.Models.Modifiers.Interfaces;

namespace App.Models.Modifiers
{
    public class MoonkinForm : Modifier, ICriticalModifier
    {
        public MoonkinForm()
        {
            Name = Constants.ModMoonkin;

            Value = 5;
        }

        public override void Modify()
        {
            Player.Instance.CriticalPercent = Player.Instance.CriticalPercent + Value;

            if (Player.Instance.CriticalPercent > 100)
            {
                Player.Instance.CriticalPercent = 100;
            }
        }
    }
}