using App.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Calculator()
        {
            InitializeComponent();
            AdjustComponentProperties();
            AddControllsToList();
            InitialiseComboBoxSpell();
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
            this.checkBoxSwiftRetribution.Text = Constants.ModSwiftRetrubution;
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
                this.checkBoxSwiftRetribution,
                this.checkBoxBloodlust,
                this.checkBoxRapidCurrents,
                this.checkBoxTidalWaves,
                this.checkBoxTidalMastery,
                this.checkBoxMoonkinForm,
                this.checkBoxTidalWavesCrit
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

        private void textBoxCrit_TextChanged(object sender, EventArgs e)
        {
            if (isAfterCritKeyPress)
            {
                isAfterCritKeyPress = false;

                double crit = 0;
                if (double.TryParse(this.textBoxCrit.Text, out crit))
                {
                    Player.Instance.CriticalChanceInitial = crit;
                }
            }

            if (selectedSpell != null)
            {
                selectedSpell.Calculate();
                DisplayHealing();
            }
        }

        private void comboBoxSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSpell = (Spell)this.comboBoxSpell.SelectedItem;

            selectedSpell.EnableDisableModifiers(checkBoxes);

            HideShowControlls(selectedSpell);

            var checkedModifiers = GetTextOfCheckedModifiers();
            selectedSpell.CheckModifiers(checkedModifiers);

            selectedSpell.Calculate();

            DisplayHealing();
        }

        private void HideShowControlls(Spell selectedSpell)
        {
            if (selectedSpell.Name == Constants.SpellChainHeal)
            {
                this.labelArrowcCrit2.Show();
                this.labelArrowHit2.Show();
                this.labelAvgHot2.Show();
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
                this.labelAvgHot3.Show();
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
                this.labelAvgHot4.Show();
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
            }
            else
            {
                this.labelArrowcCrit2.Hide();
                this.labelArrowHit2.Hide();
                this.labelAvgHot2.Hide();
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
                this.labelAvgHot3.Hide();
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
                this.labelAvgHot4.Hide();
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
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
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
                selectedSpell.CalculateOnModifierChange(check.Text, check.Checked);
                Player.Instance.IsCritModified = true;
                DisplayHealing();
                return;
            }

            throw new Exception("Sender is not CheckBox");
        }

        private void numericUpDownEmeraldVigor_ValueChanged(object sender, EventArgs e)
        {
            var number = (int)((NumericUpDown)sender).Value;
            Player.Instance.EmeraldVigorNumber = number;
            selectedSpell.Calculate();
            DisplayHealing();
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

        private void DisplayHealing()
        {
            this.textBoxHit1To.Text = Player.Instance.Hit1To.ToString();
            this.textBoxHit1From.Text = Player.Instance.Hit1From.ToString();
            this.textBoxHastePercent.Text = Player.Instance.HastePercent.ToString();
            this.textBoxHit2From.Text = Player.Instance.Hit2From.ToString();
            this.textBoxHit2To.Text = Player.Instance.Hit2To.ToString();
            if (Player.Instance.IsCritModified)
            {
                Player.Instance.IsCritModified = false;
                this.textBoxCrit.Text = Player.Instance.CriticalChance.ToString();
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

        private void textBoxCrit_KeyPress(object sender, KeyPressEventArgs e)
        {
            var box = (TextBox)sender;
            var text = box.Text;
            var length = box.TextLength;
            var containsDot = text.Contains('.');
            

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.' && containsDot) || (e.KeyChar == '.' && length == 0))
            {
                e.Handled = true;
                return;
            }
            if (containsDot
                && (length - text.IndexOf('.') > 2)
                && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            double critChance;
            if (double.TryParse(text + e.KeyChar, out critChance))
            {
                if (critChance > 100 && box.SelectionLength == 0)
                {
                    e.Handled = true;
                }
            }
            isAfterCritKeyPress = true;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            var t = (ToolTip)sender;
            
        }
    }
}
