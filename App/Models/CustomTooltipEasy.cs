using System.Drawing;
using System.Windows.Forms;

namespace App.Models
{
    public class CustomTooltipEasy : ToolTip
    {
        public CustomTooltipEasy()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);

            this.InitialDelay = 20;
            this.ReshowDelay = 20;
            this.AutoPopDelay = 15000;
        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            var image = e.AssociatedControl.Tag as Image;
            e.ToolTipSize = image.Size;
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this to customzie the tool tip
        {
            Graphics g = e.Graphics;

            // to set the tag for each button or object
            Control parent = e.AssociatedControl;
            Image pelican = parent.Tag as Image;

            //create your own custom brush to fill the background with the image
            TextureBrush b = new TextureBrush(new Bitmap(pelican));// get the image from Tag

            g.FillRectangle(b, e.Bounds);
            b.Dispose();
        }
    }
}