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

        public static Player Instance { get { return lazyInstance.Value; } } // thread safe

        public void Recalculate() 
        {
            Player.Instance.HasteRating = Player.Instance.HasteRating;
            Player.Instance.CriticalChance = Player.Instance.CriticalChanceInitial;
        }
        public int SpellPower { get; set; }

        public int EmeraldVigorNumber { get; set; }

        private int? hasteRating;
        public int? HasteRating 
        { 
            get 
            {
                return hasteRating;
            } 
            set
            {
                hasteRating = value;
                if (value != null)
                {
                    HastePercent = Math.Round((double)value / 32.79, 2);
                }
            }
        }

        public double? HastePercent { get; set; }

        public double? CriticalChance { get; set; }
        private double? criticalChanceInitial;
        public bool IsCritModified { get; set; }

        public double? CriticalChanceInitial
        {
            get
            {
                return criticalChanceInitial;
            }
            set
            {
                criticalChanceInitial = value;
                CriticalChance = value;
            }
        }

        public decimal CastingTime { get; set; }

        public bool IsEquipedMetagemForCrit { get; set; }

        public int? HitFrom { get; set; }

        public int? HitTo { get; set; }
    }
}
