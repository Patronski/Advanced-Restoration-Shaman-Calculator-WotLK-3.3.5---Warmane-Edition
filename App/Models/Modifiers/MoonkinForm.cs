using App.Models.Modifiers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class MoonkinForm : Modifier, ICriticalModifier
    {
        public MoonkinForm()
        {
            Display = Constants.ModMoonkin;

            Value = 5;

            this.InitCheckBox();
        }

        public override void Modify()
        {
            Player.Instance.CriticalChance = Player.Instance.CriticalChance + Value;
            
            if (Player.Instance.CriticalChance > 100)
            {
                Player.Instance.CriticalChance = 100;
            }
        }
    }
}
