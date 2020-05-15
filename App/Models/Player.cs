using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Player
    {
        private Player() { }

        private static Player instance = null;
        private static readonly object padlock = new object();

        public static Player Instance 
        { 
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Player();
                    return instance;
                }
            }
        }

        public int SpellPower { get; set; }

        public bool IsEquipedMetagemForCrit { get; set; }
    }
}
