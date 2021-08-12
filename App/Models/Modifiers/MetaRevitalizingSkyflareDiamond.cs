namespace App.Models.Modifiers
{
    public class MetaRevitalizingSkyflareDiamond : Modifier
    {
        public MetaRevitalizingSkyflareDiamond()
        {
            Name = Constants.ModMetaRevitalizingSkyflareDiamond;
            Value = 1.03;
        }

        public override void Modify()
        {
            Player.Instance.CriticalMultiplier = Constants.BaseCriticalMultiplier * Value;
        }
    }
}