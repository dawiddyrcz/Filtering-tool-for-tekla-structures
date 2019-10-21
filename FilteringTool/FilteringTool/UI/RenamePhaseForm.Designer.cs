/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class RenamePhaseForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox phaseName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyPhase_button;
        private System.Windows.Forms.Button cancel_button;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenamePhaseForm));
            this.phaseName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyPhase_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phaseName_textBox
            // 
            this.phaseName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phaseName_textBox.Location = new System.Drawing.Point(0, 28);
            this.phaseName_textBox.Name = "phaseName_textBox";
            this.phaseName_textBox.Size = new System.Drawing.Size(294, 20);
            this.phaseName_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phase name:";
            // 
            // modifyPhase_button
            // 
            this.modifyPhase_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modifyPhase_button.BackColor = System.Drawing.SystemColors.Window;
            this.modifyPhase_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyPhase_button.Location = new System.Drawing.Point(0, 59);
            this.modifyPhase_button.Name = "modifyPhase_button";
            this.modifyPhase_button.Size = new System.Drawing.Size(109, 23);
            this.modifyPhase_button.TabIndex = 4;
            this.modifyPhase_button.Text = "Rename phase";
            this.modifyPhase_button.UseVisualStyleBackColor = false;
            this.modifyPhase_button.Click += new System.EventHandler(this.RenamePhase_buttonClick);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.BackColor = System.Drawing.SystemColors.Window;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Location = new System.Drawing.Point(181, 59);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(113, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_buttonClick);
            // 
            // RenamePhaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(294, 86);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.modifyPhase_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phaseName_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(310, 125);
            this.Name = "RenamePhaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rename phase";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

