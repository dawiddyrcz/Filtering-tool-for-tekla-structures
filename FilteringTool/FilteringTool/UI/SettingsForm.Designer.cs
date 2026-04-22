/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.cancel_button = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.rebarInfo_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.partInfo_textBox = new System.Windows.Forms.TextBox();
            this.boltInfo_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.assemblyInfo_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.component_checkBox = new System.Windows.Forms.CheckBox();
            this.weldFilter_checkBox = new System.Windows.Forms.CheckBox();
            this.addRebarFilter_checkBox = new System.Windows.Forms.CheckBox();
            this.onlySelViews_checkBox = new System.Windows.Forms.CheckBox();
            this.showObjectInfoInTekla_checkBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterType_label = new System.Windows.Forms.Label();
            this.assembly_radioButton = new System.Windows.Forms.RadioButton();
            this.part_radioButton = new System.Windows.Forms.RadioButton();
            this.obj_radioButton = new System.Windows.Forms.RadioButton();
            this.bolt_radioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.main_panel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.AutoSize = true;
            this.cancel_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(523, 1);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(1);
            this.cancel_button.MinimumSize = new System.Drawing.Size(100, 0);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 26);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // apply_button
            // 
            this.apply_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apply_button.AutoSize = true;
            this.apply_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.apply_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.apply_button.Location = new System.Drawing.Point(1, 1);
            this.apply_button.Margin = new System.Windows.Forms.Padding(1);
            this.apply_button.MinimumSize = new System.Drawing.Size(100, 0);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(100, 26);
            this.apply_button.TabIndex = 1;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Controls.Add(this.tableLayoutPanel4);
            this.main_panel.Controls.Add(this.tableLayoutPanel5);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(624, 431);
            this.main_panel.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(624, 403);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rebarInfo_textBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.partInfo_textBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.boltInfo_textBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.assemblyInfo_textBox, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 220);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(618, 134);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Object info settings:";
            // 
            // rebarInfo_textBox
            // 
            this.rebarInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rebarInfo_textBox.Location = new System.Drawing.Point(149, 109);
            this.rebarInfo_textBox.Name = "rebarInfo_textBox";
            this.rebarInfo_textBox.Size = new System.Drawing.Size(466, 22);
            this.rebarInfo_textBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Part info:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rebar info:";
            // 
            // partInfo_textBox
            // 
            this.partInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partInfo_textBox.Location = new System.Drawing.Point(149, 25);
            this.partInfo_textBox.Name = "partInfo_textBox";
            this.partInfo_textBox.Size = new System.Drawing.Size(466, 22);
            this.partInfo_textBox.TabIndex = 14;
            // 
            // boltInfo_textBox
            // 
            this.boltInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boltInfo_textBox.Location = new System.Drawing.Point(149, 81);
            this.boltInfo_textBox.Name = "boltInfo_textBox";
            this.boltInfo_textBox.Size = new System.Drawing.Size(466, 22);
            this.boltInfo_textBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Assembly info:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bolt info:";
            // 
            // assemblyInfo_textBox
            // 
            this.assemblyInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assemblyInfo_textBox.Location = new System.Drawing.Point(149, 53);
            this.assemblyInfo_textBox.Name = "assemblyInfo_textBox";
            this.assemblyInfo_textBox.Size = new System.Drawing.Size(466, 22);
            this.assemblyInfo_textBox.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.component_checkBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.weldFilter_checkBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addRebarFilter_checkBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.onlySelViews_checkBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.showObjectInfoInTekla_checkBox, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 130);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // component_checkBox
            // 
            this.component_checkBox.AutoSize = true;
            this.component_checkBox.Location = new System.Drawing.Point(3, 3);
            this.component_checkBox.Name = "component_checkBox";
            this.component_checkBox.Size = new System.Drawing.Size(236, 20);
            this.component_checkBox.TabIndex = 8;
            this.component_checkBox.Text = "Add filter:  Component phase equals";
            this.component_checkBox.UseVisualStyleBackColor = true;
            // 
            // weldFilter_checkBox
            // 
            this.weldFilter_checkBox.AutoSize = true;
            this.weldFilter_checkBox.Location = new System.Drawing.Point(3, 29);
            this.weldFilter_checkBox.Name = "weldFilter_checkBox";
            this.weldFilter_checkBox.Size = new System.Drawing.Size(213, 20);
            this.weldFilter_checkBox.TabIndex = 6;
            this.weldFilter_checkBox.Text = "Add filter:  Do not show -1 welds";
            this.weldFilter_checkBox.UseVisualStyleBackColor = true;
            // 
            // addRebarFilter_checkBox
            // 
            this.addRebarFilter_checkBox.AutoSize = true;
            this.addRebarFilter_checkBox.Location = new System.Drawing.Point(3, 107);
            this.addRebarFilter_checkBox.Name = "addRebarFilter_checkBox";
            this.addRebarFilter_checkBox.Size = new System.Drawing.Size(204, 20);
            this.addRebarFilter_checkBox.TabIndex = 15;
            this.addRebarFilter_checkBox.Text = "Add filter:  Rebar phase equals";
            this.addRebarFilter_checkBox.UseVisualStyleBackColor = true;
            // 
            // onlySelViews_checkBox
            // 
            this.onlySelViews_checkBox.AutoSize = true;
            this.onlySelViews_checkBox.Location = new System.Drawing.Point(3, 55);
            this.onlySelViews_checkBox.Name = "onlySelViews_checkBox";
            this.onlySelViews_checkBox.Size = new System.Drawing.Size(186, 20);
            this.onlySelViews_checkBox.TabIndex = 10;
            this.onlySelViews_checkBox.Text = "Change only selected views";
            this.onlySelViews_checkBox.UseVisualStyleBackColor = true;
            // 
            // showObjectInfoInTekla_checkBox
            // 
            this.showObjectInfoInTekla_checkBox.AutoSize = true;
            this.showObjectInfoInTekla_checkBox.Location = new System.Drawing.Point(3, 81);
            this.showObjectInfoInTekla_checkBox.Name = "showObjectInfoInTekla_checkBox";
            this.showObjectInfoInTekla_checkBox.Size = new System.Drawing.Size(465, 20);
            this.showObjectInfoInTekla_checkBox.TabIndex = 11;
            this.showObjectInfoInTekla_checkBox.Text = "Show object info in the bottom of Tekla Structures window (in the status bar)";
            this.showObjectInfoInTekla_checkBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.filterType_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.assembly_radioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.part_radioButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.obj_radioButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bolt_radioButton, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 48);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // filterType_label
            // 
            this.filterType_label.AutoSize = true;
            this.filterType_label.Location = new System.Drawing.Point(3, 3);
            this.filterType_label.Margin = new System.Windows.Forms.Padding(3);
            this.filterType_label.Name = "filterType_label";
            this.filterType_label.Size = new System.Drawing.Size(69, 16);
            this.filterType_label.TabIndex = 0;
            this.filterType_label.Text = "Filter type:";
            // 
            // assembly_radioButton
            // 
            this.assembly_radioButton.AutoSize = true;
            this.assembly_radioButton.Location = new System.Drawing.Point(3, 25);
            this.assembly_radioButton.Name = "assembly_radioButton";
            this.assembly_radioButton.Size = new System.Drawing.Size(83, 20);
            this.assembly_radioButton.TabIndex = 1;
            this.assembly_radioButton.TabStop = true;
            this.assembly_radioButton.Text = "Assembly";
            this.assembly_radioButton.UseVisualStyleBackColor = true;
            // 
            // part_radioButton
            // 
            this.part_radioButton.AutoSize = true;
            this.part_radioButton.Location = new System.Drawing.Point(92, 25);
            this.part_radioButton.Name = "part_radioButton";
            this.part_radioButton.Size = new System.Drawing.Size(49, 20);
            this.part_radioButton.TabIndex = 2;
            this.part_radioButton.TabStop = true;
            this.part_radioButton.Text = "Part";
            this.part_radioButton.UseVisualStyleBackColor = true;
            // 
            // obj_radioButton
            // 
            this.obj_radioButton.AutoSize = true;
            this.obj_radioButton.Location = new System.Drawing.Point(147, 25);
            this.obj_radioButton.Name = "obj_radioButton";
            this.obj_radioButton.Size = new System.Drawing.Size(63, 20);
            this.obj_radioButton.TabIndex = 3;
            this.obj_radioButton.TabStop = true;
            this.obj_radioButton.Text = "Object";
            this.obj_radioButton.UseVisualStyleBackColor = true;
            // 
            // bolt_radioButton
            // 
            this.bolt_radioButton.AutoSize = true;
            this.bolt_radioButton.Location = new System.Drawing.Point(216, 25);
            this.bolt_radioButton.Name = "bolt_radioButton";
            this.bolt_radioButton.Size = new System.Drawing.Size(48, 20);
            this.bolt_radioButton.TabIndex = 4;
            this.bolt_radioButton.TabStop = true;
            this.bolt_radioButton.Text = "Bolt";
            this.bolt_radioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.apply_button, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cancel_button, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 403);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(624, 28);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(624, 431);
            this.Controls.Add(this.main_panel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 470);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Tool Settings";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label filterType_label;
        private System.Windows.Forms.RadioButton bolt_radioButton;
        private System.Windows.Forms.RadioButton obj_radioButton;
        private System.Windows.Forms.RadioButton part_radioButton;
        private System.Windows.Forms.RadioButton assembly_radioButton;
        private System.Windows.Forms.CheckBox weldFilter_checkBox;
        private System.Windows.Forms.CheckBox component_checkBox;
        private System.Windows.Forms.CheckBox onlySelViews_checkBox;
        private System.Windows.Forms.CheckBox showObjectInfoInTekla_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partInfo_textBox;
        private System.Windows.Forms.TextBox boltInfo_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assemblyInfo_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rebarInfo_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox addRebarFilter_checkBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}