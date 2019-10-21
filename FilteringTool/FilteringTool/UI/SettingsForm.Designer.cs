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
            this.button_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rebarInfo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boltInfo_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assemblyInfo_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partInfo_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showObjectInfoInTekla_checkBox = new System.Windows.Forms.CheckBox();
            this.onlySelViews_checkBox = new System.Windows.Forms.CheckBox();
            this.component_checkBox = new System.Windows.Forms.CheckBox();
            this.weldFilter_checkBox = new System.Windows.Forms.CheckBox();
            this.bolt_radioButton = new System.Windows.Forms.RadioButton();
            this.obj_radioButton = new System.Windows.Forms.RadioButton();
            this.part_radioButton = new System.Windows.Forms.RadioButton();
            this.assembly_radioButton = new System.Windows.Forms.RadioButton();
            this.filterType_label = new System.Windows.Forms.Label();
            this.button_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(437, 6);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(0);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // apply_button
            // 
            this.apply_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apply_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.apply_button.Location = new System.Drawing.Point(9, 6);
            this.apply_button.Margin = new System.Windows.Forms.Padding(0);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 1;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.cancel_button);
            this.button_panel.Controls.Add(this.apply_button);
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_panel.Location = new System.Drawing.Point(0, 293);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(521, 35);
            this.button_panel.TabIndex = 3;
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Controls.Add(this.groupBox1);
            this.main_panel.Controls.Add(this.showObjectInfoInTekla_checkBox);
            this.main_panel.Controls.Add(this.onlySelViews_checkBox);
            this.main_panel.Controls.Add(this.component_checkBox);
            this.main_panel.Controls.Add(this.weldFilter_checkBox);
            this.main_panel.Controls.Add(this.bolt_radioButton);
            this.main_panel.Controls.Add(this.obj_radioButton);
            this.main_panel.Controls.Add(this.part_radioButton);
            this.main_panel.Controls.Add(this.assembly_radioButton);
            this.main_panel.Controls.Add(this.filterType_label);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(521, 293);
            this.main_panel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rebarInfo_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boltInfo_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.assemblyInfo_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.partInfo_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 130);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object info settings";
            // 
            // rebarInfo_textBox
            // 
            this.rebarInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rebarInfo_textBox.Location = new System.Drawing.Point(100, 99);
            this.rebarInfo_textBox.Name = "rebarInfo_textBox";
            this.rebarInfo_textBox.Size = new System.Drawing.Size(400, 20);
            this.rebarInfo_textBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rebar info:";
            // 
            // boltInfo_textBox
            // 
            this.boltInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boltInfo_textBox.Location = new System.Drawing.Point(100, 73);
            this.boltInfo_textBox.Name = "boltInfo_textBox";
            this.boltInfo_textBox.Size = new System.Drawing.Size(400, 20);
            this.boltInfo_textBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bolt info:";
            // 
            // assemblyInfo_textBox
            // 
            this.assemblyInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assemblyInfo_textBox.Location = new System.Drawing.Point(100, 47);
            this.assemblyInfo_textBox.Name = "assemblyInfo_textBox";
            this.assemblyInfo_textBox.Size = new System.Drawing.Size(400, 20);
            this.assemblyInfo_textBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Assembly info:";
            // 
            // partInfo_textBox
            // 
            this.partInfo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partInfo_textBox.Location = new System.Drawing.Point(100, 21);
            this.partInfo_textBox.Name = "partInfo_textBox";
            this.partInfo_textBox.Size = new System.Drawing.Size(400, 20);
            this.partInfo_textBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Part info:";
            // 
            // showObjectInfoInTekla_checkBox
            // 
            this.showObjectInfoInTekla_checkBox.AutoSize = true;
            this.showObjectInfoInTekla_checkBox.Location = new System.Drawing.Point(15, 127);
            this.showObjectInfoInTekla_checkBox.Name = "showObjectInfoInTekla_checkBox";
            this.showObjectInfoInTekla_checkBox.Size = new System.Drawing.Size(385, 17);
            this.showObjectInfoInTekla_checkBox.TabIndex = 11;
            this.showObjectInfoInTekla_checkBox.Text = "Show object info in the bottom of Tekla Structures window (in the status bar)";
            this.showObjectInfoInTekla_checkBox.UseVisualStyleBackColor = true;
            // 
            // onlySelViews_checkBox
            // 
            this.onlySelViews_checkBox.AutoSize = true;
            this.onlySelViews_checkBox.Location = new System.Drawing.Point(15, 104);
            this.onlySelViews_checkBox.Name = "onlySelViews_checkBox";
            this.onlySelViews_checkBox.Size = new System.Drawing.Size(158, 17);
            this.onlySelViews_checkBox.TabIndex = 10;
            this.onlySelViews_checkBox.Text = "Change only selected views";
            this.onlySelViews_checkBox.UseVisualStyleBackColor = true;
            // 
            // component_checkBox
            // 
            this.component_checkBox.AutoSize = true;
            this.component_checkBox.Location = new System.Drawing.Point(15, 58);
            this.component_checkBox.Name = "component_checkBox";
            this.component_checkBox.Size = new System.Drawing.Size(196, 17);
            this.component_checkBox.TabIndex = 8;
            this.component_checkBox.Text = "Add filter:  Component phase equals";
            this.component_checkBox.UseVisualStyleBackColor = true;
            // 
            // weldFilter_checkBox
            // 
            this.weldFilter_checkBox.AutoSize = true;
            this.weldFilter_checkBox.Location = new System.Drawing.Point(15, 81);
            this.weldFilter_checkBox.Name = "weldFilter_checkBox";
            this.weldFilter_checkBox.Size = new System.Drawing.Size(178, 17);
            this.weldFilter_checkBox.TabIndex = 6;
            this.weldFilter_checkBox.Text = "Add filter:  Do not show -1 welds";
            this.weldFilter_checkBox.UseVisualStyleBackColor = true;
            // 
            // bolt_radioButton
            // 
            this.bolt_radioButton.AutoSize = true;
            this.bolt_radioButton.Location = new System.Drawing.Point(199, 26);
            this.bolt_radioButton.Name = "bolt_radioButton";
            this.bolt_radioButton.Size = new System.Drawing.Size(43, 17);
            this.bolt_radioButton.TabIndex = 4;
            this.bolt_radioButton.TabStop = true;
            this.bolt_radioButton.Text = "Bolt";
            this.bolt_radioButton.UseVisualStyleBackColor = true;
            // 
            // obj_radioButton
            // 
            this.obj_radioButton.AutoSize = true;
            this.obj_radioButton.Location = new System.Drawing.Point(137, 26);
            this.obj_radioButton.Name = "obj_radioButton";
            this.obj_radioButton.Size = new System.Drawing.Size(56, 17);
            this.obj_radioButton.TabIndex = 3;
            this.obj_radioButton.TabStop = true;
            this.obj_radioButton.Text = "Object";
            this.obj_radioButton.UseVisualStyleBackColor = true;
            // 
            // part_radioButton
            // 
            this.part_radioButton.AutoSize = true;
            this.part_radioButton.Location = new System.Drawing.Point(90, 26);
            this.part_radioButton.Name = "part_radioButton";
            this.part_radioButton.Size = new System.Drawing.Size(44, 17);
            this.part_radioButton.TabIndex = 2;
            this.part_radioButton.TabStop = true;
            this.part_radioButton.Text = "Part";
            this.part_radioButton.UseVisualStyleBackColor = true;
            // 
            // assembly_radioButton
            // 
            this.assembly_radioButton.AutoSize = true;
            this.assembly_radioButton.Location = new System.Drawing.Point(15, 26);
            this.assembly_radioButton.Name = "assembly_radioButton";
            this.assembly_radioButton.Size = new System.Drawing.Size(69, 17);
            this.assembly_radioButton.TabIndex = 1;
            this.assembly_radioButton.TabStop = true;
            this.assembly_radioButton.Text = "Assembly";
            this.assembly_radioButton.UseVisualStyleBackColor = true;
            // 
            // filterType_label
            // 
            this.filterType_label.AutoSize = true;
            this.filterType_label.Location = new System.Drawing.Point(12, 9);
            this.filterType_label.Name = "filterType_label";
            this.filterType_label.Size = new System.Drawing.Size(55, 13);
            this.filterType_label.TabIndex = 0;
            this.filterType_label.Text = "Filter type:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(521, 328);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.button_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Tool Settings";
            this.button_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Panel button_panel;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox partInfo_textBox;
        private System.Windows.Forms.TextBox boltInfo_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assemblyInfo_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rebarInfo_textBox;
        private System.Windows.Forms.Label label4;
    }
}