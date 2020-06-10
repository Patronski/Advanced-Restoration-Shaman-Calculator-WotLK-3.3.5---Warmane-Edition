using App.Models;
using App.Properties;
using CustomToolTipDemo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Calculator : Form
    {
        private List<CheckBox> checkBoxes;

        private Spell selectedSpell;
        private bool isAfterCritKeyPress;
        private bool isCritModified;
        private bool skipEventChanged;

        public Calculator()
        {
            InitializeComponent();
            AdjustComponentProperties();
            AddControllsToList();
            InitialiseComboBoxSpell();
            AddTooltips();
            LoadControlsFromPlayer();
        }

        private void LoadControlsFromPlayer()
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
            CustomTooltipEasy myToolTip = new CustomTooltipEasy();

            myToolTip.InitialDelay = 20;
            myToolTip.ReshowDelay = 20;
            myToolTip.AutoPopDelay = 15000;

            
            myToolTip.SetToolTip(checkBoxGlyphOfChainHealEarthliving, "Tree of life");
            checkBoxGlyphOfChainHealEarthliving.Tag = Resources.Glyph_of_Chain_Heal;

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

            myToolTip.SetToolTip(checkBoxRapidCurrents, "some name");
            checkBoxRapidCurrents.Tag = Resources.Rapid_Currents;

            myToolTip.SetToolTip(checkBoxTidalWaves, "some name");
            checkBoxTidalWaves.Tag = Resources.Tidal_Waves__Haste_;

            myToolTip.SetToolTip(checkBoxTidalMastery, "some name");
            checkBoxTidalMastery.Tag = Resources.Tidal_Mastery;

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

            myToolTip.SetToolTip(checkBoxRevitalizingSkyflareDiamond, "some name");
            checkBoxRevitalizingSkyflareDiamond.Tag = Resources.Revitalizing_Skyflare_Diamond;

            myToolTip.SetToolTip(labelEarthlivingBlessingOf, "some name");
            labelEarthlivingBlessingOf.Tag = Resources.Blessing_of_the_Eternals;

            myToolTip.SetToolTip(labelChainedHeal1, "some name");
            labelChainedHeal1.Tag = Resources.Chained_Heal;

            myToolTip.SetToolTip(labelChainedHeal2, "some name");
            labelChainedHeal2.Tag = Resources.Chained_Heal;

            myToolTip.SetToolTip(checkBoxGlyphOfHealingWave, "some name");
            checkBoxGlyphOfHealingWave.Tag = Resources.Glyph_of_Healing_Wave;
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
            this.checkBoxRapidCurrents.Text = Constants.ModRapidCurrents;
            this.checkBoxRiptidesConsumption.Text = Constants.ModRapidConsumption;
            this.checkBoxSwiftRetributionHaste.Text = Constants.ModSwiftRetrubution;
            this.checkBoxTidalMastery.Text = Constants.ModTidalMastery;
            this.checkBoxTidalWaves.Text = Constants.ModTidalWavesHaste;
            this.checkBoxTidalWavesCrit.Text = Constants.ModTidalWavesCrit;
            this.checkBoxTreeOfLife.Text = Constants.ModTreeOfLife;
            this.checkBoxWrathOfTheAirTotem.Text = Constants.ModWrathOfTheAirTotem;
        }

        private void AddControllsToList()
        {
            checkBoxes = new List<CheckBox>()
            {
                this.checkBoxTreeOfLife,
                this.checkBoxHellscream,
                this.checkBoxEmeraldVigor,
                this.checkBoxRiptidesConsumption,
                this.checkBoxGlyphOfEarthShield,
                this.checkBoxGyphOfHST,
                this.checkBoxGlyphOfLHW,
                this.checkBoxWrathOfTheAirTotem,
                this.checkBoxSwiftRetributionHaste,
                this.checkBoxBloodlust,
                this.checkBoxRapidCurrents,
                this.checkBoxTidalWaves,
                this.checkBoxTidalMastery,
                this.checkBoxMoonkinForm,
                this.checkBoxTidalWavesCrit,
                this.checkBoxRevitalizingSkyflareDiamond,
                this.checkBoxGlyphOfRiptide,
                checkBoxGlyphOfEarthliving,
                checkBoxGlyphChainHeal,
                checkBoxGlyphOfHealingWave,
                checkBoxMuteSound,
                this.checkBox2PT8Bonus,
                this.checkBox2PT9Bonus,
                this.checkBox4PT7Bonus,
                this.checkBox4PT8Bonus,
                this.checkBox4PT9Bonus,
                this.checkBoxSteamcallersTotem
            };
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
            int hasteRating = 0;
            if (!int.TryParse(this.textBoxHasteRating.Text, out hasteRating))
            {
                this.textBoxHasteRating.Text = "";
            }
            Player.Instance.HasteRating = hasteRating;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
            }
            DisplayHealing();
        }

        private void numericUpDownCriticalChance_ValueChanged(object sender, EventArgs e)
        {
            if (isAfterCritKeyPress && !isCritModified)
            {
                isAfterCritKeyPress = false;

                double crit = (double)this.numericUpDownCriticalChance.Value;

                selectedSpell.CalculateOnCritChanceInsert(crit);
            }

            isCritModified = false;

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
                DisplayHealing();
            }
        }

        private void comboBoxSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!labelEmeraldVigor.Enabled)
            {
                labelEmeraldVigor.Enabled = true;
            }
            labelSpellPower.Enabled = true;
            textBoxSpellPower.Enabled = true;
            labelHaste.Enabled = true;
            textBoxHasteRating.Enabled = true;
            labelArrow.Enabled = true;
            textBoxHastePercent.Enabled = true;
            labelPercent.Enabled = true;
            labelCrit.Enabled = true;
            numericUpDownCriticalChance.Enabled = true;
            labelPercentCritChance.Enabled = true;

            selectedSpell = (Spell)this.comboBoxSpell.SelectedItem;

            SelectSpellImage(selectedSpell);

            Player.Instance.PlaySound(selectedSpell.Name);

            selectedSpell.EnableDisableModifiers(checkBoxes);
            EnableDisableControlls();

            HideShowControlls(selectedSpell);

            var checkedModifiers = GetTextOfCheckedModifiers();
            selectedSpell.CheckModifiers(checkedModifiers);

            selectedSpell.Calculate();

            DisplayHealing();
        }

        private void EnableDisableControlls()
        {
            if (checkBoxEmeraldVigor.Checked == true)
            {
                this.numericUpDownEmeraldVigor.Enabled = true;
            }
            if (checkBoxGlyphOfHealingWave.Checked)
            {
                textBoxGlyphOfHealingWave.Enabled = true;
                labelAvgGlyphOfHealingWave.Enabled = true;
            }
            if (checkBoxGlyphChainHeal.Checked)
            {
                labelTarget4.Enabled = true;
                textBoxHit4From.Enabled = true;
                labelDashHit4.Enabled = true;
                textBoxHit4To.Enabled = true;
                labelArrowHit4.Enabled = true;
                textBoxHit4Avg.Enabled = true;
                textBoxCrit4From.Enabled = true;
                labelDashCrit4.Enabled = true;
                textBoxCrit4Avg.Enabled = true;
                labelArrowcCrit4.Enabled = true;
                textBoxCrit4To.Enabled = true;
                textBoxAvgHot4.Enabled = true;
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
                selectedSpell.CalculateOnModifierChange(check.Text, check.Checked);
                if (check.Text == Constants.ModTidalWavesCrit || check.Text == Constants.ModMoonkin || check.Text == Constants.ModTidalMastery)
                {
                    isCritModified = true;
                }
                DisplayOnGlyphOfHealingWave();
                DisplayOnGlyphOfChainHeal();
                DisplayHealing();
            }
            skipEventChanged = false;
        }

        private void CheckConnectedControlls(string controlName, bool isChecked)
        {
            if (controlName == Constants.ModGlyphOfChainHeal)
            {
                skipEventChanged = true;
                this.checkBoxGlyphOfChainHealEarthliving.Checked = isChecked;
                this.checkBoxGlyphChainHeal.Checked = isChecked;
            }
        }

        private void DisplayOnGlyphOfHealingWave()
        {
            if (checkBoxGlyphOfHealingWave.Checked)
            {
                this.labelAvgGlyphOfHealingWave.Enabled = true;
                textBoxGlyphOfHealingWave.Enabled = true;
            }
            else
            {
                this.labelAvgGlyphOfHealingWave.Enabled = false;
                textBoxGlyphOfHealingWave.Enabled = false;
            }
        }

        private void numericUpDownEmeraldVigor_ValueChanged(object sender, EventArgs e)
        {
            if (!skipEventChanged)
            {
                var number = (int)((NumericUpDown)sender).Value;
                Player.Instance.EmeraldVigorNumber = number;
                selectedSpell.Calculate();
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

        private void HideShowControlls(Spell selectedSpell)
        {
            this.labelDashCrit1.Hide();
            this.labelDashHit1.Hide();
            this.textBoxAvgHot1.Hide();
            this.textBoxCrit1Avg.Hide();
            this.textBoxCrit1From.Hide();
            this.labelArrowcCrit1.Hide();
            this.textBoxCrit1To.Hide();
            labelAvgHot1.Hide();
            labelCritMax.Hide();

            this.labelArrowcCrit2.Hide();
            this.labelArrowHit2.Hide();
            this.labelDashCrit2.Hide();
            this.labelDashHit2.Hide();
            this.labelTarget2.Hide();
            this.textBoxAvgHot2.Hide();
            this.textBoxCrit2Avg.Hide();
            this.textBoxCrit2From.Hide();
            this.textBoxCrit2To.Hide();
            this.textBoxHit2Avg.Hide();
            this.textBoxHit2From.Hide();
            this.textBoxHit2To.Hide();

            this.labelArrowcCrit3.Hide();
            this.labelArrowHit3.Hide();
            this.labelDashCrit3.Hide();
            this.labelDashHit3.Hide();
            this.labelTarget3.Hide();
            this.textBoxAvgHot3.Hide();
            this.textBoxCrit3Avg.Hide();
            this.textBoxCrit3From.Hide();
            this.textBoxCrit3To.Hide();
            this.textBoxHit3Avg.Hide();
            this.textBoxHit3From.Hide();
            this.textBoxHit3To.Hide();

            this.labelArrowcCrit4.Hide();
            this.labelArrowHit4.Hide();
            this.labelDashCrit4.Hide();
            this.labelDashHit4.Hide();
            this.labelTarget4.Hide();
            this.textBoxAvgHot4.Hide();
            this.textBoxCrit4Avg.Hide();
            this.textBoxCrit4From.Hide();
            this.textBoxCrit4To.Hide();
            this.textBoxHit4Avg.Hide();
            this.textBoxHit4From.Hide();
            this.textBoxHit4To.Hide();

            this.labelTarget1.Hide();
            this.labelTarget2.Hide();
            this.labelTarget3.Hide();
            this.labelTarget4.Hide();

            this.labelArrowHit1.Hide();
            this.textBoxHit1To.Hide();
            this.textBoxHit1Avg.Hide();

            checkBoxRevitalizingSkyflareDiamond.Hide();
            labelChainedHeal1.Hide();
            labelChainedHeal2.Hide();
            checkBoxGlyphChainHeal.Hide();
            labelCastingTime.Hide();
            labelEarthlivingBlessingOf.Hide();

            textBoxCastingTime.Hide();
            this.labelHit.Hide();
            this.labelTick.Hide();
            labelHitAvg.Hide();
            labelCritAvg.Hide();
            checkBoxGlyphOfEarthliving.Hide();
            labelAvgHotHps.Hide();
            textBoxAvgHotHps.Hide();
            labelApproximately1.Hide();
            labelApproximately2.Hide();
            this.textBoxHit1From.Hide();
            textBoxAvgHps.Hide();
            labelForOneTarget.Hide();
            labelAncestralAwakening.Hide();
            textBoxAncestralAwaceningFrom.Hide();
            textBoxAncestralAwaceningTo.Hide();
            textBoxAncestralAwaceningAvg.Hide();
            labelAvgHps.Hide();
            labelAvgAA.Hide();
            labelAvgAAeHps.Hide();
            textBoxAvgAAeHps.Hide();
            labelSpamOnDifferent1.Hide();
            labelSpamOnDifferent2.Hide();
            labelSpamOn1Target1.Hide();
            labelSpamOn1Target2.Hide();
            checkBoxGlyphOfRiptide.Hide();
            labelHot.Hide();
            textBoxHotRiptide.Hide();
            textBoxGlyphOfHealingWave.Hide();
            labelAvgGlyphOfHealingWave.Hide();
            checkBoxGlyphOfHealingWave.Hide();
            labelPerTick.Hide();
            checkBoxGlyphOfChainHealEarthliving.Hide();
            textBoxEarthlivingAvgHpsCH.Hide();
            textBoxEarthlivingAvgHpsHW.Hide();
            textBoxEarthlivingAvgHpsLHW.Hide();
            textBoxEarthlivingAvgHpsRP.Hide();
            textBoxEarthlivingAvgHpsTotal.Hide();
            labeAvgHps2.Hide();
            labeEarthlivingHps3.Hide();
            labeEarthlivingHps4.Hide();
            labeEarthlivingHps5.Hide();
            labelEarthlivingCH.Hide();
            labelEarthlivingHW.Hide();
            labelEarthlivingLHW.Hide();
            labelEarthlivingRP.Hide();
            labelAvgAAHps2.Hide();
            labelEarthlivingHps1.Hide();
            labelEarthlivingHps2.Hide();
            labelChainHealStacking.Hide();

            switch (selectedSpell.Name)
            {
                case Constants.SpellChainHeal:
                    labelChainHealStacking.Show();
                    labelHitAvg.Show();
                    labelHit.Show();
                    labelCritAvg.Show();
                    this.textBoxHit1From.Show();

                    this.labelArrowcCrit2.Show();
                    this.labelArrowHit2.Show();
                    this.labelDashCrit2.Show();
                    this.labelDashHit2.Show();
                    this.labelTarget2.Show();
                    this.textBoxAvgHot2.Show();
                    this.textBoxCrit2Avg.Show();
                    this.textBoxCrit2From.Show();
                    this.textBoxCrit2To.Show();
                    this.textBoxHit2Avg.Show();
                    this.textBoxHit2From.Show();
                    this.textBoxHit2To.Show();

                    this.labelArrowcCrit3.Show();
                    this.labelArrowHit3.Show();
                    this.labelDashCrit3.Show();
                    this.labelDashHit3.Show();
                    this.labelTarget3.Show();
                    this.textBoxAvgHot3.Show();
                    this.textBoxCrit3Avg.Show();
                    this.textBoxCrit3From.Show();
                    this.textBoxCrit3To.Show();
                    this.textBoxHit3Avg.Show();
                    this.textBoxHit3From.Show();
                    this.textBoxHit3To.Show();

                    this.labelArrowcCrit4.Show();
                    this.labelArrowHit4.Show();
                    this.labelDashCrit4.Show();
                    this.labelDashHit4.Show();
                    this.labelTarget4.Show();
                    this.textBoxAvgHot4.Show();
                    this.textBoxCrit4Avg.Show();
                    this.textBoxCrit4From.Show();
                    this.textBoxCrit4To.Show();
                    this.textBoxHit4Avg.Show();
                    this.textBoxHit4From.Show();
                    this.textBoxHit4To.Show();

                    this.labelTarget1.Show();
                    this.labelTarget2.Show();
                    this.labelTarget3.Show();
                    this.labelTarget4.Show();

                    this.labelArrowcCrit1.Show();
                    this.labelArrowHit1.Show();
                    this.labelDashCrit1.Show();
                    this.labelDashHit1.Show();
                    this.textBoxAvgHot1.Show();
                    this.textBoxCrit1Avg.Show();
                    this.textBoxCrit1From.Show();
                    this.textBoxCrit1To.Show();
                    this.textBoxHit1Avg.Show();
                    this.textBoxHit1To.Show();
                    labelAvgHot1.Show();
                    labelCritMax.Show();
                    checkBoxRevitalizingSkyflareDiamond.Show();
                    labelChainedHeal1.Show();
                    checkBoxGlyphChainHeal.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    labelAvgHotHps.Show();
                    labelChainedHeal2.Show();
                    textBoxAvgHotHps.Show();
                    break;
                case Constants.SpellEarthliving:
                    textBoxAvgHps.Show();
                    textBoxHit1From.Show();
                    labelTick.Show();
                    labelEarthlivingBlessingOf.Show();
                    checkBoxGlyphOfEarthliving.Show();
                    textBoxAvgHotHps.Show();
                    checkBoxGlyphOfChainHealEarthliving.Show();
                    textBoxEarthlivingAvgHpsCH.Show();
                    textBoxEarthlivingAvgHpsHW.Show();
                    textBoxEarthlivingAvgHpsLHW.Show();
                    textBoxEarthlivingAvgHpsRP.Show();
                    //textBoxEarthlivingAvgHpsTotal.Show();
                    //labelAvgHps.Show();
                    //labeAvgHps2.Show();
                    labelEarthlivingHps1.Show();
                    labelEarthlivingHps2.Show();
                    labeEarthlivingHps3.Show();
                    labeEarthlivingHps4.Show();
                    //labeEarthlivingHps5.Show();
                    labelEarthlivingCH.Show();
                    labelEarthlivingHW.Show();
                    labelEarthlivingLHW.Show();
                    labelEarthlivingRP.Show();
                    break;
                case Constants.SpellHST:
                    textBoxHit1From.Show();
                    labelTick.Show();
                    textBoxAvgHotHps.Show();
                    //textBoxAvgHps.Show();
                    labelForOneTarget.Show();
                    labelPerTick.Show();
                    labeAvgHps2.Show();
                    break;
                case Constants.SpellHW:
                    labelDashHit1.Show();
                    textBoxHit1To.Show();
                    labelArrowHit1.Show();
                    textBoxHit1Avg.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    labelDashCrit1.Show();
                    textBoxCrit1To.Show();
                    labelArrowcCrit1.Show();
                    textBoxCrit1Avg.Show();
                    labelCritAvg.Show();
                    textBoxCrit3From.Show();
                    labelDashCrit3.Show();
                    textBoxCrit3To.Show();
                    labelArrowcCrit3.Show();
                    textBoxCrit3Avg.Show();
                    checkBoxRevitalizingSkyflareDiamond.Show();
                    labelHitAvg.Show();
                    labelAvgHps.Show();
                    labelAvgAAHps2.Show();
                    labelAvgAA.Show();
                    textBoxAvgHps.Show();
                    textBoxAvgHotHps.Show();
                    labelAncestralAwakening.Show();
                    textBoxAncestralAwaceningFrom.Show();
                    textBoxAncestralAwaceningTo.Show();
                    textBoxAncestralAwaceningAvg.Show();
                    textBoxHit1From.Show();
                    this.labelHit.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    textBoxGlyphOfHealingWave.Show();
                    labelAvgGlyphOfHealingWave.Show();
                    checkBoxGlyphOfHealingWave.Show();
                    break;
                case Constants.SpellLHW:
                    labelDashHit1.Show();
                    textBoxHit1To.Show();
                    labelArrowHit1.Show();
                    textBoxHit1Avg.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    labelDashCrit1.Show();
                    textBoxCrit1To.Show();
                    labelArrowcCrit1.Show();
                    textBoxCrit1Avg.Show();
                    labelCritAvg.Show();
                    textBoxCrit3From.Show();
                    labelDashCrit3.Show();
                    textBoxCrit3To.Show();
                    labelArrowcCrit3.Show();
                    textBoxCrit3Avg.Show();
                    checkBoxRevitalizingSkyflareDiamond.Show();
                    labelHitAvg.Show();

                    labelAvgHps.Show();
                    labelAvgAAHps2.Show();
                    textBoxAvgHps.Show();
                    
                    textBoxAvgHotHps.Show();
                    labelAvgAA.Show();

                    labelAncestralAwakening.Show();
                    textBoxAncestralAwaceningFrom.Show();
                    textBoxAncestralAwaceningTo.Show();
                    textBoxAncestralAwaceningAvg.Show();
                    textBoxHit1From.Show();
                    this.labelHit.Show();
                    labelCastingTime.Show();
                    textBoxCastingTime.Show();
                    break;
                case Constants.SpellESh:
                    labelApproximately1.Show();
                    labelApproximately2.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    this.labelHit.Show();
                    textBoxHit1From.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    checkBoxRevitalizingSkyflareDiamond.Show();
                    break;
                case Constants.SpellRiptide:
                    labelHitAvg.Show();
                    checkBoxRevitalizingSkyflareDiamond.Show();
                    labelAvgAA.Show();
                    labelAvgAAeHps.Show();
                    textBoxAvgAAeHps.Show();

                    labelDashHit1.Show();
                    textBoxHit1To.Show();
                    labelArrowHit1.Show();
                    textBoxHit1Avg.Show();
                    labelCritMax.Show();
                    textBoxCrit1From.Show();
                    labelDashCrit1.Show();
                    textBoxCrit1To.Show();
                    labelArrowcCrit1.Show();
                    textBoxCrit1Avg.Show();
                    labelCritAvg.Show();
                    textBoxCrit3From.Show();
                    labelDashCrit3.Show();
                    textBoxCrit3To.Show();
                    labelArrowcCrit3.Show();
                    textBoxCrit3Avg.Show();
                    checkBoxRevitalizingSkyflareDiamond.Show();
                    labelHitAvg.Show();
                    labelAncestralAwakening.Show();
                    textBoxAncestralAwaceningFrom.Show();
                    textBoxAncestralAwaceningTo.Show();
                    textBoxAncestralAwaceningAvg.Show();
                    textBoxHit1From.Show();
                    this.labelHit.Show();

                    labelSpamOnDifferent1.Show();
                    labelSpamOnDifferent2.Show();
                    labelSpamOn1Target1.Show();
                    labelSpamOn1Target2.Show();
                    labeAvgHps2.Show();
                    labelAvgHps.Show();
                    textBoxAvgHps.Show();
                    textBoxAvgHotHps.Show();
                    checkBoxGlyphOfRiptide.Show();
                    labelHot.Show();
                    textBoxHotRiptide.Show();
                    break;
            }
        }

        private void DisplayOnGlyphOfChainHeal()
        {
            if (checkBoxGlyphChainHeal.Checked)
            {
                this.labelTarget4.Enabled = true;
                this.labelArrowcCrit4.Enabled = true;
                this.labelArrowHit4.Enabled = true;
                this.labelDashCrit4.Enabled = true;
                this.labelDashHit4.Enabled = true;
                this.labelTarget4.Enabled = true;
                this.textBoxAvgHot4.Enabled = true;
                this.textBoxCrit4Avg.Enabled = true;
                this.textBoxCrit4From.Enabled = true;
                this.textBoxCrit4To.Enabled = true;
                this.textBoxHit4Avg.Enabled = true;
                this.textBoxHit4From.Enabled = true;
                this.textBoxHit4To.Enabled = true;
            }
            else
            {
                this.labelTarget4.Enabled = false;
                this.labelArrowcCrit4.Enabled = false;
                this.labelArrowHit4.Enabled = false;
                this.labelDashCrit4.Enabled = false;
                this.labelDashHit4.Enabled = false;
                this.labelTarget4.Enabled = false;
                this.textBoxAvgHot4.Enabled = false;
                this.textBoxCrit4Avg.Enabled = false;
                this.textBoxCrit4From.Enabled = false;
                this.textBoxCrit4To.Enabled = false;
                this.textBoxHit4Avg.Enabled = false;
                this.textBoxHit4From.Enabled = false;
                this.textBoxHit4To.Enabled = false;
            }
        }

        private void DisplayHealing()
        {
            this.textBoxHasteRating.Text = Player.Instance.HasteRating == 0 ? "" : Player.Instance.HasteRating.ToString();
            this.textBoxSpellPower.Text = Player.Instance.SpellPower == 0 ? "" : Player.Instance.SpellPower.ToString();
            this.textBoxHastePercent.Text = Player.Instance.HastePercent.ToString();
            this.textBoxHit1From.Text = Player.Instance.Hit1From.ToString();
            this.textBoxHit2From.Text = Player.Instance.Hit2From.ToString();
            this.textBoxHit3From.Text = Player.Instance.Hit3From.ToString();
            this.textBoxHit4From.Text = Player.Instance.Hit4From.ToString();
            this.textBoxHit1To.Text = Player.Instance.Hit1To.ToString();
            this.textBoxHit2To.Text = Player.Instance.Hit2To.ToString();
            this.textBoxHit3To.Text = Player.Instance.Hit3To.ToString();
            this.textBoxHit4To.Text = Player.Instance.Hit4To.ToString();
            this.textBoxHit1Avg.Text = Player.Instance.Hit1Avg.ToString();
            this.textBoxHit2Avg.Text = Player.Instance.Hit2Avg.ToString();
            this.textBoxHit3Avg.Text = Player.Instance.Hit3Avg.ToString();
            this.textBoxHit4Avg.Text = Player.Instance.Hit4Avg.ToString();
            this.textBoxCrit1From.Text = Player.Instance.Crit1From.ToString();
            this.textBoxCrit2From.Text = Player.Instance.Crit2From.ToString();
            this.textBoxCrit3From.Text = Player.Instance.Crit3From.ToString();
            this.textBoxCrit4From.Text = Player.Instance.Crit4From.ToString();
            this.textBoxCrit1To.Text = Player.Instance.Crit1To.ToString();
            this.textBoxCrit2To.Text = Player.Instance.Crit2To.ToString();
            this.textBoxCrit3To.Text = Player.Instance.Crit3To.ToString();
            this.textBoxCrit4To.Text = Player.Instance.Crit4To.ToString();
            this.textBoxCrit1Avg.Text = Player.Instance.Crit1Avg.ToString();
            this.textBoxCrit2Avg.Text = Player.Instance.Crit2Avg.ToString();
            this.textBoxCrit3Avg.Text = Player.Instance.Crit3Avg.ToString();
            this.textBoxCrit4Avg.Text = Player.Instance.Crit4Avg.ToString();
            this.textBoxAvgHot1.Text = Player.Instance.AvgHot1.ToString();
            this.textBoxAvgHot2.Text = Player.Instance.AvgHot2.ToString();
            this.textBoxAvgHot3.Text = Player.Instance.AvgHot3.ToString();
            this.textBoxAvgHot4.Text = Player.Instance.AvgHot4.ToString();
            this.textBoxHotRiptide.Text = Player.Instance.HotRiptide.ToString();
            this.textBoxAncestralAwaceningFrom.Text = Player.Instance.AncestralAwaceningFrom.ToString();
            this.textBoxAncestralAwaceningTo.Text = Player.Instance.AncestralAwaceningTo.ToString();
            this.textBoxAncestralAwaceningAvg.Text = Player.Instance.AncestralAwaceningAvg.ToString();
            this.textBoxAvgHps.Text = Player.Instance.AvgHps.ToString();
            this.textBoxAvgHotHps.Text = Player.Instance.AvgHotHps.ToString();
            textBoxAvgAAeHps.Text = Player.Instance.AvgAAHps.ToString();
            textBoxGlyphOfHealingWave.Text = Player.Instance.AvgGlyphOfHealingWave.ToString();
            //Earthliving
            textBoxEarthlivingAvgHpsCH.Text = Player.Instance.EarthlivingAvgHpsCH.ToString();
            textBoxEarthlivingAvgHpsHW.Text = Player.Instance.EarthlivingAvgHpsHW.ToString();
            textBoxEarthlivingAvgHpsLHW.Text = Player.Instance.EarthlivingAvgHpsLHW.ToString();
            textBoxEarthlivingAvgHpsRP.Text = Player.Instance.EarthlivingAvgHpsRP.ToString();
            textBoxEarthlivingAvgHpsTotal.Text = Player.Instance.EarthlivingAvgHpsTotal.ToString();

            this.textBoxCastingTime.Text = Player.Instance.CastingTime.ToString();

            this.numericUpDownCriticalChance.Text = Player.Instance.CriticalChance.ToString();

            if (selectedSpell != null &&
                (selectedSpell.Name == Constants.SpellEarthliving) || selectedSpell.Name == Constants.SpellHST)
            {
                labelAvgHps.Text = Constants.LabelAvgHps;
            }
            else if (selectedSpell != null &&
                (selectedSpell.Name == Constants.SpellHW || selectedSpell.Name == Constants.SpellLHW))
            {
                labelAvgHotHps.Text = Constants.LabelAvgHpsHealingWave;
                labelAvgHps.Text = Constants.LabelAvgHps;
            }
            else if (selectedSpell != null && selectedSpell.Name == Constants.SpellRiptide)
            {
                labelAvgHotHps.Text = Constants.LabelAvgHps;
            }
            else
            {
                labelAvgHotHps.Text = "AVG HOT eHPS:";
                labelAvgHps.Text = Constants.LabelAvgHps;

            }
        }

        private void textBoxSpellPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxHaste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownCriticalChance_KeyPress(object sender, KeyPressEventArgs e)
        {
            isAfterCritKeyPress = true;
        }

        private void numericUpDownCriticalChance_MouseDown(object sender, MouseEventArgs e)
        {
            isAfterCritKeyPress = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBoxes)
            {
                if (item.Name == "checkBoxMuteSound") continue;
                item.Checked = false;
            }

            this.textBoxSpellPower.Text = "";
            textBoxHasteRating.Text = "";
            Player.Instance.CriticalChanceInitial = 0;
            numericUpDownCriticalChance.Value = 0;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            var location = this.DesktopLocation;

            this.Hide();
            var startScreen = Player.Instance.FormStartScreen;
            startScreen.DesktopLocation = location;
            startScreen.Show();
            //this.Close();
        }

        //private void numericUpDownCriticalChance_Enter(object sender, EventArgs e)
        //{
        //    // Select the whole answer in the NumericUpDown control.
        //    NumericUpDown answerBox = sender as NumericUpDown;

        //    if (answerBox != null)
        //    {
        //        int lengthOfAnswer = answerBox.Value.ToString().Length;
        //        answerBox.Select(0, lengthOfAnswer);
        //    }
        //}

        private void checkBoxMuteSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMuteSound.Checked)
            {
                Player.Instance.MuteSound = true;
                Player.Instance.StopSound();
            }
            else
            {
                Player.Instance.MuteSound = false;
            }
            if (!skipEventChanged)
            {
                Player.Instance.Modifiers[checkBoxMuteSound.Text] = checkBoxMuteSound.Checked;
            }
            skipEventChanged = false;
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Player.Instance.FormStartScreen.Close();
        }
    }
}
