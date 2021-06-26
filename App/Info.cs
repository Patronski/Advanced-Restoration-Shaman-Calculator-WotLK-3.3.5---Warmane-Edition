using App.Properties;
using System.Windows.Forms;

namespace App
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            richTextBoxInfo.Dock = DockStyle.Fill;

            richTextBoxInfo.Rtf = Resources.HELP_rtf;
        }
    }
}
