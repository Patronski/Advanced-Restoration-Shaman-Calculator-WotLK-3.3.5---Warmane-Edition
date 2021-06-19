using App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            richTextBoxInfo.LoadFile("../../../Resourses/HELP.rtf");
        }
    }
}
