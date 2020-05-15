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
        public Calculator()
        {
            InitializeComponent();
            InitialiseComboBoxSpell();

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

        private void comboBoxSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSpell = (Spell)this.comboBoxSpell.SelectedItem;

            var objects = Enumerable
                .Range(1, selectedSpell.RanksCount)
                .Select(x => x as object)
                .ToArray();

            this.comboBoxRanks.Items.Clear();
            this.comboBoxRanks.Items.AddRange(objects);
            this.comboBoxRanks.Enabled = true;
            this.labelRank.Enabled = true;
        }
    }
}
