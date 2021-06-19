using App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
