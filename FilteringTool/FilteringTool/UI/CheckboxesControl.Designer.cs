/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class CheckboxesControl
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bolt_checkBox = new System.Windows.Forms.CheckBox();
            this.holes_checkBox = new System.Windows.Forms.CheckBox();
            this.lines_checkBox = new System.Windows.Forms.CheckBox();
            this.loads_checkBox = new System.Windows.Forms.CheckBox();
            this.unSelectCheck_checkBox = new System.Windows.Forms.CheckBox();
            this.weld_checkBox = new System.Windows.Forms.CheckBox();
            this.selectCheck_checkBox = new System.Windows.Forms.CheckBox();
            this.rebars_checkBox = new System.Windows.Forms.CheckBox();
            this.points_checkBox = new System.Windows.Forms.CheckBox();
            this.references_checkBox = new System.Windows.Forms.CheckBox();
            this.grid_checkBox = new System.Windows.Forms.CheckBox();
            this.fitting_checkBox = new System.Windows.Forms.CheckBox();
            this.component_checkBox = new System.Windows.Forms.CheckBox();
            this.cut_checkBox = new System.Windows.Forms.CheckBox();
            this.parts_checkBox = new System.Windows.Forms.CheckBox();
            this.planes_checkBox = new System.Windows.Forms.CheckBox();
            this.surfaces_checkBox = new System.Windows.Forms.CheckBox();
            this.pourBreaks_checkBox = new System.Windows.Forms.CheckBox();
            this.cut2_checkBox = new System.Windows.Forms.CheckBox();
            this.component2_checkBox = new System.Windows.Forms.CheckBox();
            this.fitting2_checkBox = new System.Windows.Forms.CheckBox();
            this.planes2_checkBox = new System.Windows.Forms.CheckBox();
            this.points2_checkBox = new System.Windows.Forms.CheckBox();
            this.weld2_checkBox = new System.Windows.Forms.CheckBox();
            this.bolt2_checkBox = new System.Windows.Forms.CheckBox();
            this.holes2_checkBox = new System.Windows.Forms.CheckBox();
            this.rebars2_checkBox = new System.Windows.Forms.CheckBox();
            this.parts2_checkBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.references_label = new System.Windows.Forms.Label();
            this.pourBreaks_label = new System.Windows.Forms.Label();
            this.surfaces_label = new System.Windows.Forms.Label();
            this.loads_label = new System.Windows.Forms.Label();
            this.grid_label = new System.Windows.Forms.Label();
            this.parts_label = new System.Windows.Forms.Label();
            this.rebars_label = new System.Windows.Forms.Label();
            this.holes_label = new System.Windows.Forms.Label();
            this.bolt_label = new System.Windows.Forms.Label();
            this.weld_label = new System.Windows.Forms.Label();
            this.points_label = new System.Windows.Forms.Label();
            this.planes_label = new System.Windows.Forms.Label();
            this.lines_label = new System.Windows.Forms.Label();
            this.fitting_label = new System.Windows.Forms.Label();
            this.cut_label = new System.Windows.Forms.Label();
            this.component_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bolt_checkBox
            // 
            this.bolt_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bolt_checkBox.AutoSize = true;
            this.bolt_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bolt_checkBox.Checked = true;
            this.bolt_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bolt_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.bolt_checkBox.Location = new System.Drawing.Point(71, 128);
            this.bolt_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.bolt_checkBox.Name = "bolt_checkBox";
            this.bolt_checkBox.Size = new System.Drawing.Size(15, 14);
            this.bolt_checkBox.TabIndex = 54;
            this.toolTip1.SetToolTip(this.bolt_checkBox, "Turn on / turn off bolts in model");
            this.bolt_checkBox.UseVisualStyleBackColor = true;
            this.bolt_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.bolt_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bolt_checkBox_MouseUp);
            // 
            // holes_checkBox
            // 
            this.holes_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.holes_checkBox.AutoSize = true;
            this.holes_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.holes_checkBox.Checked = true;
            this.holes_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holes_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.holes_checkBox.Location = new System.Drawing.Point(71, 146);
            this.holes_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.holes_checkBox.Name = "holes_checkBox";
            this.holes_checkBox.Size = new System.Drawing.Size(15, 14);
            this.holes_checkBox.TabIndex = 64;
            this.toolTip1.SetToolTip(this.holes_checkBox, "Turn on / turn off holes in model");
            this.holes_checkBox.UseVisualStyleBackColor = true;
            this.holes_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.holes_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Holes_checkBox_MouseUp);
            // 
            // lines_checkBox
            // 
            this.lines_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lines_checkBox.AutoSize = true;
            this.lines_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lines_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.lines_checkBox.Location = new System.Drawing.Point(71, 56);
            this.lines_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.lines_checkBox.Name = "lines_checkBox";
            this.lines_checkBox.Size = new System.Drawing.Size(15, 14);
            this.lines_checkBox.TabIndex = 56;
            this.toolTip1.SetToolTip(this.lines_checkBox, "Turn on / turn off construction lines");
            this.lines_checkBox.UseVisualStyleBackColor = true;
            this.lines_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // loads_checkBox
            // 
            this.loads_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loads_checkBox.AutoSize = true;
            this.loads_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loads_checkBox.Checked = true;
            this.loads_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loads_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.loads_checkBox.Location = new System.Drawing.Point(71, 218);
            this.loads_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.loads_checkBox.Name = "loads_checkBox";
            this.loads_checkBox.Size = new System.Drawing.Size(15, 14);
            this.loads_checkBox.TabIndex = 74;
            this.toolTip1.SetToolTip(this.loads_checkBox, "Turn on / turn off loads");
            this.loads_checkBox.UseVisualStyleBackColor = true;
            this.loads_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // unSelectCheck_checkBox
            // 
            this.unSelectCheck_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unSelectCheck_checkBox.AutoCheck = false;
            this.unSelectCheck_checkBox.AutoSize = true;
            this.unSelectCheck_checkBox.Location = new System.Drawing.Point(88, 304);
            this.unSelectCheck_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.unSelectCheck_checkBox.Name = "unSelectCheck_checkBox";
            this.unSelectCheck_checkBox.Size = new System.Drawing.Size(15, 14);
            this.unSelectCheck_checkBox.TabIndex = 63;
            this.toolTip1.SetToolTip(this.unSelectCheck_checkBox, "Unselect all above");
            this.unSelectCheck_checkBox.UseVisualStyleBackColor = true;
            this.unSelectCheck_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnSelectCheck_checkBoxMouseDown);
            // 
            // weld_checkBox
            // 
            this.weld_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.weld_checkBox.AutoSize = true;
            this.weld_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weld_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.weld_checkBox.Location = new System.Drawing.Point(71, 110);
            this.weld_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.weld_checkBox.Name = "weld_checkBox";
            this.weld_checkBox.Size = new System.Drawing.Size(15, 14);
            this.weld_checkBox.TabIndex = 57;
            this.toolTip1.SetToolTip(this.weld_checkBox, "Turn on / turn off welds in model");
            this.weld_checkBox.UseVisualStyleBackColor = true;
            this.weld_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.weld_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Weld_checkBox_MouseUp);
            // 
            // selectCheck_checkBox
            // 
            this.selectCheck_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectCheck_checkBox.AutoCheck = false;
            this.selectCheck_checkBox.AutoSize = true;
            this.selectCheck_checkBox.Checked = true;
            this.selectCheck_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectCheck_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectCheck_checkBox.Location = new System.Drawing.Point(71, 304);
            this.selectCheck_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.selectCheck_checkBox.Name = "selectCheck_checkBox";
            this.selectCheck_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectCheck_checkBox.TabIndex = 62;
            this.toolTip1.SetToolTip(this.selectCheck_checkBox, "Select all above");
            this.selectCheck_checkBox.UseVisualStyleBackColor = true;
            this.selectCheck_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectCheck_checkBoxMouseDown);
            // 
            // rebars_checkBox
            // 
            this.rebars_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rebars_checkBox.AutoSize = true;
            this.rebars_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rebars_checkBox.Checked = true;
            this.rebars_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rebars_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.rebars_checkBox.Location = new System.Drawing.Point(71, 164);
            this.rebars_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.rebars_checkBox.Name = "rebars_checkBox";
            this.rebars_checkBox.Size = new System.Drawing.Size(15, 14);
            this.rebars_checkBox.TabIndex = 72;
            this.toolTip1.SetToolTip(this.rebars_checkBox, "Turn on / turn off rebars in model");
            this.rebars_checkBox.UseVisualStyleBackColor = true;
            this.rebars_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.rebars_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rebars_checkBox_MouseUp);
            // 
            // points_checkBox
            // 
            this.points_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.points_checkBox.AutoSize = true;
            this.points_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.points_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.points_checkBox.Location = new System.Drawing.Point(71, 92);
            this.points_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.points_checkBox.Name = "points_checkBox";
            this.points_checkBox.Size = new System.Drawing.Size(15, 14);
            this.points_checkBox.TabIndex = 61;
            this.toolTip1.SetToolTip(this.points_checkBox, "Turn on / turn off points in model");
            this.points_checkBox.UseVisualStyleBackColor = true;
            this.points_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.points_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Points_checkBox_MouseUp);
            // 
            // references_checkBox
            // 
            this.references_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.references_checkBox.AutoSize = true;
            this.references_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.references_checkBox.Checked = true;
            this.references_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.references_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.references_checkBox.Location = new System.Drawing.Point(71, 272);
            this.references_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.references_checkBox.Name = "references_checkBox";
            this.references_checkBox.Size = new System.Drawing.Size(15, 14);
            this.references_checkBox.TabIndex = 73;
            this.toolTip1.SetToolTip(this.references_checkBox, "Turn on / turn off reference models");
            this.references_checkBox.UseVisualStyleBackColor = true;
            this.references_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // grid_checkBox
            // 
            this.grid_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grid_checkBox.AutoSize = true;
            this.grid_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grid_checkBox.Checked = true;
            this.grid_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grid_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.grid_checkBox.Location = new System.Drawing.Point(71, 200);
            this.grid_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.grid_checkBox.Name = "grid_checkBox";
            this.grid_checkBox.Size = new System.Drawing.Size(15, 14);
            this.grid_checkBox.TabIndex = 60;
            this.toolTip1.SetToolTip(this.grid_checkBox, "Turn on / turn off grids");
            this.grid_checkBox.UseVisualStyleBackColor = true;
            this.grid_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // fitting_checkBox
            // 
            this.fitting_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fitting_checkBox.AutoSize = true;
            this.fitting_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fitting_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.fitting_checkBox.Location = new System.Drawing.Point(71, 38);
            this.fitting_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.fitting_checkBox.Name = "fitting_checkBox";
            this.fitting_checkBox.Size = new System.Drawing.Size(15, 14);
            this.fitting_checkBox.TabIndex = 59;
            this.toolTip1.SetToolTip(this.fitting_checkBox, "Turn on / turn off fittings in model");
            this.fitting_checkBox.UseVisualStyleBackColor = true;
            this.fitting_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.fitting_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fitting_checkBox_MouseUp);
            // 
            // component_checkBox
            // 
            this.component_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.component_checkBox.AutoSize = true;
            this.component_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.component_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.component_checkBox.Location = new System.Drawing.Point(71, 2);
            this.component_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.component_checkBox.Name = "component_checkBox";
            this.component_checkBox.Size = new System.Drawing.Size(15, 14);
            this.component_checkBox.TabIndex = 55;
            this.toolTip1.SetToolTip(this.component_checkBox, "Turn on / turn off component symbols in model");
            this.component_checkBox.UseVisualStyleBackColor = true;
            this.component_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.component_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_checkBox_MouseUp);
            // 
            // cut_checkBox
            // 
            this.cut_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cut_checkBox.AutoSize = true;
            this.cut_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cut_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.cut_checkBox.Location = new System.Drawing.Point(71, 20);
            this.cut_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.cut_checkBox.Name = "cut_checkBox";
            this.cut_checkBox.Size = new System.Drawing.Size(15, 14);
            this.cut_checkBox.TabIndex = 58;
            this.toolTip1.SetToolTip(this.cut_checkBox, "Turn on / turn off cuts in model");
            this.cut_checkBox.UseVisualStyleBackColor = true;
            this.cut_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.cut_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cut_checkBox_MouseUp);
            // 
            // parts_checkBox
            // 
            this.parts_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.parts_checkBox.AutoSize = true;
            this.parts_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parts_checkBox.Checked = true;
            this.parts_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parts_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.parts_checkBox.Location = new System.Drawing.Point(71, 182);
            this.parts_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.parts_checkBox.Name = "parts_checkBox";
            this.parts_checkBox.Size = new System.Drawing.Size(15, 14);
            this.parts_checkBox.TabIndex = 75;
            this.toolTip1.SetToolTip(this.parts_checkBox, "Turn on / turn off parts in model");
            this.parts_checkBox.UseVisualStyleBackColor = true;
            this.parts_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.parts_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Parts_checkBox_MouseUp);
            // 
            // planes_checkBox
            // 
            this.planes_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.planes_checkBox.AutoSize = true;
            this.planes_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.planes_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.planes_checkBox.Location = new System.Drawing.Point(71, 74);
            this.planes_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.planes_checkBox.Name = "planes_checkBox";
            this.planes_checkBox.Size = new System.Drawing.Size(15, 14);
            this.planes_checkBox.TabIndex = 76;
            this.toolTip1.SetToolTip(this.planes_checkBox, "Turn on / turn off construction planes in model");
            this.planes_checkBox.UseVisualStyleBackColor = true;
            this.planes_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.planes_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Planes_checkBox_MouseUp);
            // 
            // surfaces_checkBox
            // 
            this.surfaces_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.surfaces_checkBox.AutoSize = true;
            this.surfaces_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.surfaces_checkBox.Checked = true;
            this.surfaces_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.surfaces_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.surfaces_checkBox.Location = new System.Drawing.Point(71, 236);
            this.surfaces_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.surfaces_checkBox.Name = "surfaces_checkBox";
            this.surfaces_checkBox.Size = new System.Drawing.Size(15, 14);
            this.surfaces_checkBox.TabIndex = 77;
            this.toolTip1.SetToolTip(this.surfaces_checkBox, "Turn on / turn off surface treatments");
            this.surfaces_checkBox.UseVisualStyleBackColor = true;
            this.surfaces_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // pourBreaks_checkBox
            // 
            this.pourBreaks_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pourBreaks_checkBox.AutoSize = true;
            this.pourBreaks_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pourBreaks_checkBox.Checked = true;
            this.pourBreaks_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pourBreaks_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.pourBreaks_checkBox.Location = new System.Drawing.Point(71, 254);
            this.pourBreaks_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.pourBreaks_checkBox.Name = "pourBreaks_checkBox";
            this.pourBreaks_checkBox.Size = new System.Drawing.Size(15, 14);
            this.pourBreaks_checkBox.TabIndex = 78;
            this.toolTip1.SetToolTip(this.pourBreaks_checkBox, "Turn on / turn off pour breaks");
            this.pourBreaks_checkBox.UseVisualStyleBackColor = true;
            this.pourBreaks_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // cut2_checkBox
            // 
            this.cut2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cut2_checkBox.AutoSize = true;
            this.cut2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cut2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.cut2_checkBox.Location = new System.Drawing.Point(88, 20);
            this.cut2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.cut2_checkBox.Name = "cut2_checkBox";
            this.cut2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.cut2_checkBox.TabIndex = 79;
            this.toolTip1.SetToolTip(this.cut2_checkBox, "Turn on / turn off cuts in components");
            this.cut2_checkBox.UseVisualStyleBackColor = true;
            this.cut2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.cut2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cut2_checkBox_MouseUp);
            // 
            // component2_checkBox
            // 
            this.component2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.component2_checkBox.AutoSize = true;
            this.component2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.component2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.component2_checkBox.Location = new System.Drawing.Point(88, 2);
            this.component2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.component2_checkBox.Name = "component2_checkBox";
            this.component2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.component2_checkBox.TabIndex = 80;
            this.toolTip1.SetToolTip(this.component2_checkBox, "Turn on / turn off component symbols in components");
            this.component2_checkBox.UseVisualStyleBackColor = true;
            this.component2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.component2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component2_checkBox_MouseUp);
            // 
            // fitting2_checkBox
            // 
            this.fitting2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fitting2_checkBox.AutoSize = true;
            this.fitting2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fitting2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.fitting2_checkBox.Location = new System.Drawing.Point(88, 38);
            this.fitting2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.fitting2_checkBox.Name = "fitting2_checkBox";
            this.fitting2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.fitting2_checkBox.TabIndex = 82;
            this.toolTip1.SetToolTip(this.fitting2_checkBox, "Turn on / turn off fittings in components");
            this.fitting2_checkBox.UseVisualStyleBackColor = true;
            this.fitting2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.fitting2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fitting2_checkBox_MouseUp);
            // 
            // planes2_checkBox
            // 
            this.planes2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.planes2_checkBox.AutoSize = true;
            this.planes2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.planes2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.planes2_checkBox.Location = new System.Drawing.Point(88, 74);
            this.planes2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.planes2_checkBox.Name = "planes2_checkBox";
            this.planes2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.planes2_checkBox.TabIndex = 83;
            this.toolTip1.SetToolTip(this.planes2_checkBox, "Turn on / turn off construction planes in components");
            this.planes2_checkBox.UseVisualStyleBackColor = true;
            this.planes2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.planes2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Planes2_checkBox_MouseUp);
            // 
            // points2_checkBox
            // 
            this.points2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.points2_checkBox.AutoSize = true;
            this.points2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.points2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.points2_checkBox.Location = new System.Drawing.Point(88, 92);
            this.points2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.points2_checkBox.Name = "points2_checkBox";
            this.points2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.points2_checkBox.TabIndex = 85;
            this.toolTip1.SetToolTip(this.points2_checkBox, "Turn on / turn off points in components");
            this.points2_checkBox.UseVisualStyleBackColor = true;
            this.points2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.points2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Points2_checkBox_MouseUp);
            // 
            // weld2_checkBox
            // 
            this.weld2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.weld2_checkBox.AutoSize = true;
            this.weld2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weld2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.weld2_checkBox.Location = new System.Drawing.Point(88, 110);
            this.weld2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.weld2_checkBox.Name = "weld2_checkBox";
            this.weld2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.weld2_checkBox.TabIndex = 86;
            this.toolTip1.SetToolTip(this.weld2_checkBox, "Turn on / turn off welds in components");
            this.weld2_checkBox.UseVisualStyleBackColor = true;
            this.weld2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.weld2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Weld2_checkBox_MouseUp);
            // 
            // bolt2_checkBox
            // 
            this.bolt2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bolt2_checkBox.AutoSize = true;
            this.bolt2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bolt2_checkBox.Checked = true;
            this.bolt2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bolt2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.bolt2_checkBox.Location = new System.Drawing.Point(88, 128);
            this.bolt2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.bolt2_checkBox.Name = "bolt2_checkBox";
            this.bolt2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.bolt2_checkBox.TabIndex = 87;
            this.toolTip1.SetToolTip(this.bolt2_checkBox, "Turn on / turn off bolts in components");
            this.bolt2_checkBox.UseVisualStyleBackColor = true;
            this.bolt2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.bolt2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bolt2_checkBox_MouseUp);
            // 
            // holes2_checkBox
            // 
            this.holes2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.holes2_checkBox.AutoSize = true;
            this.holes2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.holes2_checkBox.Checked = true;
            this.holes2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holes2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.holes2_checkBox.Location = new System.Drawing.Point(88, 146);
            this.holes2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.holes2_checkBox.Name = "holes2_checkBox";
            this.holes2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.holes2_checkBox.TabIndex = 88;
            this.toolTip1.SetToolTip(this.holes2_checkBox, "Turn on / turn off holes in components");
            this.holes2_checkBox.UseVisualStyleBackColor = true;
            this.holes2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.holes2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Holes2_checkBox_MouseUp);
            // 
            // rebars2_checkBox
            // 
            this.rebars2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rebars2_checkBox.AutoSize = true;
            this.rebars2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rebars2_checkBox.Checked = true;
            this.rebars2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rebars2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.rebars2_checkBox.Location = new System.Drawing.Point(88, 164);
            this.rebars2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.rebars2_checkBox.Name = "rebars2_checkBox";
            this.rebars2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.rebars2_checkBox.TabIndex = 89;
            this.toolTip1.SetToolTip(this.rebars2_checkBox, "Turn on / turn off rebars in components");
            this.rebars2_checkBox.UseVisualStyleBackColor = true;
            this.rebars2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.rebars2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rebars2_checkBox_MouseUp);
            // 
            // parts2_checkBox
            // 
            this.parts2_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.parts2_checkBox.AutoSize = true;
            this.parts2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parts2_checkBox.Checked = true;
            this.parts2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parts2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.parts2_checkBox.Location = new System.Drawing.Point(88, 182);
            this.parts2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.parts2_checkBox.Name = "parts2_checkBox";
            this.parts2_checkBox.Size = new System.Drawing.Size(15, 14);
            this.parts2_checkBox.TabIndex = 90;
            this.toolTip1.SetToolTip(this.parts2_checkBox, "Turn on / turn off parts in components");
            this.parts2_checkBox.UseVisualStyleBackColor = true;
            this.parts2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.parts2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Parts2_checkBox_MouseUp);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.references_label, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.selectCheck_checkBox, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.unSelectCheck_checkBox, 2, 18);
            this.tableLayoutPanel1.Controls.Add(this.pourBreaks_label, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.surfaces_label, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.loads_label, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.grid_label, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.parts_label, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.rebars_label, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.holes_label, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.bolt_label, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.weld_label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.points_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.planes_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lines_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fitting_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cut_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.component_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.component_checkBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loads_checkBox, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.parts2_checkBox, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.references_checkBox, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.pourBreaks_checkBox, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.cut_checkBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.surfaces_checkBox, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.rebars2_checkBox, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.component2_checkBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.holes2_checkBox, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.cut2_checkBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.grid_checkBox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.holes_checkBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.rebars_checkBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.bolt2_checkBox, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.parts_checkBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.bolt_checkBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.fitting_checkBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fitting2_checkBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lines_checkBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.weld2_checkBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.planes_checkBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.points2_checkBox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.planes2_checkBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.weld_checkBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.points_checkBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(104, 319);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // references_label
            // 
            this.references_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.references_label.AutoSize = true;
            this.references_label.Font = new System.Drawing.Font("Arial", 8F);
            this.references_label.Location = new System.Drawing.Point(1, 272);
            this.references_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.references_label.Name = "references_label";
            this.references_label.Size = new System.Drawing.Size(64, 14);
            this.references_label.TabIndex = 112;
            this.references_label.Text = "References";
            this.references_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.references_label_MouseUp);
            // 
            // pourBreaks_label
            // 
            this.pourBreaks_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pourBreaks_label.AutoSize = true;
            this.pourBreaks_label.Font = new System.Drawing.Font("Arial", 8F);
            this.pourBreaks_label.Location = new System.Drawing.Point(1, 254);
            this.pourBreaks_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.pourBreaks_label.Name = "pourBreaks_label";
            this.pourBreaks_label.Size = new System.Drawing.Size(65, 14);
            this.pourBreaks_label.TabIndex = 110;
            this.pourBreaks_label.Text = "Pour breaks";
            this.pourBreaks_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pourBreaks_label_MouseUp);
            // 
            // surfaces_label
            // 
            this.surfaces_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.surfaces_label.AutoSize = true;
            this.surfaces_label.Font = new System.Drawing.Font("Arial", 8F);
            this.surfaces_label.Location = new System.Drawing.Point(1, 236);
            this.surfaces_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.surfaces_label.Name = "surfaces_label";
            this.surfaces_label.Size = new System.Drawing.Size(52, 14);
            this.surfaces_label.TabIndex = 108;
            this.surfaces_label.Text = "Surfaces";
            this.surfaces_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.surfaces_label_MouseUp);
            // 
            // loads_label
            // 
            this.loads_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loads_label.AutoSize = true;
            this.loads_label.Font = new System.Drawing.Font("Arial", 8F);
            this.loads_label.Location = new System.Drawing.Point(1, 218);
            this.loads_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.loads_label.Name = "loads_label";
            this.loads_label.Size = new System.Drawing.Size(37, 14);
            this.loads_label.TabIndex = 106;
            this.loads_label.Text = "Loads";
            this.loads_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loads_label_MouseUp);
            // 
            // grid_label
            // 
            this.grid_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grid_label.AutoSize = true;
            this.grid_label.Font = new System.Drawing.Font("Arial", 8F);
            this.grid_label.Location = new System.Drawing.Point(1, 200);
            this.grid_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.grid_label.Name = "grid_label";
            this.grid_label.Size = new System.Drawing.Size(33, 14);
            this.grid_label.TabIndex = 104;
            this.grid_label.Text = "Grids";
            this.grid_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grid_label_MouseUp);
            // 
            // parts_label
            // 
            this.parts_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.parts_label.AutoSize = true;
            this.parts_label.Font = new System.Drawing.Font("Arial", 8F);
            this.parts_label.Location = new System.Drawing.Point(1, 182);
            this.parts_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.parts_label.Name = "parts_label";
            this.parts_label.Size = new System.Drawing.Size(32, 14);
            this.parts_label.TabIndex = 103;
            this.parts_label.Text = "Parts";
            this.parts_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.parts_label_MouseUp);
            // 
            // rebars_label
            // 
            this.rebars_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rebars_label.AutoSize = true;
            this.rebars_label.Font = new System.Drawing.Font("Arial", 8F);
            this.rebars_label.Location = new System.Drawing.Point(1, 164);
            this.rebars_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.rebars_label.Name = "rebars_label";
            this.rebars_label.Size = new System.Drawing.Size(42, 14);
            this.rebars_label.TabIndex = 102;
            this.rebars_label.Text = "Rebars";
            this.rebars_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rebars_label_MouseUp);
            // 
            // holes_label
            // 
            this.holes_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.holes_label.AutoSize = true;
            this.holes_label.Font = new System.Drawing.Font("Arial", 8F);
            this.holes_label.Location = new System.Drawing.Point(1, 146);
            this.holes_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.holes_label.Name = "holes_label";
            this.holes_label.Size = new System.Drawing.Size(34, 14);
            this.holes_label.TabIndex = 101;
            this.holes_label.Text = "Holes";
            this.holes_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.holes_label_MouseUp);
            // 
            // bolt_label
            // 
            this.bolt_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bolt_label.AutoSize = true;
            this.bolt_label.Font = new System.Drawing.Font("Arial", 8F);
            this.bolt_label.Location = new System.Drawing.Point(1, 128);
            this.bolt_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.bolt_label.Name = "bolt_label";
            this.bolt_label.Size = new System.Drawing.Size(31, 14);
            this.bolt_label.TabIndex = 100;
            this.bolt_label.Text = "Bolts";
            this.bolt_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bolt_label_MouseUp);
            // 
            // weld_label
            // 
            this.weld_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.weld_label.AutoSize = true;
            this.weld_label.Font = new System.Drawing.Font("Arial", 8F);
            this.weld_label.Location = new System.Drawing.Point(1, 110);
            this.weld_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.weld_label.Name = "weld_label";
            this.weld_label.Size = new System.Drawing.Size(37, 14);
            this.weld_label.TabIndex = 99;
            this.weld_label.Text = "Welds";
            this.weld_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.weld_label_MouseUp);
            // 
            // points_label
            // 
            this.points_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.points_label.AutoSize = true;
            this.points_label.Font = new System.Drawing.Font("Arial", 8F);
            this.points_label.Location = new System.Drawing.Point(1, 92);
            this.points_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(36, 14);
            this.points_label.TabIndex = 98;
            this.points_label.Text = "Points";
            this.points_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.points_label_MouseUp);
            // 
            // planes_label
            // 
            this.planes_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.planes_label.AutoSize = true;
            this.planes_label.Font = new System.Drawing.Font("Arial", 8F);
            this.planes_label.Location = new System.Drawing.Point(1, 74);
            this.planes_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.planes_label.Name = "planes_label";
            this.planes_label.Size = new System.Drawing.Size(39, 14);
            this.planes_label.TabIndex = 97;
            this.planes_label.Text = "Planes";
            this.planes_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.planes_label_MouseUp);
            // 
            // lines_label
            // 
            this.lines_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lines_label.AutoSize = true;
            this.lines_label.Font = new System.Drawing.Font("Arial", 8F);
            this.lines_label.Location = new System.Drawing.Point(1, 56);
            this.lines_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.lines_label.Name = "lines_label";
            this.lines_label.Size = new System.Drawing.Size(33, 14);
            this.lines_label.TabIndex = 95;
            this.lines_label.Text = "Lines";
            this.lines_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lines_label_MouseUp);
            // 
            // fitting_label
            // 
            this.fitting_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fitting_label.AutoSize = true;
            this.fitting_label.Font = new System.Drawing.Font("Arial", 8F);
            this.fitting_label.Location = new System.Drawing.Point(1, 38);
            this.fitting_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.fitting_label.Name = "fitting_label";
            this.fitting_label.Size = new System.Drawing.Size(41, 14);
            this.fitting_label.TabIndex = 94;
            this.fitting_label.Text = "Fittings";
            this.fitting_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fitting_label_MouseUp);
            // 
            // cut_label
            // 
            this.cut_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cut_label.AutoSize = true;
            this.cut_label.Font = new System.Drawing.Font("Arial", 8F);
            this.cut_label.Location = new System.Drawing.Point(1, 20);
            this.cut_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.cut_label.Name = "cut_label";
            this.cut_label.Size = new System.Drawing.Size(29, 14);
            this.cut_label.TabIndex = 93;
            this.cut_label.Text = "Cuts";
            this.cut_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cut_label_MouseUp);
            // 
            // component_label
            // 
            this.component_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.component_label.AutoSize = true;
            this.component_label.Font = new System.Drawing.Font("Arial", 8F);
            this.component_label.Location = new System.Drawing.Point(1, 2);
            this.component_label.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.component_label.Name = "component_label";
            this.component_label.Size = new System.Drawing.Size(67, 14);
            this.component_label.TabIndex = 92;
            this.component_label.Text = "Components";
            this.component_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_label_MouseUp);
            // 
            // CheckboxesControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckboxesControl";
            this.Size = new System.Drawing.Size(261, 368);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.CheckBox bolt_checkBox;
        private System.Windows.Forms.CheckBox holes_checkBox;
        private System.Windows.Forms.CheckBox lines_checkBox;
        private System.Windows.Forms.CheckBox loads_checkBox;
        private System.Windows.Forms.CheckBox unSelectCheck_checkBox;
        private System.Windows.Forms.CheckBox weld_checkBox;
        private System.Windows.Forms.CheckBox selectCheck_checkBox;
        private System.Windows.Forms.CheckBox rebars_checkBox;
        private System.Windows.Forms.CheckBox points_checkBox;
        private System.Windows.Forms.CheckBox references_checkBox;
        private System.Windows.Forms.CheckBox grid_checkBox;
        private System.Windows.Forms.CheckBox fitting_checkBox;
        private System.Windows.Forms.CheckBox component_checkBox;
        private System.Windows.Forms.CheckBox cut_checkBox;
        private System.Windows.Forms.CheckBox parts_checkBox;
        private System.Windows.Forms.CheckBox planes_checkBox;
        private System.Windows.Forms.CheckBox surfaces_checkBox;
        private System.Windows.Forms.CheckBox pourBreaks_checkBox;
        private System.Windows.Forms.CheckBox cut2_checkBox;
        private System.Windows.Forms.CheckBox component2_checkBox;
        private System.Windows.Forms.CheckBox fitting2_checkBox;
        private System.Windows.Forms.CheckBox planes2_checkBox;
        private System.Windows.Forms.CheckBox points2_checkBox;
        private System.Windows.Forms.CheckBox weld2_checkBox;
        private System.Windows.Forms.CheckBox bolt2_checkBox;
        private System.Windows.Forms.CheckBox holes2_checkBox;
        private System.Windows.Forms.CheckBox rebars2_checkBox;
        private System.Windows.Forms.CheckBox parts2_checkBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label component_label;
        private System.Windows.Forms.Label references_label;
        private System.Windows.Forms.Label pourBreaks_label;
        private System.Windows.Forms.Label surfaces_label;
        private System.Windows.Forms.Label loads_label;
        private System.Windows.Forms.Label grid_label;
        private System.Windows.Forms.Label parts_label;
        private System.Windows.Forms.Label rebars_label;
        private System.Windows.Forms.Label holes_label;
        private System.Windows.Forms.Label bolt_label;
        private System.Windows.Forms.Label weld_label;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.Label planes_label;
        private System.Windows.Forms.Label lines_label;
        private System.Windows.Forms.Label fitting_label;
        private System.Windows.Forms.Label cut_label;
    }
}
