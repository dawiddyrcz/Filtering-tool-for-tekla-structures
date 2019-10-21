/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class SelectCheckedListBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllPhasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAllPhasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(151, 214);
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.View_checkedListBox_MouseMove);
            this.checkedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBoxMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllPhasesToolStripMenuItem,
            this.unselectAllPhasesToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // selectAllPhasesToolStripMenuItem
            // 
            this.selectAllPhasesToolStripMenuItem.Name = "selectAllPhasesToolStripMenuItem";
            this.selectAllPhasesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectAllPhasesToolStripMenuItem.Text = "Select all phases";
            this.selectAllPhasesToolStripMenuItem.Click += new System.EventHandler(this.SelectAllPhasesToolStripMenuItem_Click);
            // 
            // unselectAllPhasesToolStripMenuItem
            // 
            this.unselectAllPhasesToolStripMenuItem.Name = "unselectAllPhasesToolStripMenuItem";
            this.unselectAllPhasesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.unselectAllPhasesToolStripMenuItem.Text = "Unselect all phases";
            this.unselectAllPhasesToolStripMenuItem.Click += new System.EventHandler(this.UnselectAllPhasesToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // SelectCheckedListBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox);
            this.Name = "SelectCheckedListBoxControl";
            this.Size = new System.Drawing.Size(126, 240);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllPhasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectAllPhasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
