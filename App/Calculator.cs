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
        private CustomTooltipForPictures myToolTip = new CustomTooltipForPictures();

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
            comboBoxAirTotems.Items.Add(new Totem { Name = Constants.AirTotemWrath, Mana = 483,
                Icon = Resources.Air_Totem_Wrath_of_Air_Totem, Tooltip = Resources.Wrath_of_Air_Totem });

            comboBoxAirTotems.Items.Add(new Totem { Name = Constants.AirTotemWindfury, Mana = 483,
                Icon = Resources.Air_Totem_Windfury_Totem, Tooltip = Resources.WindfuryTotemTooltip });

            comboBoxAirTotems.Items.Add(new Totem { Name = Constants.AirTotemResistance, Mana = 351,
                Icon = Resources.Air_Totem_Nature_Resistance_Totem, Tooltip = Resources.NatureResistanceTooltip });

            comboBoxAirTotems.Items.Add(new Totem { Name = Constants.None, Mana = 0,
                Icon = null, Tooltip = null });
        }

        private void InitialiseComboBoxEarthTotems()
        {
            comboBoxEarthTotems.Items.Add(new Totem { Name = Constants.EarthTotemStrength, Mana = 439,
                Icon = Resources.EarthTotemStrength, Tooltip = Resources.EarthTotem });

            comboBoxEarthTotems.Items.Add(new Totem { Name = Constants.EarthTotemStoneskin, Mana = 439,
                Icon = Resources.EarthTotemStoneskin, Tooltip = Resources.StoneskinTotem });

            comboBoxEarthTotems.Items.Add(new Totem { Name = Constants.None, Mana = 0,
                Icon = null, Tooltip = null });
        }

        private void InitialiseComboBoxWaterTotems()
        {
            comboBoxWaterTotems.Items.Add(new Totem { Name = Constants.WaterTotemHealing, Mana = 131
                , Icon = Resources.WaterTotemHealing, Tooltip = Resources.HealingStreamTotem });

            comboBoxWaterTotems.Items.Add(new Totem { Name = Constants.WaterTotemMana, Mana = 175,
                Icon = Resources.Water_Totem_Mana_Spring_Totem, Tooltip = Resources.ManaSpringTotem });

            comboBoxWaterTotems.Items.Add(new Totem { Name = Constants.WaterTotemResistance, Mana = 351,
                Icon = Resources.Water_Totem_Fire_Resistance_Totem, Tooltip = Resources.FireResistanceTotem });

            comboBoxWaterTotems.Items.Add(new Totem { Name = Constants.WaterTotemCleansing, Mana = 351,
                Icon = Resources.Water_Totem_Cleaansing_Totem, Tooltip = Resources.CleanseSpirit });

            comboBoxWaterTotems.Items.Add(new Totem { Name = Constants.None, Mana = 0, Icon = null, Tooltip = null });
        }

        private void InitialiseComboBoxFireTotems()
        {
            comboBoxFireTotems.Items.Add(new Totem { Name = Constants.FireTotemFlametongue, Mana = 483,
                Icon = Resources.FireTotemFlametongue, Tooltip = Resources.FlametongueTotem });

            comboBoxFireTotems.Items.Add(new Totem { Name = Constants.FireTotemResistance, Mana = 351,
                Icon = Resources.FrostTotemResistance, Tooltip = Resources.FrostResistanceTotem });

            comboBoxFireTotems.Items.Add(new Totem { Name = Constants.None, Mana = 0,
                Icon = null, Tooltip = null });
        }

        private void textBoxSpellPower_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (!int.TryParse(this.textBoxSpellPower.Text, out value))
            {
                this.textBoxSpellPower.Text = "";
            }
            if (value > 10000)
            {
                value = 10000;
                this.textBoxSpellPower.Text = "10000";
            }
            Player.Instance.SpellPower = value;

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

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox && !skipEventChanged)
            {
                var check = sender as CheckBox;
                Player.Instance.Modifiers[check.Text] = check.Checked;

                AdjustEmeraldVigor(check);
                AdjustChainHeal(check);

                selectedSpell?.CalculateOnModifierChange(check.Text, check.Checked);

                DisplayOnGlyphOfHealingWave();
                EnableDisableControlls();
                DisplayHealing();
            }

            skipEventChanged = false;
        }

        private void AdjustChainHeal(CheckBox check)
        {
            if (check.Text == Constants.ModGlyphOfChainHeal)
            {
                skipEventChanged = true;
                this.checkBoxGlyphChainHeal.Checked = check.Checked;
            }
        }

        private void AdjustEmeraldVigor(CheckBox check)
        {
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
            if (value > 5000)
            {
                value = 5000;
                this.textBoxMP5S.Text = "5000";
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

            this.Hide();
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
            numericUpDownMp5TotemicRecall.Value = 0;
            textBoxMp5TotalCHCasts.Text = "";
            textBoxMp5TotalESHCasts.Text = "";
            numericUpDownMp5BloodlustHeroism.Value = 0;
            numericUpDownMp5CallOfElements.Value = 0;
            comboBoxAirTotems.SelectedIndex = -1;
            comboBoxAirTotems.Text = "Select Air Totem";
            comboBoxEarthTotems.SelectedIndex = -1;
            comboBoxEarthTotems.Text = "Select Earth Totem";
            comboBoxFireTotems.SelectedIndex = -1;
            comboBoxFireTotems.Text = "Select Fire Totem";
            comboBoxWaterTotems.SelectedIndex = -1;
            comboBoxWaterTotems.Text = "Select Water Totem";
            numericUpDownMp5Revitalize.Value = 0;
            numericUpDownMp5Rapture.Value = 0;
            numericUpDownMp5CleanseSpirit.Value = 0;
            numericUpDownMp5RunicManaPotion.Value = 0;
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
            SetWaterTotemPictures(selectedWaterTotem);
            var selectedFireTotem = (Totem)comboBoxFireTotems.SelectedItem;
            SetFireTotemPictures(selectedFireTotem);
            var selectedEarthTotem = (Totem)comboBoxEarthTotems.SelectedItem;
            SetEarthTotemPictures(selectedEarthTotem);
            var selectedAirTotem = (Totem)comboBoxAirTotems.SelectedItem;
            SetAirTotemPictures(selectedAirTotem);

            Player.Instance.Mp5SelectedTotemTotalMana = 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedAirTotem?.Mana ?? 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedEarthTotem?.Mana ?? 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedFireTotem?.Mana ?? 0;
            Player.Instance.Mp5SelectedTotemTotalMana += selectedWaterTotem?.Mana ?? 0;

            selectedSpell.Calculate();

            DisplayHealing();
        }

        private void SetWaterTotemPictures(Totem totem)
        {
            pictureBoxWaterTotem.Image = totem?.Icon;
            myToolTip.SetToolTip(pictureBoxWaterTotem, "mod");
            pictureBoxWaterTotem.Tag = totem?.Tooltip;
            if (totem?.Tooltip == null)
            {
                myToolTip.SetToolTip(pictureBoxWaterTotem, "");
            }
        }

        private void SetFireTotemPictures(Totem totem)
        {
            pictureBoxFireTotem.Image = totem?.Icon;
            myToolTip.SetToolTip(pictureBoxFireTotem, "mod");
            pictureBoxFireTotem.Tag = totem?.Tooltip;
            if (totem?.Tooltip == null)
            {
                myToolTip.SetToolTip(pictureBoxFireTotem, "");
            }
        }

        private void SetEarthTotemPictures(Totem totem)
        {
            pictureBoxEarthTotem.Image = totem?.Icon;
            myToolTip.SetToolTip(pictureBoxEarthTotem, "mod");
            pictureBoxEarthTotem.Tag = totem?.Tooltip;
            if (totem?.Tooltip == null)
            {
                myToolTip.SetToolTip(pictureBoxEarthTotem, "");
            }
        }

        private void SetAirTotemPictures(Totem totem)
        {
            pictureBoxAirTotem.Image = totem?.Icon;
            myToolTip.SetToolTip(pictureBoxAirTotem, "mod");
            pictureBoxAirTotem.Tag = totem?.Tooltip;
            if (totem?.Tooltip == null)
            {
                myToolTip.SetToolTip(pictureBoxAirTotem, "");
            }
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

        private void numericUpDownMp5Revitalize_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5RevitalizeTicks = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void numericUpDownMp5Rapture_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5RaptureProcs = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void numericUpDownMp5CleanseSpirit_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5CleanseSpirit = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void checkBoxMp5RunicManaInjector_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox && !skipEventChanged)
            {
                var check = sender as CheckBox;
                Player.Instance.Mp5RunicManaInjector = check.Checked;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void numericUpDownMp5RunicManaPotion_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.Mp5RunicManaPotion = number;
                selectedSpell?.Calculate();
                DisplayHealing();
            }
            skipEventChanged = false;
        }
    }
}