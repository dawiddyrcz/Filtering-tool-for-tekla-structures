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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exportAll_button = new System.Windows.Forms.Button();
            this.ignoreAll_button = new System.Windows.Forms.Button();
            this.exportSelected_button = new System.Windows.Forms.Button();
            this.ignoreSelected_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.abort_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(534, 329);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 32);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select phases to export";
            // 
            // exportAll_button
            // 
            this.exportAll_button.Location = new System.Drawing.Point(5, 109);
            this.exportAll_button.Name = "exportAll_button";
            this.exportAll_button.Size = new System.Drawing.Size(88, 23);
            this.exportAll_button.TabIndex = 5;
            this.exportAll_button.Text = "Export all";
            this.exportAll_button.UseVisualStyleBackColor = true;
            this.exportAll_button.Click += new System.EventHandler(this.OverrideAll_button_Click);
            // 
            // ignoreAll_button
            // 
            this.ignoreAll_button.Location = new System.Drawing.Point(3, 32);
            this.ignoreAll_button.Name = "ignoreAll_button";
            this.ignoreAll_button.Size = new System.Drawing.Size(88, 23);
            this.ignoreAll_button.TabIndex = 4;
            this.ignoreAll_button.Text = "Ignore all";
            this.ignoreAll_button.UseVisualStyleBackColor = true;
            this.ignoreAll_button.Click += new System.EventHandler(this.IgnoreAll_button_Click);
            // 
            // exportSelected_button
            // 
            this.exportSelected_button.Location = new System.Drawing.Point(5, 80);
            this.exportSelected_button.Name = "exportSelected_button";
            this.exportSelected_button.Size = new System.Drawing.Size(88, 23);
            this.exportSelected_button.TabIndex = 3;
            this.exportSelected_button.Text = "Export selected";
            this.exportSelected_button.UseVisualStyleBackColor = true;
            this.exportSelected_button.Click += new System.EventHandler(this.OverrideSelected_button_Click);
            // 
            // ignoreSelected_button
            // 
            this.ignoreSelected_button.Location = new System.Drawing.Point(3, 3);
            this.ignoreSelected_button.Name = "ignoreSelected_button";
            this.ignoreSelected_button.Size = new System.Drawing.Size(88, 23);
            this.ignoreSelected_button.TabIndex = 2;
            this.ignoreSelected_button.Text = "Ignore selected";
            this.ignoreSelected_button.UseVisualStyleBackColor = true;
            this.ignoreSelected_button.Click += new System.EventHandler(this.IgnoreSelected_button_Click);
            // 
            // export_button
            // 
            this.export_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.export_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.export_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export_button.Location = new System.Drawing.Point(418, 2);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(113, 27);
            this.export_button.TabIndex = 1;
            this.export_button.Text = "Export phases";
            this.export_button.UseVisualStyleBackColor = true;
            // 
            // abort_button
            // 
            this.abort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abort_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.abort_button.Location = new System.Drawing.Point(3, 2);
            this.abort_button.Name = "abort_button";
            this.abort_button.Size = new System.Drawing.Size(126, 27);
            this.abort_button.TabIndex = 0;
            this.abort_button.Text = "Abort export";
            this.abort_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.abort_button);
            this.panel1.Controls.Add(this.export_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 31);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exportAll_button);
            this.panel2.Controls.Add(this.ignoreSelected_button);
            this.panel2.Controls.Add(this.exportSelected_button);
            this.panel2.Controls.Add(this.ignoreAll_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(438, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 298);
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
            // ExportPhasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abort_button;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "ExportPhasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Tool Export Phases";
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
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Button exportSelected_button;
        private System.Windows.Forms.Button ignoreSelected_button;
        private System.Windows.Forms.Button exportAll_button;
        private System.Windows.Forms.Button ignoreAll_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}