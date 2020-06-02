using App.Models;
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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            InitialiseTooltips();
        }

        private void InitialiseTooltips()
        {
            CustomTooltipEasy myToolTip = new CustomTooltipEasy();

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;

            //myToolTip.SetToolTip(, "Tooltip");
            //.Tag = Resources.Tree_of_Life;
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
