namespace App.Models.Modifiers
{
    public class GlyphOfLesserHealingWave : Modifier
    {
        public GlyphOfLesserHealingWave()
        {
            Name = Constants.ModGlyphLHW;
            Value = 1.2;
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
        }
    }
}