﻿namespace App.Models.Modifiers
{
    public class GlyphOfHealingStreamTotem : Modifier
    {
        public GlyphOfHealingStreamTotem()
        {
            Display = Constants.ModGlyphHST;
            Value = 1.2;

            InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.Hit1From = (int)(Player.Instance.Hit1From * Value);
            Player.Instance.Hit1To = (int?)(Player.Instance.Hit1To * Value);
        }
    }
}