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

        private static readonly Lazy<Player> lazyInstance = new Lazy<Player>(() => new Player());

        public static Player Instance { get 
            { return lazyInstance.Value; } } // thread safe

        public int SpellPower { get; set; }

        public int EmeraldVigorNumber { get; set; }

        public int? HasteRating { get; set; }

        public double? HastePercent 
        { 
            get
            {
                if (HasteRating == null)
                {
                    return null;
                }
                var percent = Math.Round((double)HasteRating / 32.79, 2);
                return percent;
            }
        }

        public double CriticalChance { get; set; }

        public bool IsEquipedMetagemForCrit { get; set; }

        public int? HitFrom { get; set; }

        public int? HitTo { get; set; }
    }
}
