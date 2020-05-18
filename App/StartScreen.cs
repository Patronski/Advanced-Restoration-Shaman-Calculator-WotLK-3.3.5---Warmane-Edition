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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTier10_Click(object sender, EventArgs e)
        {
            var location = this.DesktopLocation;

            this.Hide();
            var calculator = new Calculator();
            calculator.DesktopLocation = location;
            calculator.ShowDialog();
            this.Close();
        }
    }
}
