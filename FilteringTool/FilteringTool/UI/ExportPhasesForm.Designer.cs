/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class ExportPhasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportPhasesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.exportAll_button = new System.Windows.Forms.Button();
            this.ignoreAll_button = new System.Windows.Forms.Button();
            this.exportSelected_button = new System.Windows.Forms.Button();
            this.ignoreSelected_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
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
            this.Column4});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 5);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 392);
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
            this.Column2.HeaderText = "Phase name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select phases to export";
            // 
            // exportAll_button
            // 
            this.exportAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exportAll_button.AutoSize = true;
            this.exportAll_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportAll_button.Location = new System.Drawing.Point(520, 106);
            this.exportAll_button.Margin = new System.Windows.Forms.Padding(1);
            this.exportAll_button.Name = "exportAll_button";
            this.exportAll_button.Size = new System.Drawing.Size(102, 25);
            this.exportAll_button.TabIndex = 5;
            this.exportAll_button.Text = "Export all";
            this.exportAll_button.UseVisualStyleBackColor = true;
            this.exportAll_button.Click += new System.EventHandler(this.OverrideAll_button_Click);
            // 
            // ignoreAll_button
            // 
            this.ignoreAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreAll_button.AutoSize = true;
            this.ignoreAll_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ignoreAll_button.Location = new System.Drawing.Point(520, 52);
            this.ignoreAll_button.Margin = new System.Windows.Forms.Padding(1);
            this.ignoreAll_button.Name = "ignoreAll_button";
            this.ignoreAll_button.Size = new System.Drawing.Size(102, 25);
            this.ignoreAll_button.TabIndex = 4;
            this.ignoreAll_button.Text = "Ignore all";
            this.ignoreAll_button.UseVisualStyleBackColor = true;
            this.ignoreAll_button.Click += new System.EventHandler(this.IgnoreAll_button_Click);
            // 
            // exportSelected_button
            // 
            this.exportSelected_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exportSelected_button.AutoSize = true;
            this.exportSelected_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportSelected_button.Location = new System.Drawing.Point(520, 79);
            this.exportSelected_button.Margin = new System.Windows.Forms.Padding(1);
            this.exportSelected_button.Name = "exportSelected_button";
            this.exportSelected_button.Size = new System.Drawing.Size(102, 25);
            this.exportSelected_button.TabIndex = 3;
            this.exportSelected_button.Text = "Export selected";
            this.exportSelected_button.UseVisualStyleBackColor = true;
            this.exportSelected_button.Click += new System.EventHandler(this.OverrideSelected_button_Click);
            // 
            // ignoreSelected_button
            // 
            this.ignoreSelected_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreSelected_button.AutoSize = true;
            this.ignoreSelected_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ignoreSelected_button.Location = new System.Drawing.Point(520, 25);
            this.ignoreSelected_button.Margin = new System.Windows.Forms.Padding(1);
            this.ignoreSelected_button.Name = "ignoreSelected_button";
            this.ignoreSelected_button.Size = new System.Drawing.Size(102, 25);
            this.ignoreSelected_button.TabIndex = 2;
            this.ignoreSelected_button.Text = "Ignore selected";
            this.ignoreSelected_button.UseVisualStyleBackColor = true;
            this.ignoreSelected_button.Click += new System.EventHandler(this.IgnoreSelected_button_Click);
            // 
            // export_button
            // 
            this.export_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.export_button.AutoSize = true;
            this.export_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.export_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.export_button.Location = new System.Drawing.Point(522, 419);
            this.export_button.Margin = new System.Windows.Forms.Padding(1);
            this.export_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(100, 25);
            this.export_button.TabIndex = 1;
            this.export_button.Text = "Export phases";
            this.export_button.UseVisualStyleBackColor = true;
            // 
            // abort_button
            // 
            this.abort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abort_button.AutoSize = true;
            this.abort_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abort_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abort_button.Location = new System.Drawing.Point(1, 419);
            this.abort_button.Margin = new System.Windows.Forms.Padding(1);
            this.abort_button.MinimumSize = new System.Drawing.Size(100, 25);
            this.abort_button.Name = "abort_button";
            this.abort_button.Size = new System.Drawing.Size(100, 25);
            this.abort_button.TabIndex = 0;
            this.abort_button.Text = "Abort export";
            this.abort_button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.export_button, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.abort_button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exportAll_button, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ignoreSelected_button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportSelected_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ignoreAll_button, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 445);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ExportPhasesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.abort_button;
            this.ClientSize = new System.Drawing.Size(623, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(639, 484);
            this.Name = "ExportPhasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Tool Export Phases";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button abort_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Button exportSelected_button;
        private System.Windows.Forms.Button ignoreSelected_button;
        private System.Windows.Forms.Button exportAll_button;
        private System.Windows.Forms.Button ignoreAll_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}