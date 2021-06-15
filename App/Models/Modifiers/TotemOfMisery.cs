using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Modifiers
{
    public class TotemOfMisery : Modifier
    {
        public TotemOfMisery()
        {
            Display = Constants.ModTotemOfMisery;

            this.InitCheckBox();
        }
    }
}
