using System;

namespace App.Models.Modifiers
{
    public class BloodlustHeroism : Modifier
    {
        public BloodlustHeroism()
        {
            Display = Constants.ModBloodlust;
            InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.HastePercent = Math.Round(Player.Instance.HastePercent * 1.3 + 30, 2);
        }
    }
}