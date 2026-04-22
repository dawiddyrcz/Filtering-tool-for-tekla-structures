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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.overrideAll_button = new System.Windows.Forms.Button();
            this.ignoreAll_button = new System.Windows.Forms.Button();
            this.overrideSelected_button = new System.Windows.Forms.Button();
            this.ignoreSelected_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.abort_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 5);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 317);
            this.dataGridView1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select phases to import";
            // 
            // overrideAll_button
            // 
            this.overrideAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overrideAll_button.AutoSize = true;
            this.overrideAll_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.overrideAll_button.Location = new System.Drawing.Point(568, 107);
            this.overrideAll_button.Margin = new System.Windows.Forms.Padding(1);
            this.overrideAll_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.overrideAll_button.Name = "overrideAll_button";
            this.overrideAll_button.Size = new System.Drawing.Size(100, 25);
            this.overrideAll_button.TabIndex = 5;
            this.overrideAll_button.Text = "Import all";
            this.overrideAll_button.UseVisualStyleBackColor = true;
            this.overrideAll_button.Click += new System.EventHandler(this.OverrideAll_button_Click);
            // 
            // ignoreAll_button
            // 
            this.ignoreAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreAll_button.AutoSize = true;
            this.ignoreAll_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ignoreAll_button.Location = new System.Drawing.Point(568, 53);
            this.ignoreAll_button.Margin = new System.Windows.Forms.Padding(1);
            this.ignoreAll_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.ignoreAll_button.Name = "ignoreAll_button";
            this.ignoreAll_button.Size = new System.Drawing.Size(100, 25);
            this.ignoreAll_button.TabIndex = 4;
            this.ignoreAll_button.Text = "Ignore all";
            this.ignoreAll_button.UseVisualStyleBackColor = true;
            this.ignoreAll_button.Click += new System.EventHandler(this.IgnoreAll_button_Click);
            // 
            // overrideSelected_button
            // 
            this.overrideSelected_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overrideSelected_button.AutoSize = true;
            this.overrideSelected_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.overrideSelected_button.Location = new System.Drawing.Point(566, 80);
            this.overrideSelected_button.Margin = new System.Windows.Forms.Padding(1);
            this.overrideSelected_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.overrideSelected_button.Name = "overrideSelected_button";
            this.overrideSelected_button.Size = new System.Drawing.Size(102, 25);
            this.overrideSelected_button.TabIndex = 3;
            this.overrideSelected_button.Text = "Import selected";
            this.overrideSelected_button.UseVisualStyleBackColor = true;
            this.overrideSelected_button.Click += new System.EventHandler(this.OverrideSelected_button_Click);
            // 
            // ignoreSelected_button
            // 
            this.ignoreSelected_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreSelected_button.AutoSize = true;
            this.ignoreSelected_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ignoreSelected_button.Location = new System.Drawing.Point(566, 26);
            this.ignoreSelected_button.Margin = new System.Windows.Forms.Padding(1);
            this.ignoreSelected_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.ignoreSelected_button.Name = "ignoreSelected_button";
            this.ignoreSelected_button.Size = new System.Drawing.Size(102, 25);
            this.ignoreSelected_button.TabIndex = 2;
            this.ignoreSelected_button.Text = "Ignore selected";
            this.ignoreSelected_button.UseVisualStyleBackColor = true;
            this.ignoreSelected_button.Click += new System.EventHandler(this.IgnoreSelected_button_Click);
            // 
            // import_button
            // 
            this.import_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.import_button.AutoSize = true;
            this.import_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.import_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.import_button.Location = new System.Drawing.Point(568, 345);
            this.import_button.Margin = new System.Windows.Forms.Padding(1);
            this.import_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(100, 25);
            this.import_button.TabIndex = 1;
            this.import_button.Text = "Import";
            this.import_button.UseVisualStyleBackColor = true;
            // 
            // abort_button
            // 
            this.abort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abort_button.AutoSize = true;
            this.abort_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abort_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abort_button.Location = new System.Drawing.Point(1, 345);
            this.abort_button.Margin = new System.Windows.Forms.Padding(1);
            this.abort_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.abort_button.Name = "abort_button";
            this.abort_button.Size = new System.Drawing.Size(100, 25);
            this.abort_button.TabIndex = 0;
            this.abort_button.Text = "Abort";
            this.abort_button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.abort_button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.import_button, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.overrideAll_button, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.overrideSelected_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ignoreAll_button, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ignoreSelected_button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 371);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ImportPhasesConflictForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.abort_button;
            this.ClientSize = new System.Drawing.Size(669, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(685, 300);
            this.Name = "ImportPhasesConflictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Tool Import Phases";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button abort_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button overrideSelected_button;
        private System.Windows.Forms.Button ignoreSelected_button;
        private System.Windows.Forms.Button overrideAll_button;
        private System.Windows.Forms.Button ignoreAll_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}