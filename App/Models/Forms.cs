using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public sealed class Forms
    {
        private Forms()
        {

        }

        public static Forms Instance { get; } = new Forms();

        public Calculator FormCalculator { get; set; }
        public StartScreen FormStartScreen { get; set; }
    }
}
