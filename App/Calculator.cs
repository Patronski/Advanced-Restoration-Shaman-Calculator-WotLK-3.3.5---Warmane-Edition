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
        private List<CheckBox> checks;

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
            checks = new List<CheckBox>()
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

        private void textBoxSpellPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSpellPower_TextChanged(object sender, EventArgs e)
        {
            int spellPower = 0;
            if (!int.TryParse(this.textBoxSpellPower.Text, out spellPower))
            {
                this.textBoxSpellPower.Text = "";
            }
            Player.Instance.SpellPower = spellPower;

            var selectedSpell = (Spell)this.comboBoxSpell.SelectedItem;

            var hitFrom = selectedSpell?.CalculateHitFrom();
            this.textBoxHitFrom.Text = hitFrom?.ToString();

            var hitTo = selectedSpell?.CalculateHitTo();
            this.textBoxHitTo.Text = hitTo?.ToString();
        }

        private void comboBoxSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSpell = (Spell)this.comboBoxSpell.SelectedItem;

            selectedSpell.EnableDisableModifiers(checks);

            //TODO get name of checked modifiers
            //TODO selectedSpell.LoadModifiers();

            var hitFrom = selectedSpell.CalculateHitFrom();
            this.textBoxHitFrom.Text = hitFrom.ToString();

            var hitTo = selectedSpell.CalculateHitTo();
            this.textBoxHitTo.Text = hitTo.ToString();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
