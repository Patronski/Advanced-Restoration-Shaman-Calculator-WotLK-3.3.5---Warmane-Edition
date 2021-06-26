using App.Properties;
using System.Windows.Forms;

namespace App
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();

            richTextBoxChangelog.Dock = DockStyle.Fill;

            richTextBoxChangelog.Rtf = Resources.Changelog;
        }
    }
}
