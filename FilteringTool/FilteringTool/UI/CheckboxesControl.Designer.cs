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
            this.SuspendLayout();
            // 
            // bolt_checkBox
            // 
            this.bolt_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bolt_checkBox.Checked = true;
            this.bolt_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bolt_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.bolt_checkBox.Location = new System.Drawing.Point(-1, 130);
            this.bolt_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.bolt_checkBox.Name = "bolt_checkBox";
            this.bolt_checkBox.Size = new System.Drawing.Size(71, 15);
            this.bolt_checkBox.TabIndex = 54;
            this.bolt_checkBox.Text = "Bolts";
            this.toolTip1.SetToolTip(this.bolt_checkBox, "Turn on / turn off bolts in model");
            this.bolt_checkBox.UseVisualStyleBackColor = true;
            this.bolt_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.bolt_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bolt_checkBox_MouseUp);
            // 
            // holes_checkBox
            // 
            this.holes_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.holes_checkBox.Checked = true;
            this.holes_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holes_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.holes_checkBox.Location = new System.Drawing.Point(-1, 147);
            this.holes_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.holes_checkBox.Name = "holes_checkBox";
            this.holes_checkBox.Size = new System.Drawing.Size(71, 15);
            this.holes_checkBox.TabIndex = 64;
            this.holes_checkBox.Text = "Holes";
            this.toolTip1.SetToolTip(this.holes_checkBox, "Turn on / turn off holes in model");
            this.holes_checkBox.UseVisualStyleBackColor = true;
            this.holes_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.holes_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Holes_checkBox_MouseUp);
            // 
            // lines_checkBox
            // 
            this.lines_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lines_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.lines_checkBox.Location = new System.Drawing.Point(-1, 63);
            this.lines_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.lines_checkBox.Name = "lines_checkBox";
            this.lines_checkBox.Size = new System.Drawing.Size(71, 15);
            this.lines_checkBox.TabIndex = 56;
            this.lines_checkBox.Text = "Lines";
            this.toolTip1.SetToolTip(this.lines_checkBox, "Turn on / turn off construction lines");
            this.lines_checkBox.UseVisualStyleBackColor = true;
            this.lines_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // loads_checkBox
            // 
            this.loads_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loads_checkBox.Checked = true;
            this.loads_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loads_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.loads_checkBox.Location = new System.Drawing.Point(-1, 215);
            this.loads_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.loads_checkBox.Name = "loads_checkBox";
            this.loads_checkBox.Size = new System.Drawing.Size(71, 15);
            this.loads_checkBox.TabIndex = 74;
            this.loads_checkBox.Text = "Loads";
            this.toolTip1.SetToolTip(this.loads_checkBox, "Turn on / turn off loads");
            this.loads_checkBox.UseVisualStyleBackColor = true;
            this.loads_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // unSelectCheck_checkBox
            // 
            this.unSelectCheck_checkBox.AutoCheck = false;
            this.unSelectCheck_checkBox.Location = new System.Drawing.Point(41, 307);
            this.unSelectCheck_checkBox.Name = "unSelectCheck_checkBox";
            this.unSelectCheck_checkBox.Size = new System.Drawing.Size(13, 13);
            this.unSelectCheck_checkBox.TabIndex = 63;
            this.toolTip1.SetToolTip(this.unSelectCheck_checkBox, "Unselect all above");
            this.unSelectCheck_checkBox.UseVisualStyleBackColor = true;
            this.unSelectCheck_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnSelectCheck_checkBoxMouseDown);
            // 
            // weld_checkBox
            // 
            this.weld_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weld_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.weld_checkBox.Location = new System.Drawing.Point(-1, 113);
            this.weld_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.weld_checkBox.Name = "weld_checkBox";
            this.weld_checkBox.Size = new System.Drawing.Size(71, 15);
            this.weld_checkBox.TabIndex = 57;
            this.weld_checkBox.Text = "Welds";
            this.toolTip1.SetToolTip(this.weld_checkBox, "Turn on / turn off welds in model");
            this.weld_checkBox.UseVisualStyleBackColor = true;
            this.weld_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.weld_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Weld_checkBox_MouseUp);
            // 
            // selectCheck_checkBox
            // 
            this.selectCheck_checkBox.AutoCheck = false;
            this.selectCheck_checkBox.Checked = true;
            this.selectCheck_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectCheck_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectCheck_checkBox.Location = new System.Drawing.Point(27, 307);
            this.selectCheck_checkBox.Name = "selectCheck_checkBox";
            this.selectCheck_checkBox.Size = new System.Drawing.Size(13, 13);
            this.selectCheck_checkBox.TabIndex = 62;
            this.toolTip1.SetToolTip(this.selectCheck_checkBox, "Select all above");
            this.selectCheck_checkBox.UseVisualStyleBackColor = true;
            this.selectCheck_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectCheck_checkBoxMouseDown);
            // 
            // rebars_checkBox
            // 
            this.rebars_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rebars_checkBox.Checked = true;
            this.rebars_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rebars_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.rebars_checkBox.Location = new System.Drawing.Point(-1, 164);
            this.rebars_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.rebars_checkBox.Name = "rebars_checkBox";
            this.rebars_checkBox.Size = new System.Drawing.Size(71, 15);
            this.rebars_checkBox.TabIndex = 72;
            this.rebars_checkBox.Text = "Rebars";
            this.toolTip1.SetToolTip(this.rebars_checkBox, "Turn on / turn off rebars in model");
            this.rebars_checkBox.UseVisualStyleBackColor = true;
            this.rebars_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.rebars_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rebars_checkBox_MouseUp);
            // 
            // points_checkBox
            // 
            this.points_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.points_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.points_checkBox.Location = new System.Drawing.Point(-1, 96);
            this.points_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.points_checkBox.Name = "points_checkBox";
            this.points_checkBox.Size = new System.Drawing.Size(71, 15);
            this.points_checkBox.TabIndex = 61;
            this.points_checkBox.Text = "Points";
            this.toolTip1.SetToolTip(this.points_checkBox, "Turn on / turn off points in model");
            this.points_checkBox.UseVisualStyleBackColor = true;
            this.points_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.points_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Points_checkBox_MouseUp);
            // 
            // references_checkBox
            // 
            this.references_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.references_checkBox.Checked = true;
            this.references_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.references_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.references_checkBox.Location = new System.Drawing.Point(-1, 275);
            this.references_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.references_checkBox.Name = "references_checkBox";
            this.references_checkBox.Size = new System.Drawing.Size(71, 32);
            this.references_checkBox.TabIndex = 73;
            this.references_checkBox.Text = "Referen-    ces";
            this.toolTip1.SetToolTip(this.references_checkBox, "Turn on / turn off reference models");
            this.references_checkBox.UseVisualStyleBackColor = true;
            this.references_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // grid_checkBox
            // 
            this.grid_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grid_checkBox.Checked = true;
            this.grid_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grid_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.grid_checkBox.Location = new System.Drawing.Point(-1, 198);
            this.grid_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.grid_checkBox.Name = "grid_checkBox";
            this.grid_checkBox.Size = new System.Drawing.Size(71, 15);
            this.grid_checkBox.TabIndex = 60;
            this.grid_checkBox.Text = "Grids";
            this.toolTip1.SetToolTip(this.grid_checkBox, "Turn on / turn off grids");
            this.grid_checkBox.UseVisualStyleBackColor = true;
            this.grid_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // fitting_checkBox
            // 
            this.fitting_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fitting_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.fitting_checkBox.Location = new System.Drawing.Point(-1, 46);
            this.fitting_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.fitting_checkBox.Name = "fitting_checkBox";
            this.fitting_checkBox.Size = new System.Drawing.Size(71, 17);
            this.fitting_checkBox.TabIndex = 59;
            this.fitting_checkBox.Text = "Fittings";
            this.toolTip1.SetToolTip(this.fitting_checkBox, "Turn on / turn off fittings in model");
            this.fitting_checkBox.UseVisualStyleBackColor = true;
            this.fitting_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.fitting_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fitting_checkBox_MouseUp);
            // 
            // component_checkBox
            // 
            this.component_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.component_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.component_checkBox.Location = new System.Drawing.Point(1, 1);
            this.component_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.component_checkBox.Name = "component_checkBox";
            this.component_checkBox.Size = new System.Drawing.Size(69, 33);
            this.component_checkBox.TabIndex = 55;
            this.component_checkBox.Text = "Compo-      nents";
            this.toolTip1.SetToolTip(this.component_checkBox, "Turn on / turn off component symbols in model");
            this.component_checkBox.UseVisualStyleBackColor = true;
            this.component_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.component_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_checkBox_MouseUp);
            // 
            // cut_checkBox
            // 
            this.cut_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cut_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.cut_checkBox.Location = new System.Drawing.Point(-1, 30);
            this.cut_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.cut_checkBox.Name = "cut_checkBox";
            this.cut_checkBox.Size = new System.Drawing.Size(71, 15);
            this.cut_checkBox.TabIndex = 58;
            this.cut_checkBox.Text = "Cuts";
            this.toolTip1.SetToolTip(this.cut_checkBox, "Turn on / turn off cuts in model");
            this.cut_checkBox.UseVisualStyleBackColor = true;
            this.cut_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.cut_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cut_checkBox_MouseUp);
            // 
            // parts_checkBox
            // 
            this.parts_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parts_checkBox.Checked = true;
            this.parts_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parts_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.parts_checkBox.Location = new System.Drawing.Point(-1, 181);
            this.parts_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.parts_checkBox.Name = "parts_checkBox";
            this.parts_checkBox.Size = new System.Drawing.Size(71, 15);
            this.parts_checkBox.TabIndex = 75;
            this.parts_checkBox.Text = "Parts";
            this.toolTip1.SetToolTip(this.parts_checkBox, "Turn on / turn off parts in model");
            this.parts_checkBox.UseVisualStyleBackColor = true;
            this.parts_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.parts_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Parts_checkBox_MouseUp);
            // 
            // planes_checkBox
            // 
            this.planes_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.planes_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.planes_checkBox.Location = new System.Drawing.Point(-1, 79);
            this.planes_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.planes_checkBox.Name = "planes_checkBox";
            this.planes_checkBox.Size = new System.Drawing.Size(71, 15);
            this.planes_checkBox.TabIndex = 76;
            this.planes_checkBox.Text = "Planes";
            this.toolTip1.SetToolTip(this.planes_checkBox, "Turn on / turn off construction planes in model");
            this.planes_checkBox.UseVisualStyleBackColor = true;
            this.planes_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.planes_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Planes_checkBox_MouseUp);
            // 
            // surfaces_checkBox
            // 
            this.surfaces_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.surfaces_checkBox.Checked = true;
            this.surfaces_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.surfaces_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.surfaces_checkBox.Location = new System.Drawing.Point(-1, 232);
            this.surfaces_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.surfaces_checkBox.Name = "surfaces_checkBox";
            this.surfaces_checkBox.Size = new System.Drawing.Size(71, 17);
            this.surfaces_checkBox.TabIndex = 77;
            this.surfaces_checkBox.Text = "Surfaces";
            this.toolTip1.SetToolTip(this.surfaces_checkBox, "Turn on / turn off surface treatments");
            this.surfaces_checkBox.UseVisualStyleBackColor = true;
            this.surfaces_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // pourBreaks_checkBox
            // 
            this.pourBreaks_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pourBreaks_checkBox.Checked = true;
            this.pourBreaks_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pourBreaks_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.pourBreaks_checkBox.Location = new System.Drawing.Point(-1, 246);
            this.pourBreaks_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.pourBreaks_checkBox.Name = "pourBreaks_checkBox";
            this.pourBreaks_checkBox.Size = new System.Drawing.Size(71, 32);
            this.pourBreaks_checkBox.TabIndex = 78;
            this.pourBreaks_checkBox.Text = "Pour           breaks";
            this.toolTip1.SetToolTip(this.pourBreaks_checkBox, "Turn on / turn off pour breaks");
            this.pourBreaks_checkBox.UseVisualStyleBackColor = true;
            this.pourBreaks_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            // 
            // cut2_checkBox
            // 
            this.cut2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cut2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.cut2_checkBox.Location = new System.Drawing.Point(72, 30);
            this.cut2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.cut2_checkBox.Name = "cut2_checkBox";
            this.cut2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.cut2_checkBox.TabIndex = 79;
            this.toolTip1.SetToolTip(this.cut2_checkBox, "Turn on / turn off cuts in components");
            this.cut2_checkBox.UseVisualStyleBackColor = true;
            this.cut2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.cut2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cut2_checkBox_MouseUp);
            // 
            // component2_checkBox
            // 
            this.component2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.component2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.component2_checkBox.Location = new System.Drawing.Point(72, 10);
            this.component2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.component2_checkBox.Name = "component2_checkBox";
            this.component2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.component2_checkBox.TabIndex = 80;
            this.toolTip1.SetToolTip(this.component2_checkBox, "Turn on / turn off component symbols in components");
            this.component2_checkBox.UseVisualStyleBackColor = true;
            this.component2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.component2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component2_checkBox_MouseUp);
            // 
            // fitting2_checkBox
            // 
            this.fitting2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fitting2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.fitting2_checkBox.Location = new System.Drawing.Point(72, 47);
            this.fitting2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.fitting2_checkBox.Name = "fitting2_checkBox";
            this.fitting2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.fitting2_checkBox.TabIndex = 82;
            this.toolTip1.SetToolTip(this.fitting2_checkBox, "Turn on / turn off fittings in components");
            this.fitting2_checkBox.UseVisualStyleBackColor = true;
            this.fitting2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.fitting2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fitting2_checkBox_MouseUp);
            // 
            // planes2_checkBox
            // 
            this.planes2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.planes2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.planes2_checkBox.Location = new System.Drawing.Point(72, 79);
            this.planes2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.planes2_checkBox.Name = "planes2_checkBox";
            this.planes2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.planes2_checkBox.TabIndex = 83;
            this.toolTip1.SetToolTip(this.planes2_checkBox, "Turn on / turn off construction planes in components");
            this.planes2_checkBox.UseVisualStyleBackColor = true;
            this.planes2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.planes2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Planes2_checkBox_MouseUp);
            // 
            // points2_checkBox
            // 
            this.points2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.points2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.points2_checkBox.Location = new System.Drawing.Point(72, 96);
            this.points2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.points2_checkBox.Name = "points2_checkBox";
            this.points2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.points2_checkBox.TabIndex = 85;
            this.toolTip1.SetToolTip(this.points2_checkBox, "Turn on / turn off points in components");
            this.points2_checkBox.UseVisualStyleBackColor = true;
            this.points2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.points2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Points2_checkBox_MouseUp);
            // 
            // weld2_checkBox
            // 
            this.weld2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weld2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.weld2_checkBox.Location = new System.Drawing.Point(72, 113);
            this.weld2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.weld2_checkBox.Name = "weld2_checkBox";
            this.weld2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.weld2_checkBox.TabIndex = 86;
            this.toolTip1.SetToolTip(this.weld2_checkBox, "Turn on / turn off welds in components");
            this.weld2_checkBox.UseVisualStyleBackColor = true;
            this.weld2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.weld2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Weld2_checkBox_MouseUp);
            // 
            // bolt2_checkBox
            // 
            this.bolt2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bolt2_checkBox.Checked = true;
            this.bolt2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bolt2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.bolt2_checkBox.Location = new System.Drawing.Point(72, 130);
            this.bolt2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.bolt2_checkBox.Name = "bolt2_checkBox";
            this.bolt2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.bolt2_checkBox.TabIndex = 87;
            this.toolTip1.SetToolTip(this.bolt2_checkBox, "Turn on / turn off bolts in components");
            this.bolt2_checkBox.UseVisualStyleBackColor = true;
            this.bolt2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.bolt2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bolt2_checkBox_MouseUp);
            // 
            // holes2_checkBox
            // 
            this.holes2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.holes2_checkBox.Checked = true;
            this.holes2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.holes2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.holes2_checkBox.Location = new System.Drawing.Point(72, 147);
            this.holes2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.holes2_checkBox.Name = "holes2_checkBox";
            this.holes2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.holes2_checkBox.TabIndex = 88;
            this.toolTip1.SetToolTip(this.holes2_checkBox, "Turn on / turn off holes in components");
            this.holes2_checkBox.UseVisualStyleBackColor = true;
            this.holes2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.holes2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Holes2_checkBox_MouseUp);
            // 
            // rebars2_checkBox
            // 
            this.rebars2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rebars2_checkBox.Checked = true;
            this.rebars2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rebars2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.rebars2_checkBox.Location = new System.Drawing.Point(72, 164);
            this.rebars2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.rebars2_checkBox.Name = "rebars2_checkBox";
            this.rebars2_checkBox.Size = new System.Drawing.Size(14, 15);
            this.rebars2_checkBox.TabIndex = 89;
            this.toolTip1.SetToolTip(this.rebars2_checkBox, "Turn on / turn off rebars in components");
            this.rebars2_checkBox.UseVisualStyleBackColor = true;
            this.rebars2_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
            this.rebars2_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rebars2_checkBox_MouseUp);
            // 
            // parts2_checkBox
            // 
            this.parts2_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parts2_checkBox.Checked = true;
            this.parts2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parts2_checkBox.Font = new System.Drawing.Font("Arial", 8F);
            this.parts2_checkBox.Location = new System.Drawing.Point(72, 181);
            this.parts2_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.parts2_checkBox.Name = "parts2_checkBox";
            this.parts2_checkBox.Size = new System.Drawing.Size(14, 15);
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
            // CheckboxesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cut_checkBox);
            this.Controls.Add(this.parts2_checkBox);
            this.Controls.Add(this.rebars2_checkBox);
            this.Controls.Add(this.component_checkBox);
            this.Controls.Add(this.holes2_checkBox);
            this.Controls.Add(this.bolt_checkBox);
            this.Controls.Add(this.bolt2_checkBox);
            this.Controls.Add(this.holes_checkBox);
            this.Controls.Add(this.weld2_checkBox);
            this.Controls.Add(this.lines_checkBox);
            this.Controls.Add(this.points2_checkBox);
            this.Controls.Add(this.loads_checkBox);
            this.Controls.Add(this.planes2_checkBox);
            this.Controls.Add(this.unSelectCheck_checkBox);
            this.Controls.Add(this.fitting2_checkBox);
            this.Controls.Add(this.weld_checkBox);
            this.Controls.Add(this.component2_checkBox);
            this.Controls.Add(this.selectCheck_checkBox);
            this.Controls.Add(this.cut2_checkBox);
            this.Controls.Add(this.rebars_checkBox);
            this.Controls.Add(this.pourBreaks_checkBox);
            this.Controls.Add(this.points_checkBox);
            this.Controls.Add(this.surfaces_checkBox);
            this.Controls.Add(this.references_checkBox);
            this.Controls.Add(this.planes_checkBox);
            this.Controls.Add(this.grid_checkBox);
            this.Controls.Add(this.parts_checkBox);
            this.Controls.Add(this.fitting_checkBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckboxesControl";
            this.Size = new System.Drawing.Size(88, 322);
            this.ResumeLayout(false);

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
    }
}
