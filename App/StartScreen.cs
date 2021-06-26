using App.Models;
using App.Properties;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            Text = Constants.ProgramName;
            soundPlayer.PlaySound("on");

            InitialiseTooltips();
            var cur = new Cursor(Resources.wow_cursor_hand_croped.GetHicon());
            this.Cursor = cur;
            buttonTier10.Cursor = cur;
            textBox3.Cursor = cur;
            buttonVersion.Cursor = cur;
        }

        private CustomSoundPlayer soundPlayer = new CustomSoundPlayer();

        private void InitialiseTooltips()
        {
            //var toolTip = new ToolTip();
            //toolTip.InitialDelay = 50;
            //toolTip.ReshowDelay = 50;
            //toolTip.AutoPopDelay = 15000;
            //toolTip.SetToolTip(pictureBox5, "Statistic");
            //toolTip.SetToolTip(pictureBox4, "Download");
            //toolTip.SetToolTip(pictureBox1, "Restoration Shaman Guide");
            //toolTip.SetToolTip(pictureBox3, "Warmane Home");

            CustomTooltipForPictures myToolTip = new CustomTooltipForPictures();

            myToolTip.InitialDelay = 50;
            myToolTip.ReshowDelay = 50;

            myToolTip.SetToolTip(transparentControl2, "Tooltip");
            transparentControl2.Tag = Resources.Ancestral_KnowledgeH;

            myToolTip.SetToolTip(transparentControl1, "Tooltip");
            transparentControl1.Tag = Resources.Thundering_StrikesH;

            myToolTip.SetToolTip(transparentControl3, "Tooltip");
            transparentControl3.Tag = Resources.Improved_ShieldsH;

            myToolTip.SetToolTip(transparentControl4, "Tooltip");
            transparentControl4.Tag = Resources.Improved_Healing_WaveH;

            myToolTip.SetToolTip(transparentControl7, "Tooltip");
            transparentControl7.Tag = Resources.Tidal_FocusH;

            myToolTip.SetToolTip(transparentControl5, "Tooltip");
            transparentControl5.Tag = Resources.Improved_Water_ShieldH;

            myToolTip.SetToolTip(transparentControl6, "Tooltip");
            transparentControl6.Tag = Resources.Healing_FocusH;

            myToolTip.SetToolTip(transparentControl8, "Tooltip");
            transparentControl8.Tag = Resources.Tidal_ForceH;

            myToolTip.SetToolTip(transparentControl9, "Tooltip");
            transparentControl9.Tag = Resources.Ancestral_HealingH;

            myToolTip.SetToolTip(transparentControl11, "Tooltip");
            transparentControl11.Tag = Resources.Restorative_TotemsH;

            myToolTip.SetToolTip(transparentControl12, "Tooltip");
            transparentControl12.Tag = Resources.Tidal_MasteryH;

            myToolTip.SetToolTip(transparentControl10, "Tooltip");
            transparentControl10.Tag = Resources.Healing_WayH;

            myToolTip.SetToolTip(transparentControl13, "Tooltip");
            transparentControl13.Tag = Resources.Nature_s_SwiftnessH;

            myToolTip.SetToolTip(transparentControl14, "Tooltip");
            transparentControl14.Tag = Resources.PurificationH;

            myToolTip.SetToolTip(transparentControl15, "Tooltip");
            transparentControl15.Tag = Resources.Mana_Tide_TotemH;

            myToolTip.SetToolTip(transparentControl16, "Tooltip");
            transparentControl16.Tag = Resources.Cleanse_SpiritH;

            myToolTip.SetToolTip(transparentControl17, "Tooltip");
            transparentControl17.Tag = Resources.Blessing_of_the_EternalsH;

            myToolTip.SetToolTip(transparentControl18, "Tooltip");
            transparentControl18.Tag = Resources.Improved_Chain_HealH;

            myToolTip.SetToolTip(transparentControl19, "Tooltip");
            transparentControl19.Tag = Resources.Nature_s_BlessingH;

            myToolTip.SetToolTip(transparentControl23, "Tooltip");
            transparentControl23.Tag = Resources.Ancestral_AwakeningH;

            myToolTip.SetToolTip(transparentControl22, "Tooltip");
            transparentControl22.Tag = Resources.Earth_ShieldH;

            myToolTip.SetToolTip(transparentControl20, "Tooltip");
            transparentControl20.Tag = Resources.Improved_Earth_ShieldH;

            myToolTip.SetToolTip(transparentControl21, "Tooltip");
            transparentControl21.Tag = Resources.Tidal_WavesH;

            myToolTip.SetToolTip(transparentControl24, "Tooltip");
            transparentControl24.Tag = Resources.RiptideH;
        }

        private void buttonTier10_Click(object sender, EventArgs e)
        {
            var location = this.DesktopLocation;

            this.Hide();
            if (Forms.Instance.FormCalculator == null)
            {
                Forms.Instance.FormCalculator = new Calculator();
            }
            var calculator = Forms.Instance.FormCalculator;
            calculator.DesktopLocation = location;
            calculator.Show();
            //this.Close();
        }

        private void linkOpenSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Patronski/Advanced-Restoration-Shaman-Calculator-WotLK-3.3.5---Warmane-Edition");
        }

        private void StartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            soundPlayer.PlaySound("off");
        }

        private void buttonVersion_Click(object sender, EventArgs e)
        {
            var location = this.DesktopLocation;

            if (Forms.Instance.FormVersion == null || Forms.Instance.FormVersion.IsDisposed)
            {
                Forms.Instance.FormVersion = new FormVersion();
            }

            Forms.Instance.FormVersion.DesktopLocation = location;
            Forms.Instance.FormVersion.Show();
        }
    }
}