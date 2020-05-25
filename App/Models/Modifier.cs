using App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models
{
    public abstract class Modifier
    {
        public Modifier()
        {
            
        }

        public double Value { get; set; }

        public string Display { get; set; }

        public string Name { get; set; }

        public bool UseExtraNumber { get; set; }

        public CheckBox CheckBox { get; set; }

        public bool IsCheckBoxChecked { get; set; }

        public abstract void Modify();

        public void InitCheckBox()
        {
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.CheckBox.Name = this.GetType().Name;
            this.CheckBox.Text = this.Display;
            this.CheckBox.AutoSize = true;
        }
    }
}
