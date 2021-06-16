namespace App.Models.Modifiers
{
    public class GlyphOfChainHeal : Modifier
    {
        public GlyphOfChainHeal()
        {
            Display = Constants.ModGlyphOfChainHeal;
        }

        public override void Modify()
        {
            Player.Instance.AvgHot4 = 0;
            Player.Instance.Crit4Avg = 0;
            Player.Instance.Crit4From = 0;
            Player.Instance.Crit4To = 0;
            Player.Instance.Hit4To = 0;
            Player.Instance.Hit4From = 0;
            Player.Instance.Hit4Avg = 0;
        }
    }
}