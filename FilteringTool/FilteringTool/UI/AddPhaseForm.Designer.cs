/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class AddPhaseForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox phaseNumber_textBox;
        private System.Windows.Forms.TextBox phaseName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPhase_button;
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
            this.phaseNumber_textBox = new System.Windows.Forms.TextBox();
            this.phaseName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPhase_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phaseNumber_textBox
            // 
            this.phaseNumber_textBox.Location = new System.Drawing.Point(0, 22);
            this.phaseNumber_textBox.Name = "phaseNumber_textBox";
            this.phaseNumber_textBox.Size = new System.Drawing.Size(294, 20);
            this.phaseNumber_textBox.TabIndex = 0;
            // 
            // phaseName_textBox
            // 
            this.phaseName_textBox.Location = new System.Drawing.Point(0, 63);
            this.phaseName_textBox.Name = "phaseName_textBox";
            this.phaseName_textBox.Size = new System.Drawing.Size(294, 20);
            this.phaseName_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phase number:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phase name:";
            // 
            // addPhase_button
            // 
            this.addPhase_button.BackColor = System.Drawing.SystemColors.Window;
            this.addPhase_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPhase_button.Location = new System.Drawing.Point(0, 89);
            this.addPhase_button.Name = "addPhase_button";
            this.addPhase_button.Size = new System.Drawing.Size(109, 23);
            this.addPhase_button.TabIndex = 4;
            this.addPhase_button.Text = "Add";
            this.addPhase_button.UseVisualStyleBackColor = false;
            this.addPhase_button.Click += new System.EventHandler(this.AddPhase_buttonClick);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.Window;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Location = new System.Drawing.Point(181, 89);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(113, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_buttonClick);
            // 
            // AddPhaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(294, 116);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addPhase_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phaseName_textBox);
            this.Controls.Add(this.phaseNumber_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(310, 155);
            this.MinimumSize = new System.Drawing.Size(310, 155);
            this.Name = "AddPhaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add new phase";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

