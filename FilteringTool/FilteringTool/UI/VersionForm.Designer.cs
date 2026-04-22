/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class VersionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newVersion_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.close_button = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current program version:";
            // 
            // version_label
            // 
            this.version_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.version_label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.version_label, 2);
            this.version_label.Location = new System.Drawing.Point(160, 3);
            this.version_label.Margin = new System.Windows.Forms.Padding(3);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(22, 13);
            this.version_label.TabIndex = 1;
            this.version_label.Text = "1.0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version avaiable to download:";
            // 
            // newVersion_label
            // 
            this.newVersion_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newVersion_label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.newVersion_label, 2);
            this.newVersion_label.Location = new System.Drawing.Point(160, 22);
            this.newVersion_label.Margin = new System.Windows.Forms.Padding(3);
            this.newVersion_label.Name = "newVersion_label";
            this.newVersion_label.Size = new System.Drawing.Size(10, 13);
            this.newVersion_label.TabIndex = 3;
            this.newVersion_label.Text = ".";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Link to download new version:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabel1, 2);
            this.linkLabel1.Location = new System.Drawing.Point(160, 41);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "link";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.AutoSize = true;
            this.close_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_button.Location = new System.Drawing.Point(313, 135);
            this.close_button.Margin = new System.Windows.Forms.Padding(1);
            this.close_button.MinimumSize = new System.Drawing.Size(70, 25);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(70, 25);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            // 
            // info_label
            // 
            this.info_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(3, 145);
            this.info_label.Margin = new System.Windows.Forms.Padding(3);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(16, 13);
            this.info_label.TabIndex = 7;
            this.info_label.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.close_button, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.info_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.version_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newVersion_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 161);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // VersionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.close_button;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "VersionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtering Tool Version";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newVersion_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}