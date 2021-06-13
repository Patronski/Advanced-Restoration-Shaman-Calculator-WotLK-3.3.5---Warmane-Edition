using System;
using System.Collections.Generic;

namespace App.Models
{
    /// <summary>
    /// Purpose of this singleton class is development to be easy, to act as database between forms.
    /// </summary>
    public sealed class Player
    {
        public List<string> ModifierNames;
        public Dictionary<string, bool> Modifiers { get; set; }

        public bool MuteSound { get; set; }

        private static readonly Lazy<Player> lazyInstance = new Lazy<Player>(() => new Player());
        public static Player Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        private Player() 
         {
            Modifiers = new Dictionary<string, bool>();
            ModifierNames = new List<string>();
        }

        public void Recalculate() 
        {
            CriticalMultiplier = Constants.BaseCriticalMultiplier;
            Instance.HasteRating = Instance.HasteRating; // reseting HastePercent
            Instance.CriticalRating = Instance.criticalRating;
        }

        public int SpellPower { get; set; }
        private int intellect;
        public int Intellect 
        {
            get { return intellect; }
            set 
            { 
                intellect = value; 
                Mana = Constants.BaseMana + intellect * 15;
                CriticalPercent = CalculateCriticalPercent();
            }
        }
        public int Mana { get; set; } = Constants.BaseMana;
        public int MP5S { get; set; }

        public int EmeraldVigorNumber { get; set; }

        private int hasteRating;
        public int HasteRating 
        { 
            get { return hasteRating; } 
            set
            {
                hasteRating = value;
                HastePercent = hasteRating != 0 ? hasteRating / 32.79 : 0;
            }
        }

        private double hastePercent;
        public double HastePercent 
        {
            get { return hastePercent; } 
            set { hastePercent = Math.Round(value, 2, MidpointRounding.ToEven); }
        }

        private int criticalRating = 0;
        public int CriticalRating 
        {
            get { return criticalRating; }
            set
            {
                criticalRating = value;
                CriticalPercent = CalculateCriticalPercent();
                CriticalPercentInitial = CriticalPercent;
            } 
        }

        private double CalculateCriticalPercent()
        {
            var percent = Math.Floor(criticalRating / 45.91 * 100) / 100 + Constants.BaseCriticalPercent + (Math.Floor(Intellect / 166.6667 * 100) / 100);
            return percent > 100 ? 100 : percent;
        }

        public double CriticalPercent { get; set; } = Constants.BaseCriticalPercent;

        private double criticalPercentInitial;
        public double CriticalPercentInitial
        {
            get
            {
                return criticalPercentInitial;
            }
            set
            {
                criticalPercentInitial = value;
                CriticalPercent = value;
            }
        }

        public double CriticalMultiplier { get; set; } = Constants.BaseCriticalMultiplier;

        public bool isCritModified;

        public double? CastingTime { get; set; }

        public int? AvgHps { get; set; }

        public int? AvgHotHps { get; set; }

        public int? AvgHpm { get; set; }

        public int? AvgAAHps { get; set; }

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
        public int? HotRiptide { get; set; }

        public int? AncestralAwaceningFrom { get; set; }
        public int? AncestralAwaceningTo { get; set; }
        public int? AncestralAwaceningAvg { get; set; }

        public int? AvgGlyphOfHealingWave { get; set; }

        public int? EarthlivingAvgHpsCH { get; set; }
        public int? EarthlivingAvgHpsHW { get; set; }
        public int? EarthlivingAvgHpsLHW { get; set; }
        public int? EarthlivingAvgHpsRP { get; set; }
        public int? EarthlivingAvgHpsTotal { get; set; }

        public int? Mp5TimeMin { get; set; }
        public int? Mp5TimeSec { get; set; }
        public double? Mp5TimeDec { get; set; }
        public int? Mp5TotalRiptides { get; set; }
        public int? Mp5TotalHW { get; set; }
        public int? Mp5TotalLHW { get; set; }
        public int? Mp5TotalCH { get; set; }
        public double? Mp5RPM { get; set; }
        public double? Mp5HWPM { get; set; }
        public double? Mp5LHWPM { get; set; }
        public double? Mp5CHPM { get; set; }
        public double? Mp5Crit { get; set; }
        public double? Mp5Percent { get; set; }
        public double? Mp5TotalCrit { get; set; }
        public double Mp5Totems { get; set; }
        public int Mp5TotemsCount { get; set; }
        public int Mp5InnervatesCount { get; set; }
        public double Mp5Innervates { get; set; }
        public double Mp5ReplenishCount { get; set; }
        public double Mp5Replenish { get; set; }
        public int Mp5Diamond { get; set; }
    }
}
