/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class ImportPhasesConflictForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportPhasesConflictForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.overrideAll_button = new System.Windows.Forms.Button();
            this.ignoreAll_button = new System.Windows.Forms.Button();
            this.overrideSelected_button = new System.Windows.Forms.Button();
            this.ignoreSelected_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.abort_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(572, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 35);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select phases to import";
            // 
            // overrideAll_button
            // 
            this.overrideAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overrideAll_button.Location = new System.Drawing.Point(0, 121);
            this.overrideAll_button.Name = "overrideAll_button";
            this.overrideAll_button.Size = new System.Drawing.Size(87, 25);
            this.overrideAll_button.TabIndex = 5;
            this.overrideAll_button.Text = "Import all";
            this.overrideAll_button.UseVisualStyleBackColor = true;
            this.overrideAll_button.Click += new System.EventHandler(this.OverrideAll_button_Click);
            // 
            // ignoreAll_button
            // 
            this.ignoreAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreAll_button.Location = new System.Drawing.Point(0, 35);
            this.ignoreAll_button.Name = "ignoreAll_button";
            this.ignoreAll_button.Size = new System.Drawing.Size(88, 23);
            this.ignoreAll_button.TabIndex = 4;
            this.ignoreAll_button.Text = "Ignore all";
            this.ignoreAll_button.UseVisualStyleBackColor = true;
            this.ignoreAll_button.Click += new System.EventHandler(this.IgnoreAll_button_Click);
            // 
            // overrideSelected_button
            // 
            this.overrideSelected_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overrideSelected_button.Location = new System.Drawing.Point(0, 89);
            this.overrideSelected_button.Name = "overrideSelected_button";
            this.overrideSelected_button.Size = new System.Drawing.Size(88, 26);
            this.overrideSelected_button.TabIndex = 3;
            this.overrideSelected_button.Text = "Import selected";
            this.overrideSelected_button.UseVisualStyleBackColor = true;
            this.overrideSelected_button.Click += new System.EventHandler(this.OverrideSelected_button_Click);
            // 
            // ignoreSelected_button
            // 
            this.ignoreSelected_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreSelected_button.Location = new System.Drawing.Point(0, 6);
            this.ignoreSelected_button.Name = "ignoreSelected_button";
            this.ignoreSelected_button.Size = new System.Drawing.Size(88, 23);
            this.ignoreSelected_button.TabIndex = 2;
            this.ignoreSelected_button.Text = "Ignore selected";
            this.ignoreSelected_button.UseVisualStyleBackColor = true;
            this.ignoreSelected_button.Click += new System.EventHandler(this.IgnoreSelected_button_Click);
            // 
            // import_button
            // 
            this.import_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.import_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.import_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.import_button.Location = new System.Drawing.Point(553, 0);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(113, 28);
            this.import_button.TabIndex = 1;
            this.import_button.Text = "Import";
            this.import_button.UseVisualStyleBackColor = true;
            // 
            // abort_button
            // 
            this.abort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abort_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.abort_button.Location = new System.Drawing.Point(3, 0);
            this.abort_button.Name = "abort_button";
            this.abort_button.Size = new System.Drawing.Size(114, 28);
            this.abort_button.TabIndex = 0;
            this.abort_button.Text = "Abort";
            this.abort_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.import_button);
            this.panel1.Controls.Add(this.abort_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 32);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.overrideAll_button);
            this.panel2.Controls.Add(this.ignoreSelected_button);
            this.panel2.Controls.Add(this.overrideSelected_button);
            this.panel2.Controls.Add(this.ignoreAll_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(578, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 293);
            this.panel2.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Number";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Old name / old comment";
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "New name / new comment";
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // ImportPhasesConflictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abort_button;
            this.ClientSize = new System.Drawing.Size(669, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(685, 300);
            this.Name = "ImportPhasesConflictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Tool Import Phases";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button abort_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button overrideSelected_button;
        private System.Windows.Forms.Button ignoreSelected_button;
        private System.Windows.Forms.Button overrideAll_button;
        private System.Windows.Forms.Button ignoreAll_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}