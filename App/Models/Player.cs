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
                    HastePercent = Math.Round((double)value / 32.79, 2, MidpointRounding.ToEven);
                }
            }
        }

        public double HastePercent { get; set; }

        public double? CriticalChance { get; set; }
        public bool IsCritModified { get; set; }

        private double? criticalChanceInitial;
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

        public bool IsEquipedMetagemForCrit { get; set; }

        public double? CastingTime { get; set; }

        public int? AvgHPS { get; set; }

        public int? AvgHOT { get; set; }

        public int? Hit1From { get; set; }
        public int? Hit2From { get; set; }
        public int? Hit3From { get; set; }
        public int? Hit4From { get; set; }

        public int? Hit1To { get; set; }
        public int? Hit2To { get; set; }
        public int? Hit3To { get; set; }
        public int? Hit4To { get; set; }

        public int? Crit1From { get; set; }
        public int? Crit2From { get; set; }
        public int? Crit3From { get; set; }
        public int? Crit4From { get; set; }
        
        public int? Crit1To { get; set; }
        public int? Crit2To { get; set; }
        public int? Crit3To { get; set; }
        public int? Crit4To { get; set; }

        public int? Hit1Avg { get; set; }
        public int? Hit2Avg { get; set; }
        public int? Hit3Avg { get; set; }
        public int? Hit4Avg { get; set; }
        
        public int? Crit1Avg { get; set; }
        public int? Crit2Avg { get; set; }
        public int? Crit3Avg { get; set; }
        public int? Crit4Avg { get; set; }
        
        public int? AvgHot1 { get; set; }
        public int? AvgHot2 { get; set; }
        public int? AvgHot3 { get; set; }
        public int? AvgHot4 { get; set; }
    }
}
