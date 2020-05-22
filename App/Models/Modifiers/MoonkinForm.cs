using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class MoonkinForm : Modifier
    {
        public MoonkinForm()
        {
            Display = "Moonkin Form Elemental Oath";

            Value = 5;

            this.InitCheckBox();
        }

        public override int Modify()
        {
            Player.Instance.CriticalChance = Player.Instance.CriticalChance + Value;
            if (Player.Instance.CriticalChance > 100)
            {
                Player.Instance.CriticalChance = 100;
            }

            return (int)Player.Instance.CriticalChance;
        }
    }
}
