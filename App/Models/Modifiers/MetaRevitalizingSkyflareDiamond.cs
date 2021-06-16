namespace App.Models.Modifiers
{
    public class MetaRevitalizingSkyflareDiamond : Modifier
    {
        public MetaRevitalizingSkyflareDiamond()
        {
            Display = Constants.ModMetaRevitalizingSkyflareDiamond;
            Value = 1.03;
        }

        public override void Modify()
        {
            Player.Instance.CriticalMultiplier = Constants.BaseCriticalMultiplier * Value;
        }
    }
}