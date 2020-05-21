using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public sealed class Player
    {
        private Player() { }

        private static readonly Lazy<Player> lazyInstance = new Lazy<Player>();

        public static Player Instance { get 
            { return lazyInstance.Value; } } // thread safe

        public int SpellPower { get; set; }

        public int Hit { get; set; }

        public int HasteRating { get; set; }

        public double HastePercent { 
            get
            {
                return Math.Round(HasteRating / 32.79);
            }
        }

        public double CriticalChance { get; set; }

        public bool IsEquipedMetagemForCrit { get; set; }
    }
}
