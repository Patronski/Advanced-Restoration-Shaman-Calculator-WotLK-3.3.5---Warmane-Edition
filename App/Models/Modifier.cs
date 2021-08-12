using System.Windows.Forms;

namespace App.Models
{
    public abstract class Modifier
    {
        public Modifier()
        {
        }

        public double Value { get; set; }

        public string Name { get; set; }

        public bool IsCheckBoxChecked { get; set; }

        public virtual void Modify()
        {
        }
    }
}