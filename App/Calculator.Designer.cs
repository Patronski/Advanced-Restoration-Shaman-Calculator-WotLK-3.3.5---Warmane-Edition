﻿namespace App
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
            this.labelSpell = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelSpellPower
            // 
            this.labelSpellPower.AutoSize = true;
            this.labelSpellPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpellPower.Location = new System.Drawing.Point(360, 39);
            this.labelSpellPower.Name = "labelSpellPower";
            this.labelSpellPower.Size = new System.Drawing.Size(95, 16);
            this.labelSpellPower.TabIndex = 0;
            this.labelSpellPower.Text = "Spell Power:";
            // 
            // textBoxSpellPower
            // 
            this.textBoxSpellPower.Location = new System.Drawing.Point(461, 38);
            this.textBoxSpellPower.MaxLength = 9;
            this.textBoxSpellPower.Name = "textBoxSpellPower";
            this.textBoxSpellPower.Size = new System.Drawing.Size(77, 20);
            this.textBoxSpellPower.TabIndex = 1;
            this.textBoxSpellPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpellPower_KeyPress);
            // 
            // comboBoxSpell
            // 
            this.comboBoxSpell.FormattingEnabled = true;
            this.comboBoxSpell.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSpell.Name = "comboBoxSpell";
            this.comboBoxSpell.Size = new System.Drawing.Size(131, 21);
            this.comboBoxSpell.TabIndex = 2;
            this.comboBoxSpell.Text = "Select spell";
            this.comboBoxSpell.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpell_SelectedIndexChanged);
            // 
            // labelSpell
            // 
            this.labelSpell.AutoSize = true;
            this.labelSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpell.Location = new System.Drawing.Point(360, 71);
            this.labelSpell.Name = "labelSpell";
            this.labelSpell.Size = new System.Drawing.Size(39, 13);
            this.labelSpell.TabIndex = 4;
            this.labelSpell.Text = "Spell:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(386, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 235);
            this.panel1.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSpell);
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
        private System.Windows.Forms.Label labelSpell;
        private System.Windows.Forms.Panel panel1;
    }
}

