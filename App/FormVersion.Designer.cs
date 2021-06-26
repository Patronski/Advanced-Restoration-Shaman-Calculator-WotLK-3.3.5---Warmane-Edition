
namespace App
{
    partial class FormVersion
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
            this.richTextBoxChangelog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxChangelog
            // 
            this.richTextBoxChangelog.Location = new System.Drawing.Point(190, 116);
            this.richTextBoxChangelog.Name = "richTextBoxChangelog";
            this.richTextBoxChangelog.Size = new System.Drawing.Size(421, 218);
            this.richTextBoxChangelog.TabIndex = 1;
            this.richTextBoxChangelog.Text = "dsdsads\ndsd\nDsd";
            // 
            // FormVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxChangelog);
            this.Name = "FormVersion";
            this.Text = "Changelog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxChangelog;
    }
}