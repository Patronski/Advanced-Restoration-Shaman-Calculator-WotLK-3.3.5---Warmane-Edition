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
            this.flowLayoutPanelModifiers = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxCrit = new System.Windows.Forms.TextBox();
            this.labelCrit = new System.Windows.Forms.Label();
            this.textBoxHaste = new System.Windows.Forms.TextBox();
            this.labelHaste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSpellPower
            // 
            this.labelSpellPower.AutoSize = true;
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
            this.textBoxSpellPower.MaxLength = 9;
            this.textBoxSpellPower.Name = "textBoxSpellPower";
            this.textBoxSpellPower.Size = new System.Drawing.Size(77, 20);
            this.textBoxSpellPower.TabIndex = 1;
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
            // flowLayoutPanelModifiers
            // 
            this.flowLayoutPanelModifiers.Location = new System.Drawing.Point(12, 87);
            this.flowLayoutPanelModifiers.Name = "flowLayoutPanelModifiers";
            this.flowLayoutPanelModifiers.Size = new System.Drawing.Size(233, 330);
            this.flowLayoutPanelModifiers.TabIndex = 7;
            // 
            // textBoxCrit
            // 
            this.textBoxCrit.Location = new System.Drawing.Point(685, 35);
            this.textBoxCrit.MaxLength = 9;
            this.textBoxCrit.Name = "textBoxCrit";
            this.textBoxCrit.Size = new System.Drawing.Size(88, 20);
            this.textBoxCrit.TabIndex = 9;
            // 
            // labelCrit
            // 
            this.labelCrit.AutoSize = true;
            this.labelCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrit.Location = new System.Drawing.Point(682, 13);
            this.labelCrit.Name = "labelCrit";
            this.labelCrit.Size = new System.Drawing.Size(91, 16);
            this.labelCrit.TabIndex = 8;
            this.labelCrit.Text = "Crit Chance:";
            // 
            // textBoxHaste
            // 
            this.textBoxHaste.Location = new System.Drawing.Point(505, 35);
            this.textBoxHaste.MaxLength = 9;
            this.textBoxHaste.Name = "textBoxHaste";
            this.textBoxHaste.Size = new System.Drawing.Size(99, 20);
            this.textBoxHaste.TabIndex = 11;
            // 
            // labelHaste
            // 
            this.labelHaste.AutoSize = true;
            this.labelHaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHaste.Location = new System.Drawing.Point(502, 13);
            this.labelHaste.Name = "labelHaste";
            this.labelHaste.Size = new System.Drawing.Size(102, 16);
            this.labelHaste.TabIndex = 10;
            this.labelHaste.Text = "Haste Rating:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.textBoxHaste);
            this.Controls.Add(this.labelHaste);
            this.Controls.Add(this.textBoxCrit);
            this.Controls.Add(this.labelCrit);
            this.Controls.Add(this.flowLayoutPanelModifiers);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelModifiers;
        private System.Windows.Forms.TextBox textBoxCrit;
        private System.Windows.Forms.Label labelCrit;
        private System.Windows.Forms.TextBox textBoxHaste;
        private System.Windows.Forms.Label labelHaste;
    }
}

