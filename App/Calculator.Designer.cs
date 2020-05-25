namespace App
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.labelSpellPower = new System.Windows.Forms.Label();
            this.textBoxSpellPower = new System.Windows.Forms.TextBox();
            this.comboBoxSpell = new System.Windows.Forms.ComboBox();
            this.textBoxCrit = new System.Windows.Forms.TextBox();
            this.labelCrit = new System.Windows.Forms.Label();
            this.textBoxHaste = new System.Windows.Forms.TextBox();
            this.labelHaste = new System.Windows.Forms.Label();
            this.labelHit = new System.Windows.Forms.Label();
            this.textBoxHitFrom = new System.Windows.Forms.TextBox();
            this.labelDash = new System.Windows.Forms.Label();
            this.textBoxHitTo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelArrow = new System.Windows.Forms.Label();
            this.labelHealingModifiers = new System.Windows.Forms.Label();
            this.checkBoxTreeOfLife = new System.Windows.Forms.CheckBox();
            this.checkBoxHellscream = new System.Windows.Forms.CheckBox();
            this.checkBoxEmeraldVigor = new System.Windows.Forms.CheckBox();
            this.checkBoxRiptidesConsumption = new System.Windows.Forms.CheckBox();
            this.checkBoxGlyphOfEarthShield = new System.Windows.Forms.CheckBox();
            this.checkBoxGyphOfHST = new System.Windows.Forms.CheckBox();
            this.checkBoxGlyphOfLHW = new System.Windows.Forms.CheckBox();
            this.labelHasteModifiers = new System.Windows.Forms.Label();
            this.checkBoxWrathOfTheAirTotem = new System.Windows.Forms.CheckBox();
            this.checkBoxSwiftRetribution = new System.Windows.Forms.CheckBox();
            this.checkBoxBloodlust = new System.Windows.Forms.CheckBox();
            this.checkBoxRapidCurrents = new System.Windows.Forms.CheckBox();
            this.checkBoxTidalWaves = new System.Windows.Forms.CheckBox();
            this.labelCritModifiers = new System.Windows.Forms.Label();
            this.checkBoxTidalMastery = new System.Windows.Forms.CheckBox();
            this.checkBoxMoonkinForm = new System.Windows.Forms.CheckBox();
            this.checkBoxTidalWavesCrit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelSpellPower
            // 
            this.labelSpellPower.AutoSize = true;
            this.labelSpellPower.Enabled = false;
            this.labelSpellPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpellPower.Location = new System.Drawing.Point(331, 13);
            this.labelSpellPower.Name = "labelSpellPower";
            this.labelSpellPower.Size = new System.Drawing.Size(95, 16);
            this.labelSpellPower.TabIndex = 0;
            this.labelSpellPower.Text = "Spell Power:";
            // 
            // textBoxSpellPower
            // 
            this.textBoxSpellPower.Location = new System.Drawing.Point(334, 35);
            this.textBoxSpellPower.MaxLength = 6;
            this.textBoxSpellPower.Name = "textBoxSpellPower";
            this.textBoxSpellPower.Size = new System.Drawing.Size(77, 20);
            this.textBoxSpellPower.TabIndex = 1;
            this.textBoxSpellPower.TextChanged += new System.EventHandler(this.textBoxSpellPower_TextChanged);
            this.textBoxSpellPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpellPower_KeyPress);
            // 
            // comboBoxSpell
            // 
            this.comboBoxSpell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSpell.FormattingEnabled = true;
            this.comboBoxSpell.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSpell.Name = "comboBoxSpell";
            this.comboBoxSpell.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSpell.TabIndex = 2;
            this.comboBoxSpell.Text = "Select spell";
            this.comboBoxSpell.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpell_SelectedIndexChanged);
            // 
            // textBoxCrit
            // 
            this.textBoxCrit.Location = new System.Drawing.Point(761, 31);
            this.textBoxCrit.MaxLength = 6;
            this.textBoxCrit.Name = "textBoxCrit";
            this.textBoxCrit.Size = new System.Drawing.Size(88, 20);
            this.textBoxCrit.TabIndex = 9;
            this.textBoxCrit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCrit_KeyPress);
            // 
            // labelCrit
            // 
            this.labelCrit.AutoSize = true;
            this.labelCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrit.Location = new System.Drawing.Point(758, 13);
            this.labelCrit.Name = "labelCrit";
            this.labelCrit.Size = new System.Drawing.Size(91, 16);
            this.labelCrit.TabIndex = 8;
            this.labelCrit.Text = "Crit Chance:";
            // 
            // textBoxHaste
            // 
            this.textBoxHaste.Location = new System.Drawing.Point(544, 32);
            this.textBoxHaste.MaxLength = 6;
            this.textBoxHaste.Name = "textBoxHaste";
            this.textBoxHaste.Size = new System.Drawing.Size(39, 20);
            this.textBoxHaste.TabIndex = 11;
            this.textBoxHaste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHaste_KeyPress);
            // 
            // labelHaste
            // 
            this.labelHaste.AutoSize = true;
            this.labelHaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHaste.Location = new System.Drawing.Point(552, 13);
            this.labelHaste.Name = "labelHaste";
            this.labelHaste.Size = new System.Drawing.Size(102, 16);
            this.labelHaste.TabIndex = 10;
            this.labelHaste.Text = "Haste Rating:";
            // 
            // labelHit
            // 
            this.labelHit.AutoSize = true;
            this.labelHit.Location = new System.Drawing.Point(331, 87);
            this.labelHit.Name = "labelHit";
            this.labelHit.Size = new System.Drawing.Size(23, 13);
            this.labelHit.TabIndex = 0;
            this.labelHit.Text = "Hit:";
            // 
            // textBoxHitFrom
            // 
            this.textBoxHitFrom.Location = new System.Drawing.Point(361, 85);
            this.textBoxHitFrom.MaxLength = 10;
            this.textBoxHitFrom.Name = "textBoxHitFrom";
            this.textBoxHitFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxHitFrom.TabIndex = 13;
            // 
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Location = new System.Drawing.Point(467, 88);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(13, 13);
            this.labelDash.TabIndex = 15;
            this.labelDash.Text = "—";
            // 
            // textBoxHitTo
            // 
            this.textBoxHitTo.Location = new System.Drawing.Point(486, 85);
            this.textBoxHitTo.MaxLength = 10;
            this.textBoxHitTo.Name = "textBoxHitTo";
            this.textBoxHitTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHitTo.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(621, 32);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 17;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPercent.Location = new System.Drawing.Point(677, 35);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(21, 16);
            this.labelPercent.TabIndex = 19;
            this.labelPercent.Text = "%";
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrow.Location = new System.Drawing.Point(589, 36);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(26, 16);
            this.labelArrow.TabIndex = 20;
            this.labelArrow.Text = "—>";
            // 
            // labelHealingModifiers
            // 
            this.labelHealingModifiers.AutoSize = true;
            this.labelHealingModifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHealingModifiers.Location = new System.Drawing.Point(15, 52);
            this.labelHealingModifiers.Name = "labelHealingModifiers";
            this.labelHealingModifiers.Size = new System.Drawing.Size(125, 15);
            this.labelHealingModifiers.TabIndex = 22;
            this.labelHealingModifiers.Text = "Healing Modifiers:";
            // 
            // checkBoxTreeOfLife
            // 
            this.checkBoxTreeOfLife.AutoSize = true;
            this.checkBoxTreeOfLife.Enabled = false;
            this.checkBoxTreeOfLife.Location = new System.Drawing.Point(18, 73);
            this.checkBoxTreeOfLife.Name = "checkBoxTreeOfLife";
            this.checkBoxTreeOfLife.Size = new System.Drawing.Size(206, 17);
            this.checkBoxTreeOfLife.TabIndex = 23;
            this.checkBoxTreeOfLife.Text = "Tree Of Life (Improved Devotion Aura)";
            this.checkBoxTreeOfLife.UseVisualStyleBackColor = true;
            this.checkBoxTreeOfLife.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxHellscream
            // 
            this.checkBoxHellscream.AutoSize = true;
            this.checkBoxHellscream.Enabled = false;
            this.checkBoxHellscream.Location = new System.Drawing.Point(18, 96);
            this.checkBoxHellscream.Name = "checkBoxHellscream";
            this.checkBoxHellscream.Size = new System.Drawing.Size(223, 17);
            this.checkBoxHellscream.TabIndex = 24;
            this.checkBoxHellscream.Text = "Hellscream\'s Warsong(Strength of Wrynn)";
            this.checkBoxHellscream.UseVisualStyleBackColor = true;
            this.checkBoxHellscream.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxEmeraldVigor
            // 
            this.checkBoxEmeraldVigor.AutoSize = true;
            this.checkBoxEmeraldVigor.Enabled = false;
            this.checkBoxEmeraldVigor.Location = new System.Drawing.Point(18, 119);
            this.checkBoxEmeraldVigor.Name = "checkBoxEmeraldVigor";
            this.checkBoxEmeraldVigor.Size = new System.Drawing.Size(91, 17);
            this.checkBoxEmeraldVigor.TabIndex = 25;
            this.checkBoxEmeraldVigor.Text = "Emerald Vigor";
            this.checkBoxEmeraldVigor.UseVisualStyleBackColor = true;
            this.checkBoxEmeraldVigor.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxRiptidesConsumption
            // 
            this.checkBoxRiptidesConsumption.AutoSize = true;
            this.checkBoxRiptidesConsumption.Enabled = false;
            this.checkBoxRiptidesConsumption.Location = new System.Drawing.Point(18, 142);
            this.checkBoxRiptidesConsumption.Name = "checkBoxRiptidesConsumption";
            this.checkBoxRiptidesConsumption.Size = new System.Drawing.Size(130, 17);
            this.checkBoxRiptidesConsumption.TabIndex = 26;
            this.checkBoxRiptidesConsumption.Text = "Riptide\'s Consumption";
            this.checkBoxRiptidesConsumption.UseVisualStyleBackColor = true;
            this.checkBoxRiptidesConsumption.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxGlyphOfEarthShield
            // 
            this.checkBoxGlyphOfEarthShield.AutoSize = true;
            this.checkBoxGlyphOfEarthShield.Enabled = false;
            this.checkBoxGlyphOfEarthShield.Location = new System.Drawing.Point(18, 165);
            this.checkBoxGlyphOfEarthShield.Name = "checkBoxGlyphOfEarthShield";
            this.checkBoxGlyphOfEarthShield.Size = new System.Drawing.Size(125, 17);
            this.checkBoxGlyphOfEarthShield.TabIndex = 27;
            this.checkBoxGlyphOfEarthShield.Text = "Glyph of Earth Shield";
            this.checkBoxGlyphOfEarthShield.UseVisualStyleBackColor = true;
            this.checkBoxGlyphOfEarthShield.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxGyphOfHST
            // 
            this.checkBoxGyphOfHST.AutoSize = true;
            this.checkBoxGyphOfHST.Enabled = false;
            this.checkBoxGyphOfHST.Location = new System.Drawing.Point(18, 188);
            this.checkBoxGyphOfHST.Name = "checkBoxGyphOfHST";
            this.checkBoxGyphOfHST.Size = new System.Drawing.Size(90, 17);
            this.checkBoxGyphOfHST.TabIndex = 28;
            this.checkBoxGyphOfHST.Text = "Glyph of HST";
            this.checkBoxGyphOfHST.UseVisualStyleBackColor = true;
            this.checkBoxGyphOfHST.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxGlyphOfLHW
            // 
            this.checkBoxGlyphOfLHW.AutoSize = true;
            this.checkBoxGlyphOfLHW.Enabled = false;
            this.checkBoxGlyphOfLHW.Location = new System.Drawing.Point(18, 211);
            this.checkBoxGlyphOfLHW.Name = "checkBoxGlyphOfLHW";
            this.checkBoxGlyphOfLHW.Size = new System.Drawing.Size(93, 17);
            this.checkBoxGlyphOfLHW.TabIndex = 29;
            this.checkBoxGlyphOfLHW.Text = "Glyph of LHW";
            this.checkBoxGlyphOfLHW.UseVisualStyleBackColor = true;
            this.checkBoxGlyphOfLHW.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // labelHasteModifiers
            // 
            this.labelHasteModifiers.AutoSize = true;
            this.labelHasteModifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHasteModifiers.Location = new System.Drawing.Point(16, 231);
            this.labelHasteModifiers.Name = "labelHasteModifiers";
            this.labelHasteModifiers.Size = new System.Drawing.Size(112, 15);
            this.labelHasteModifiers.TabIndex = 30;
            this.labelHasteModifiers.Text = "Haste Modifiers:";
            // 
            // checkBoxWrathOfTheAirTotem
            // 
            this.checkBoxWrathOfTheAirTotem.AutoSize = true;
            this.checkBoxWrathOfTheAirTotem.Enabled = false;
            this.checkBoxWrathOfTheAirTotem.Location = new System.Drawing.Point(18, 249);
            this.checkBoxWrathOfTheAirTotem.Name = "checkBoxWrathOfTheAirTotem";
            this.checkBoxWrathOfTheAirTotem.Size = new System.Drawing.Size(133, 17);
            this.checkBoxWrathOfTheAirTotem.TabIndex = 31;
            this.checkBoxWrathOfTheAirTotem.Text = "Wrath of the Air Totem";
            this.checkBoxWrathOfTheAirTotem.UseVisualStyleBackColor = true;
            this.checkBoxWrathOfTheAirTotem.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxSwiftRetribution
            // 
            this.checkBoxSwiftRetribution.AutoSize = true;
            this.checkBoxSwiftRetribution.Enabled = false;
            this.checkBoxSwiftRetribution.Location = new System.Drawing.Point(18, 272);
            this.checkBoxSwiftRetribution.Name = "checkBoxSwiftRetribution";
            this.checkBoxSwiftRetribution.Size = new System.Drawing.Size(223, 17);
            this.checkBoxSwiftRetribution.TabIndex = 32;
            this.checkBoxSwiftRetribution.Text = "Swift Retribution(Improved Moonkin Form)";
            this.checkBoxSwiftRetribution.UseVisualStyleBackColor = true;
            this.checkBoxSwiftRetribution.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxBloodlust
            // 
            this.checkBoxBloodlust.AutoSize = true;
            this.checkBoxBloodlust.Enabled = false;
            this.checkBoxBloodlust.Location = new System.Drawing.Point(18, 295);
            this.checkBoxBloodlust.Name = "checkBoxBloodlust";
            this.checkBoxBloodlust.Size = new System.Drawing.Size(110, 17);
            this.checkBoxBloodlust.TabIndex = 33;
            this.checkBoxBloodlust.Text = "Bloodlust Heroism";
            this.checkBoxBloodlust.UseVisualStyleBackColor = true;
            this.checkBoxBloodlust.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxRapidCurrents
            // 
            this.checkBoxRapidCurrents.AutoSize = true;
            this.checkBoxRapidCurrents.Enabled = false;
            this.checkBoxRapidCurrents.Location = new System.Drawing.Point(18, 318);
            this.checkBoxRapidCurrents.Name = "checkBoxRapidCurrents";
            this.checkBoxRapidCurrents.Size = new System.Drawing.Size(96, 17);
            this.checkBoxRapidCurrents.TabIndex = 34;
            this.checkBoxRapidCurrents.Text = "Rapid Currents";
            this.checkBoxRapidCurrents.UseVisualStyleBackColor = true;
            this.checkBoxRapidCurrents.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxTidalWaves
            // 
            this.checkBoxTidalWaves.AutoSize = true;
            this.checkBoxTidalWaves.Enabled = false;
            this.checkBoxTidalWaves.Location = new System.Drawing.Point(18, 341);
            this.checkBoxTidalWaves.Name = "checkBoxTidalWaves";
            this.checkBoxTidalWaves.Size = new System.Drawing.Size(121, 17);
            this.checkBoxTidalWaves.TabIndex = 35;
            this.checkBoxTidalWaves.Text = "Tidal Waves - haste";
            this.checkBoxTidalWaves.UseVisualStyleBackColor = true;
            this.checkBoxTidalWaves.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // labelCritModifiers
            // 
            this.labelCritModifiers.AutoSize = true;
            this.labelCritModifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCritModifiers.Location = new System.Drawing.Point(15, 361);
            this.labelCritModifiers.Name = "labelCritModifiers";
            this.labelCritModifiers.Size = new System.Drawing.Size(97, 15);
            this.labelCritModifiers.TabIndex = 36;
            this.labelCritModifiers.Text = "Crit Modifiers:";
            // 
            // checkBoxTidalMastery
            // 
            this.checkBoxTidalMastery.AutoSize = true;
            this.checkBoxTidalMastery.Enabled = false;
            this.checkBoxTidalMastery.Location = new System.Drawing.Point(18, 379);
            this.checkBoxTidalMastery.Name = "checkBoxTidalMastery";
            this.checkBoxTidalMastery.Size = new System.Drawing.Size(89, 17);
            this.checkBoxTidalMastery.TabIndex = 37;
            this.checkBoxTidalMastery.Text = "Tidal Mastery";
            this.checkBoxTidalMastery.UseVisualStyleBackColor = true;
            this.checkBoxTidalMastery.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxMoonkinForm
            // 
            this.checkBoxMoonkinForm.AutoSize = true;
            this.checkBoxMoonkinForm.Enabled = false;
            this.checkBoxMoonkinForm.Location = new System.Drawing.Point(18, 402);
            this.checkBoxMoonkinForm.Name = "checkBoxMoonkinForm";
            this.checkBoxMoonkinForm.Size = new System.Drawing.Size(171, 17);
            this.checkBoxMoonkinForm.TabIndex = 38;
            this.checkBoxMoonkinForm.Text = "Moonkin Form(Elemental Oath)";
            this.checkBoxMoonkinForm.UseVisualStyleBackColor = true;
            this.checkBoxMoonkinForm.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxTidalWavesCrit
            // 
            this.checkBoxTidalWavesCrit.AutoSize = true;
            this.checkBoxTidalWavesCrit.Enabled = false;
            this.checkBoxTidalWavesCrit.Location = new System.Drawing.Point(18, 425);
            this.checkBoxTidalWavesCrit.Name = "checkBoxTidalWavesCrit";
            this.checkBoxTidalWavesCrit.Size = new System.Drawing.Size(109, 17);
            this.checkBoxTidalWavesCrit.TabIndex = 39;
            this.checkBoxTidalWavesCrit.Text = "Tidal Waves - crit";
            this.checkBoxTidalWavesCrit.UseVisualStyleBackColor = true;
            this.checkBoxTidalWavesCrit.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 502);
            this.Controls.Add(this.checkBoxTidalWavesCrit);
            this.Controls.Add(this.checkBoxMoonkinForm);
            this.Controls.Add(this.checkBoxTidalMastery);
            this.Controls.Add(this.labelCritModifiers);
            this.Controls.Add(this.checkBoxTidalWaves);
            this.Controls.Add(this.checkBoxRapidCurrents);
            this.Controls.Add(this.checkBoxBloodlust);
            this.Controls.Add(this.checkBoxSwiftRetribution);
            this.Controls.Add(this.checkBoxWrathOfTheAirTotem);
            this.Controls.Add(this.labelHasteModifiers);
            this.Controls.Add(this.checkBoxGlyphOfLHW);
            this.Controls.Add(this.checkBoxGyphOfHST);
            this.Controls.Add(this.checkBoxGlyphOfEarthShield);
            this.Controls.Add(this.checkBoxRiptidesConsumption);
            this.Controls.Add(this.checkBoxEmeraldVigor);
            this.Controls.Add(this.checkBoxHellscream);
            this.Controls.Add(this.checkBoxTreeOfLife);
            this.Controls.Add(this.labelHealingModifiers);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxHitTo);
            this.Controls.Add(this.labelDash);
            this.Controls.Add(this.textBoxHitFrom);
            this.Controls.Add(this.labelHit);
            this.Controls.Add(this.textBoxHaste);
            this.Controls.Add(this.labelHaste);
            this.Controls.Add(this.textBoxCrit);
            this.Controls.Add(this.labelCrit);
            this.Controls.Add(this.comboBoxSpell);
            this.Controls.Add(this.textBoxSpellPower);
            this.Controls.Add(this.labelSpellPower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Advanced Restoration Shaman Calculator (WotLK 3.3.5) - Warmane Edition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpellPower;
        private System.Windows.Forms.TextBox textBoxSpellPower;
        private System.Windows.Forms.ComboBox comboBoxSpell;
        private System.Windows.Forms.TextBox textBoxCrit;
        private System.Windows.Forms.Label labelCrit;
        private System.Windows.Forms.TextBox textBoxHaste;
        private System.Windows.Forms.Label labelHaste;
        private System.Windows.Forms.Label labelHit;
        private System.Windows.Forms.TextBox textBoxHitFrom;
        private System.Windows.Forms.Label labelDash;
        private System.Windows.Forms.TextBox textBoxHitTo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.Label labelHealingModifiers;
        private System.Windows.Forms.CheckBox checkBoxTreeOfLife;
        private System.Windows.Forms.CheckBox checkBoxHellscream;
        private System.Windows.Forms.CheckBox checkBoxEmeraldVigor;
        private System.Windows.Forms.CheckBox checkBoxRiptidesConsumption;
        private System.Windows.Forms.CheckBox checkBoxGlyphOfEarthShield;
        private System.Windows.Forms.CheckBox checkBoxGyphOfHST;
        private System.Windows.Forms.CheckBox checkBoxGlyphOfLHW;
        private System.Windows.Forms.Label labelHasteModifiers;
        private System.Windows.Forms.CheckBox checkBoxWrathOfTheAirTotem;
        private System.Windows.Forms.CheckBox checkBoxSwiftRetribution;
        private System.Windows.Forms.CheckBox checkBoxBloodlust;
        private System.Windows.Forms.CheckBox checkBoxRapidCurrents;
        private System.Windows.Forms.CheckBox checkBoxTidalWaves;
        private System.Windows.Forms.Label labelCritModifiers;
        private System.Windows.Forms.CheckBox checkBoxTidalMastery;
        private System.Windows.Forms.CheckBox checkBoxMoonkinForm;
        private System.Windows.Forms.CheckBox checkBoxTidalWavesCrit;
    }
}

