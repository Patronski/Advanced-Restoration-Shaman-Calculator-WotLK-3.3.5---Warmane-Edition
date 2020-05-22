using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Modifiers
{
    public class EmeraldVigor : Modifier
    {

        public EmeraldVigor()
        {
            Display = "Emerald Vigor";
            UseExtraNumber = true;

            InitCheckBox();
        }

        public override int Modify()
        {
            throw new NotImplementedException();
        }
    }
}
