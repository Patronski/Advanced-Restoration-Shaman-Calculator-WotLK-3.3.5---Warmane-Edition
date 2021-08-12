namespace App.Models.Modifiers
{
    public class GlyphOfEarthShield : Modifier
    {
        public GlyphOfEarthShield()
        {
            Name = Constants.ModGlyphESH;
            Value = 1.2;
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
        }
    }
}