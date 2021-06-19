using App.Models;
using App.Models.Totems;
using App.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace App
{
    public partial class Calculator : Form
    {
        private List<CheckBox> checkBoxes;
        private CustomSoundPlayer soundPlayer = new CustomSoundPlayer();

        private Spell selectedSpell;
        public bool skipEventChanged;
        private CustomTooltipEasy myToolTip = new CustomTooltipEasy();

        public Calculator()
        {
            InitializeComponent();
            AdjustComponentProperties();
            AddControllsToList();
            InitialiseComboBoxSpell();
            InitialiseComboBoxFireTotems();
            InitialiseComboBoxWaterTotems();
            InitialiseComboBoxEarthTotems();
            InitialiseComboBoxAirTotems();
            AddTooltips();
            LoadControlsFromMemory();
            DisplayHealing();
        }

        private void LoadControlsFromMemory()
        {
            foreach (var mod in Player.Instance.Modifiers)
            {
                if (mod.Value == true)
                {
                    var checkbox = checkBoxes.FirstOrDefault(x => x.Text == mod.Key);
                    skipEventChanged = true;
                    checkbox.Checked = true;
                }
                if (mod.Key == Constants.ModEmeraldVigor)
                {
                    if (this.numericUpDownEmeraldVigor.Value != Player.Instance.EmeraldVigorNumber)
                    {
                        skipEventChanged = true;
                        this.numericUpDownEmeraldVigor.Value = Player.Instance.EmeraldVigorNumber;
                    }
                }
            }
        }

        private void AddTooltips()
        {
            var toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
            toolTip.ReshowDelay = 50;
            toolTip.AutoPopDelay = 15000;
            toolTip.SetToolTip(pictureBoxHome, "Home");
            toolTip.SetToolTip(pictureBoxInfo, "Info");
            toolTip.SetToolTip(pictureBoxReset, "Reset");
            toolTip.SetToolTip(pictureBoxSound, "Sound");

            myToolTip.SetToolTip(checkBox2PT8Bonus, "mod");
            checkBox2PT8Bonus.Tag = Resources._2pT8_Bonus;

            myToolTip.SetToolTip(checkBox2PT9Bonus, "mod");
            checkBox2PT9Bonus.Tag = Resources._2pT9_Bonus;

            myToolTip.SetToolTip(checkBox4PT8Bonus, "mod");
            checkBox4PT8Bonus.Tag = Resources._4pT8_Bonus;

            myToolTip.SetToolTip(checkBox4PT9Bonus, "mod");
            checkBox4PT9Bonus.Tag = Resources._4pT9_Bonus;

            myToolTip.SetToolTip(checkBoxSteamcallersTotem, "mod");
            checkBoxSteamcallersTotem.Tag = Resources.ST;

            myToolTip.SetToolTip(checkBoxTreeOfLife, "Tree of life");
            checkBoxTreeOfLife.Tag = Resources.Tree_of_Life;

            myToolTip.SetToolTip(checkBoxHellscream, "checkBoxHellscream");
            checkBoxHellscream.Tag = Resources.Hellscream_s_Warsong;

            myToolTip.SetToolTip(labelEmeraldVigor, "labelEmeraldVigor");
            labelEmeraldVigor.Tag = Resources.Emerald_Vigor;

            myToolTip.SetToolTip(checkBoxEmeraldVigor, "some name");
            checkBoxEmeraldVigor.Tag = Resources.Emerald_Vigor;

            myToolTip.SetToolTip(checkBoxRiptidesConsumption, "some name");
            checkBoxRiptidesConsumption.Tag = Resources.Riptide_s_consumption;

            myToolTip.SetToolTip(checkBoxGlyphOfEarthShield, "some name");
            checkBoxGlyphOfEarthShield.Tag = Resources.Glyph_of_Earth_Shield;

            myToolTip.SetToolTip(checkBoxGyphOfHST, "some name");
            checkBoxGyphOfHST.Tag = Resources.Glyph_of_Healing_Stream_Totem;

            myToolTip.SetToolTip(checkBoxGlyphOfLHW, "some name");
            checkBoxGlyphOfLHW.Tag = Resources.Glyph_of_Lesser_Healing_Wave;

            myToolTip.SetToolTip(checkBoxWrathOfTheAirTotem, "some name");
            checkBoxWrathOfTheAirTotem.Tag = Resources.Wrath_of_Air_Totem;

            myToolTip.SetToolTip(checkBoxSwiftRetributionHaste, "some name");
            checkBoxSwiftRetributionHaste.Tag = Resources.Improved_Moonkin_Form;

            myToolTip.SetToolTip(checkBoxBloodlust, "some name");
            checkBoxBloodlust.Tag = Resources.Bloodlust;

            myToolTip.SetToolTip(checkBox2PT10Bonus, "some name");
            checkBox2PT10Bonus.Tag = Resources._2P_T10;

            myToolTip.SetToolTip(checkBoxTidalWaves, "some name");
            checkBoxTidalWaves.Tag = Resources.Tidal_Waves__Haste_;

            myToolTip.SetToolTip(checkBoxMoonkinForm, "some name");
            checkBoxMoonkinForm.Tag = Resources.Moonkin_Aura;

            myToolTip.SetToolTip(checkBoxTidalWavesCrit, "some name");
            checkBoxTidalWavesCrit.Tag = Resources.Tidal_Waves__Critical_;

            myToolTip.SetToolTip(checkBoxGlyphChainHeal, "some name");
            checkBoxGlyphChainHeal.Tag = Resources.Glyph_of_Chain_Heal;

            myToolTip.SetToolTip(checkBoxGlyphOfEarthliving, "some name");
            checkBoxGlyphOfEarthliving.Tag = Resources.Glyph_of_Earthliving_Weapon;

            myToolTip.SetToolTip(checkBoxGlyphOfRiptide, "some name");
            checkBoxGlyphOfRiptide.Tag = Resources.Glyph_of_Riptide;

            myToolTip.SetToolTip(checkBoxMetaRevitalizingSkyflareDiamond, "some name");
            checkBoxMetaRevitalizingSkyflareDiamond.Tag = Resources.Revitalizing_Skyflare_Diamond;

            myToolTip.SetToolTip(labelChainedHeal1, "some name");
            labelChainedHeal1.Tag = Resources.Chained_Heal;

            myToolTip.SetToolTip(labelChainedHeal2, "some name");
            labelChainedHeal2.Tag = Resources.Chained_Heal;

            myToolTip.SetToolTip(checkBoxGlyphOfHealingWave, "some name");
            checkBoxGlyphOfHealingWave.Tag = Resources.Glyph_of_Healing_Wave;

            myToolTip.SetToolTip(checkBox4PT7Bonus, "mod");
            checkBox4PT7Bonus.Tag = Resources._4P_T7;

            myToolTip.SetToolTip(checkBox2PT7Bonus, "mod");
            checkBox2PT7Bonus.Tag = Resources._2P_T7;

            myToolTip.SetToolTip(checkBox4PT10Bonus, "mod");
            checkBox4PT10Bonus.Tag = Resources._4P_T10;

            myToolTip.SetToolTip(checkBoxBerserking, "mod");
            checkBoxBerserking.Tag = Resources.Berserking;

            myToolTip.SetToolTip(checkBoxGlyphOfManaTideTotem, "mod");
            checkBoxGlyphOfManaTideTotem.Tag = Resources.Mana_Tide_TotemH;

            myToolTip.SetToolTip(checkBoxMetaInsightfulEarthsiegeDiamond, "mod");
            checkBoxMetaInsightfulEarthsiegeDiamond.Tag = Resources.IED;

            myToolTip.SetToolTip(checkBoxTotemOfForestGrowth, "mod");
            checkBoxTotemOfForestGrowth.Tag = Resources.Totem_of_Forest_Growth;

            myToolTip.SetToolTip(checkBoxTotemOfMisery, "mod");
            checkBoxTotemOfMisery.Tag = Resources.Totem_of_Misery;

            myToolTip.SetToolTip(checkBoxTotemOfTheBay, "mod");
            checkBoxTotemOfTheBay.Tag = Resources.Totem_of_the_Bay;

            myToolTip.SetToolTip(labelMp5Totems, "mod");
            labelMp5Totems.Tag = Resources.MTT;

            myToolTip.SetToolTip(labelMp5Innervates, "mod");
            labelMp5Innervates.Tag = Resources.Innervate;

            myToolTip.SetToolTip(labelMp5Replenish, "mod");
            labelMp5Replenish.Tag = Resources.Replenishment;

            myToolTip.SetToolTip(labelMp5InsightfulEarthsiegeDiamond, "mod");
            labelMp5InsightfulEarthsiegeDiamond.Tag = Resources.IED;

            myToolTip.SetToolTip(labelGlyphOfHealingWave, "mod");
            labelGlyphOfHealingWave.Tag = Resources.Glyph_of_Healing_Wave;

            myToolTip.SetToolTip(labelMp5TotemicRecall, "mod");
            labelMp5TotemicRecall.Tag = Resources.Totemic_Recall;
        }

        private void AdjustComponentProperties()
        {
            this.checkBoxBloodlust.Text = Constants.ModBloodlust;
            this.checkBoxEmeraldVigor.Text = Constants.ModEmeraldVigor;
            this.checkBoxGlyphOfEarthShield.Text = Constants.ModGlyphESH;
            this.checkBoxGlyphOfLHW.Text = Constants.ModGlyphLHW;
            this.checkBoxGyphOfHST.Text = Constants.ModGlyphHST;
            this.checkBoxHellscream.Text = Constants.ModHellscream;
            this.checkBoxMoonkinForm.Text = Constants.ModMoonkin;
            this.checkBox2PT10Bonus.Text = Constants.Mod2PT10Bonus_RapidCurrents;
            this.checkBoxRiptidesConsumption.Text = Constants.ModRapidConsumption;
            this.checkBoxSwiftRetributionHaste.Text = Constants.ModSwiftRetrubution;
            this.checkBoxTidalWaves.Text = Constants.ModTidalWavesHaste;
            this.checkBoxTidalWavesCrit.Text = Constants.ModTidalWavesCrit;
            this.checkBoxTreeOfLife.Text = Constants.ModTreeOfLife;
            this.checkBoxWrathOfTheAirTotem.Text = Constants.ModWrathOfTheAirTotem;
            pictureBoxSpellEarthliving.Image = Resources.SpellEarthliving;
            if (Player.Instance.MuteSound)
            {
                pictureBoxSound.Image = Resources.Sound_off;
            }
            else
            {
                pictureBoxSound.Image = Resources.Sound_on;
            }
            pictureBoxHome.Image = Resources.home;
            pictureBoxInfo.Image = Resources.help;
            pictureBoxReset.Image = Resources.reset;
        }

        private void AddControllsToList()
        {
            checkBoxes = new List<CheckBox>();

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    checkBoxes.Add(c as CheckBox);
                }
            }
        }

        private void InitialiseComboBoxSpell()
        {
            var spellType = typeof(Spell);
            var spellTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t != spellType && spellType.IsAssignableFrom(t))
                .ToList();

            var spells = new List<Spell>();

            foreach (var type in spellTypes)
            {
                if (type.IsSubclassOf(spellType))
                {
                    var instance = (Spell)Activator.CreateInstance(type);
                    spells.Add(instance);
                }
            }

            this.comboBoxSpell.Items.AddRange(spells.ToArray());
        }

        private void InitialiseComboBoxAirTotems()
        {
            comboBoxAirTotems.Items.Add(new Totem { Name = "Wrath of Air Totem", Mana = 483 });
            comboBoxAirTotems.Items.Add(new Totem { Name = "Windfury Totem", Mana = 483 });
            comboBoxAirTotems.Items.Add(new Totem { Name = "Nature Resistance Totem", Mana = 351 });
            comboBoxAirTotems.Items.Add(new Totem { Name = "None", Mana = 0 });
        }

        private void InitialiseComboBoxEarthTotems()
        {
            comboBoxEarthTotems.Items.Add(new Totem { Name = "Strength of Earth Totem", Mana = 439 });
            comboBoxEarthTotems.Items.Add(new Totem { Name = "Stoneskin Totem", Mana = 439 });
            comboBoxEarthTotems.Items.Add(new Totem { Name = "None", Mana = 0 });
        }

        private void InitialiseComboBoxWaterTotems()
        {
            comboBoxWaterTotems.Items.Add(new Totem { Name = "Healing Stream Totem", Mana = 131 });
            comboBoxWaterTotems.Items.Add(new Totem { Name = "Mana Spring Totem", Mana = 175 });
            comboBoxWaterTotems.Items.Add(new Totem { Name = "Fire Resistance Totem", Mana = 351 });
            comboBoxWaterTotems.Items.Add(new Totem { Name = "Cleansing Totem", Mana = 351 });
            comboBoxWaterTotems.Items.Add(new Totem { Name = "None", Mana = 0 });
        }

        private void InitialiseComboBoxFireTotems()
        {
            comboBoxFireTotems.Items.Add(new Totem { Name = "Flametongue Totem", Mana = 483 });
            comboBoxFireTotems.Items.Add(new Totem { Name = "Frost Resistance Totem", Mana = 351 });
            comboBoxFireTotems.Items.Add(new Totem { Name = "None", Mana = 0 });
        }

        private void textBoxSpellPower_TextChanged(object sender, EventArgs e)
        {
            int spellPower = 0;
            if (!int.TryParse(this.textBoxSpellPower.Text, out spellPower))
            {
                this.textBoxSpellPower.Text = "";
            }
            Player.Instance.SpellPower = spellPower;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
            }

            DisplayHealing();
        }

        private void textBoxHaste_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxHasteRating.Text, out value))
            {
                this.textBoxHasteRating.Text = "";
            }
            if (value > 3000)
            {
                value = 3000;
                this.textBoxHasteRating.Text = "3000";
            }
            Player.Instance.HasteRating = value;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
            }
            DisplayHealing();
        }

        // After choosing a Spell
        private void comboBoxSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSpell = (Spell)comboBoxSpell.SelectedItem;

            SelectSpellImage(selectedSpell);

            soundPlayer.PlaySound(selectedSpell.Name);

            //selectedSpell.EnableDisableModifiers(checkBoxes);
            EnableControllsAtStart();
            EnableDisableControlls();

            HideShowControlls(selectedSpell);

            var checkedModifiers = GetTextOfCheckedModifiers();
            selectedSpell.CheckModifiers(checkedModifiers);

            selectedSpell.Calculate();

            DisplayHealing();
        }

        private void EnableControllsAtStart()
        {
            foreach (var check in checkBoxes)
            {
                check.Enabled = true;
            }
        }

        private void SelectSpellImage(Spell selectedSpell)
        {
            switch (selectedSpell.Name)
            {
                case Constants.SpellChainHeal:
                    pictureBoxSpell.Image = Resources.SpellCHain_Heal;
                    break;

                case Constants.SpellEarthliving:
                    pictureBoxSpell.Image = Resources.SpellEarthliving;
                    break;

                case Constants.SpellESh:
                    pictureBoxSpell.Image = Resources.SpellEarth_Shield;
                    break;

                case Constants.SpellHST:
                    pictureBoxSpell.Image = Resources.SpellHealing_Stream_Totem;
                    break;

                case Constants.SpellHW:
                    pictureBoxSpell.Image = Resources.SpellHealing_Wave;
                    break;

                case Constants.SpellLHW:
                    pictureBoxSpell.Image = Resources.SpellLesser_Healing_Wave;
                    break;

                case Constants.SpellRiptide:
                    pictureBoxSpell.Image = Resources.SpellRiptide;
                    break;

                case Constants.SpellCritIntoMP5S:
                    pictureBoxSpell.Image = Resources.WSh;
                    break;

                case Constants.SpellGiftOfTheNaaru:
                    pictureBoxSpell.Image = Resources.GotNPicture;
                    break;

                default:
                    break;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox && !skipEventChanged)
            {
                var check = sender as CheckBox;
                if (check.Text == Constants.ModEmeraldVigor)
                {
                    if (check.Checked)
                    {
                        numericUpDownEmeraldVigor.Enabled = true;
                    }
                    else
                    {
                        numericUpDownEmeraldVigor.Enabled = false;
                    }
                    Player.Instance.EmeraldVigorNumber = (int)numericUpDownEmeraldVigor.Value;
                }

                Player.Instance.Modifiers[check.Text] = check.Checked;
                CheckConnectedControlls(check.Text, check.Checked);

                selectedSpell?.CalculateOnModifierChange(check.Text, check.Checked);

                DisplayOnGlyphOfHealingWave();
                EnableDisableControlls();
                DisplayHealing();
            }

            skipEventChanged = false;
        }

        private void CheckConnectedControlls(string controlName, bool isChecked)
        {
            if (controlName == Constants.ModGlyphOfChainHeal)
            {
                skipEventChanged = true;
                this.checkBoxGlyphChainHeal.Checked = isChecked;
            }
        }

        private void DisplayOnGlyphOfHealingWave()
        {
            if (checkBoxGlyphOfHealingWave.Checked)
            {
                this.labelAvgGlyphOfHealingWave.Enabled = true;
                textBoxGlyphOfHealingWave.Enabled = true;
                labelGlyphOfHealingWave.Enabled = true;
            }
            else
            {
                this.labelAvgGlyphOfHealingWave.Enabled = false;
                textBoxGlyphOfHealingWave.Enabled = false;
                labelGlyphOfHealingWave.Enabled = false;
            }
        }

        private void numericUpDownEmeraldVigor_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.EmeraldVigorNumber = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private List<string> GetTextOfCheckedModifiers()
        {
            var result = new List<string>();
            foreach (var check in checkBoxes)
            {
                if (check.Enabled && check.Checked)
                {
                    result.Add(check.Text);
                }
            }
            return result;
        }

        private void textBoxOnlyIntegers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxSound_MouseClick(object sender, MouseEventArgs e)
        {
            if (Player.Instance.MuteSound)
            {
                Player.Instance.MuteSound = false;
                pictureBoxSound.Image = Resources.Sound_on;
            }
            else
            {
                Player.Instance.MuteSound = true;
                pictureBoxSound.Image = Resources.Sound_off;
                soundPlayer.StopSound();
            }
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Forms.Instance.FormStartScreen.Close();
        }

        private void textBoxMP5TimeSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ob = (TextBoxBase)sender;
            ;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            var text = (string)sender.GetType().GetProperty("Text").GetValue(sender);

            if (text != null && char.IsDigit(e.KeyChar) && int.Parse(text + e.KeyChar) > 59 && ob.SelectedText != text)
            {
                e.Handled = true;
            }
        }

        private void textBoxMP5TimeMin_TextChanged(object sender, EventArgs e)
        {
            int timeMin = 0;
            if (!int.TryParse(this.textBoxMP5TimeMin.Text, out timeMin))
            {
                this.textBoxMP5TimeMin.Text = "";
            }
            Player.Instance.Mp5TimeMin = timeMin;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
            }

            DisplayHealing();
        }

        private void textBoxMP5TimeSec_TextChanged(object sender, EventArgs e)
        {
            int timeSec = 0;
            if (!int.TryParse(this.textBoxMP5TimeSec.Text, out timeSec))
            {
                this.textBoxMP5TimeSec.Text = "";
            }
            Player.Instance.Mp5TimeSec = timeSec;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
            }

            DisplayHealing();
        }

        private void textBoxMP5TotalRiptides_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (!int.TryParse(this.textBoxMP5TotalRiptides.Text, out num))
            {
                this.textBoxMP5TotalRiptides.Text = "";
            }
            Player.Instance.Mp5TotalRiptides = num;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
            }

            DisplayHealing();
        }

        private void textBoxMP5TotalHW_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMP5TotalHW.Text, out value))
            {
                this.textBoxMP5TotalHW.Text = "";
            }
            Player.Instance.Mp5TotalHW = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void textBoxMP5TotalLHW_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMP5TotalLHW.Text, out value))
            {
                this.textBoxMP5TotalLHW.Text = "";
            }
            Player.Instance.Mp5TotalLHW = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void textBoxMP5TotalCH_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMP5TotalCH.Text, out value))
            {
                this.textBoxMP5TotalCH.Text = "";
            }
            Player.Instance.Mp5TotalCH = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void textBoxIntellect_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxIntellect.Text, out value))
            {
                this.textBoxIntellect.Text = "";
            }
            if (value > 3500)
            {
                value = 3500;
                this.textBoxIntellect.Text = "3500";
            }
            Player.Instance.Intellect = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void textBoxCriticalRating_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxCriticalRating.Text, out value))
            {
                this.textBoxCriticalRating.Text = "";
            }
            if (value > 2200)
            {
                value = 2200;
                this.textBoxCriticalRating.Text = "2200";
            }
            Player.Instance.CriticalRating = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void textBoxMana_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMana.Text, out value))
            {
                this.textBoxMana.Text = "";
            }
            Player.Instance.Mana = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void textBoxMP5S_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMP5S.Text, out value))
            {
                this.textBoxMP5S.Text = "";
            }
            Player.Instance.MP5S = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void numericUpDownMp5Totems_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5TotemsCount = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void numericUpDownMp5Inervates_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5InnervatesCount = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void numericUpDownReplenish_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5ReplenishCount = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            var location = this.DesktopLocation;

            var startScreen = Forms.Instance.FormStartScreen;
            startScreen.DesktopLocation = location;
            startScreen.Show();
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            var location = this.DesktopLocation;

            if (Forms.Instance.FormInfo == null || Forms.Instance.FormInfo.IsDisposed)
            {
                Forms.Instance.FormInfo = new Info();
            }

            Forms.Instance.FormInfo.DesktopLocation = location;
            Forms.Instance.FormInfo.Show();
        }

        private void pictureBoxReset_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBoxes)
            {
                if (item.Name == "checkBoxMuteSound") continue;
                item.Checked = false;
            }

            // reset base stats
            this.textBoxSpellPower.Text = "";
            this.textBoxIntellect.Text = "";
            this.textBoxMP5S.Text = "";
            textBoxHasteRating.Text = "";
            Player.Instance.CriticalPercentInitial = 0;
            textBoxCriticalRating.Text = "";

            // reset controlls for spell MP5S
            textBoxMP5TimeMin.Text = "";
            textBoxMP5TimeSec.Text = "";
            textBoxMP5TotalRiptides.Text = "";
            textBoxMP5TotalHW.Text = "";
            textBoxMP5TotalLHW.Text = "";
            textBoxMP5TotalCH.Text = "";
            numericUpDownMp5Totems.Value = 0;
            numericUpDownMp5Inervates.Value = 0;
            numericUpDownMp5Replenish.Value = 0;
        }

        private void textBoxMp5TotalCHCasts_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMp5TotalCHCasts.Text, out value))
            {
                this.textBoxMp5TotalCHCasts.Text = "";
            }
            Player.Instance.Mp5TotalCHCasts = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void numericUpDownMp5BloodlustHeroism_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5BloodlustHeroism = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void textBoxMp5TotalESHCasts_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxMp5TotalESHCasts.Text, out value))
            {
                this.textBoxMp5TotalESHCasts.Text = "";
            }
            Player.Instance.Mp5TotalESHCasts = value;

            selectedSpell?.Calculate();

            DisplayHealing();
        }

        private void comboBoxTotems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWaterTotem = (Totem)comboBoxWaterTotems.SelectedItem;
            var selectedFireTotem = (Totem)comboBoxFireTotems.SelectedItem;
            var selectedEarthTotem = (Totem)comboBoxEarthTotems.SelectedItem;
            var selectedAirTotem = (Totem)comboBoxAirTotems.SelectedItem;

            Player.Instance.Mp5SelectedTotemTotalMana = 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedAirTotem?.Mana ?? 0 ;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedEarthTotem?.Mana ?? 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedFireTotem?.Mana ?? 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedWaterTotem?.Mana ?? 0;

            selectedSpell.Calculate();

            DisplayHealing();
        }

        private void numericUpDownCallOfElements_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5CallOfElements = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void numericUpDownMp5TotemicRecall_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5TotemicRecall = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }
    }
}