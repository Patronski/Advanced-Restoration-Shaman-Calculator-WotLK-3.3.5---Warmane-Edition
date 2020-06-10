using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class FourPiecesT9Bonus : Modifier, ICriticalModifier
    {
        public FourPiecesT9Bonus()
        {
            Display = Constants.Mod4PT9Bonus;
            Value = 5;
            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalChance = Player.Instance.CriticalChance + Value;
        }
    }
}
