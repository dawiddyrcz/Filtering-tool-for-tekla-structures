/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace AdministratorFaz
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckedListBox view_checkedListBox;
		private System.Windows.Forms.CheckedListBox select_checkedListBox;
		private System.Windows.Forms.CheckBox bolt_checkBox;
		private System.Windows.Forms.CheckBox component_checkBox;
		private System.Windows.Forms.CheckBox lines_checkBox;
		private System.Windows.Forms.CheckBox weld_checkBox;
		private System.Windows.Forms.CheckBox cut_checkBox;
		private System.Windows.Forms.CheckBox fitting_checkBox;
		private System.Windows.Forms.CheckBox grid_checkBox;
		private System.Windows.Forms.CheckBox points_checkBox;
		private System.Windows.Forms.CheckBox selectSelect_checkBox;
		private System.Windows.Forms.CheckBox unSelectSelect_checkBox;
		private System.Windows.Forms.CheckBox unSelectView_checkBox;
		private System.Windows.Forms.CheckBox selectView_checkBox;
		private System.Windows.Forms.CheckBox unSelectCheck_checkBox;
		private System.Windows.Forms.CheckBox selectCheck_checkBox;
		private System.Windows.Forms.Button redraw_button;
		private System.Windows.Forms.Button select_button;
		private System.Windows.Forms.Button changePhase_button;
		private System.Windows.Forms.Button setPhase_button;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Button refresh_button;
		private System.Windows.Forms.CheckBox holes_checkBox;
		private System.Windows.Forms.CheckBox onlySelectedViews_checkBox;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox viewAttribute_comboBox;
		private System.Windows.Forms.Button viewAttributeLoad_button;
		private System.Windows.Forms.Button viewAttributeSave_button;
		private System.Windows.Forms.ComboBox selectAttribute_comboBox;
		private System.Windows.Forms.RadioButton object_radioButton;
		private System.Windows.Forms.RadioButton assembly_radioButton;
		private System.Windows.Forms.RadioButton element_radioButton;
		private System.Windows.Forms.RadioButton bolt_radioButton;
		private System.Windows.Forms.CheckBox rebars_checkBox;
		private System.Windows.Forms.CheckBox references_checkBox;
		private System.Windows.Forms.CheckBox loads_checkBox;
		private System.Windows.Forms.CheckBox onTop_checkBox;
		private System.Windows.Forms.Button viewAttributeDelete_button;
		private System.Windows.Forms.Button rotateToNearestPlane_button;
		private System.Windows.Forms.Button hideShow_button;
		private System.Windows.Forms.CheckBox ghostMode_checkBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.select_button = new System.Windows.Forms.Button();
			this.refresh_button = new System.Windows.Forms.Button();
			this.add_button = new System.Windows.Forms.Button();
			this.setPhase_button = new System.Windows.Forms.Button();
			this.changePhase_button = new System.Windows.Forms.Button();
			this.redraw_button = new System.Windows.Forms.Button();
			this.unSelectView_checkBox = new System.Windows.Forms.CheckBox();
			this.selectView_checkBox = new System.Windows.Forms.CheckBox();
			this.unSelectSelect_checkBox = new System.Windows.Forms.CheckBox();
			this.selectSelect_checkBox = new System.Windows.Forms.CheckBox();
			this.unSelectCheck_checkBox = new System.Windows.Forms.CheckBox();
			this.selectCheck_checkBox = new System.Windows.Forms.CheckBox();
			this.select_checkedListBox = new System.Windows.Forms.CheckedListBox();
			this.onlySelectedViews_checkBox = new System.Windows.Forms.CheckBox();
			this.grid_checkBox = new System.Windows.Forms.CheckBox();
			this.holes_checkBox = new System.Windows.Forms.CheckBox();
			this.bolt_checkBox = new System.Windows.Forms.CheckBox();
			this.component_checkBox = new System.Windows.Forms.CheckBox();
			this.lines_checkBox = new System.Windows.Forms.CheckBox();
			this.weld_checkBox = new System.Windows.Forms.CheckBox();
			this.cut_checkBox = new System.Windows.Forms.CheckBox();
			this.fitting_checkBox = new System.Windows.Forms.CheckBox();
			this.points_checkBox = new System.Windows.Forms.CheckBox();
			this.view_checkedListBox = new System.Windows.Forms.CheckedListBox();
			this.rebars_checkBox = new System.Windows.Forms.CheckBox();
			this.references_checkBox = new System.Windows.Forms.CheckBox();
			this.loads_checkBox = new System.Windows.Forms.CheckBox();
			this.viewAttributeLoad_button = new System.Windows.Forms.Button();
			this.viewAttributeSave_button = new System.Windows.Forms.Button();
			this.viewAttribute_comboBox = new System.Windows.Forms.ComboBox();
			this.selectAttribute_comboBox = new System.Windows.Forms.ComboBox();
			this.viewAttributeDelete_button = new System.Windows.Forms.Button();
			this.rotateToNearestPlane_button = new System.Windows.Forms.Button();
			this.hideShow_button = new System.Windows.Forms.Button();
			this.ghostMode_checkBox = new System.Windows.Forms.CheckBox();
			this.onTop_checkBox = new System.Windows.Forms.CheckBox();
			this.bolt_radioButton = new System.Windows.Forms.RadioButton();
			this.element_radioButton = new System.Windows.Forms.RadioButton();
			this.assembly_radioButton = new System.Windows.Forms.RadioButton();
			this.object_radioButton = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 1000;
			// 
			// select_button
			// 
			this.select_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.select_button.BackColor = System.Drawing.SystemColors.Window;
			this.select_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.select_button.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.select_button.Location = new System.Drawing.Point(0, 391);
			this.select_button.Margin = new System.Windows.Forms.Padding(0);
			this.select_button.Name = "select_button";
			this.select_button.Size = new System.Drawing.Size(59, 25);
			this.select_button.TabIndex = 42;
			this.select_button.Text = "Select";
			this.toolTip1.SetToolTip(this.select_button, "Sets selection filter");
			this.select_button.UseVisualStyleBackColor = false;
			this.select_button.Click += new System.EventHandler(this.Select_buttonClick);
			// 
			// refresh_button
			// 
			this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.refresh_button.BackColor = System.Drawing.SystemColors.Window;
			this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.refresh_button.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.refresh_button.Location = new System.Drawing.Point(0, 315);
			this.refresh_button.Margin = new System.Windows.Forms.Padding(0);
			this.refresh_button.Name = "refresh_button";
			this.refresh_button.Size = new System.Drawing.Size(59, 20);
			this.refresh_button.TabIndex = 46;
			this.refresh_button.Text = "Refresh";
			this.toolTip1.SetToolTip(this.refresh_button, "Refreshes lists on the right");
			this.refresh_button.UseVisualStyleBackColor = false;
			this.refresh_button.Click += new System.EventHandler(this.Refresh_buttonClick);
			// 
			// add_button
			// 
			this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.add_button.BackColor = System.Drawing.SystemColors.Window;
			this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.add_button.Font = new System.Drawing.Font("Arial", 6.75F);
			this.add_button.Location = new System.Drawing.Point(0, 334);
			this.add_button.Margin = new System.Windows.Forms.Padding(0);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(59, 20);
			this.add_button.TabIndex = 45;
			this.add_button.Text = "Add phase";
			this.toolTip1.SetToolTip(this.add_button, "Adds new phase to the model");
			this.add_button.UseVisualStyleBackColor = false;
			this.add_button.Click += new System.EventHandler(this.Add_buttonClick);
			// 
			// setPhase_button
			// 
			this.setPhase_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.setPhase_button.BackColor = System.Drawing.SystemColors.Window;
			this.setPhase_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.setPhase_button.Font = new System.Drawing.Font("Arial", 6.5F);
			this.setPhase_button.Location = new System.Drawing.Point(0, 372);
			this.setPhase_button.Margin = new System.Windows.Forms.Padding(0);
			this.setPhase_button.Name = "setPhase_button";
			this.setPhase_button.Size = new System.Drawing.Size(59, 20);
			this.setPhase_button.TabIndex = 44;
			this.setPhase_button.Text = "Set current";
			this.toolTip1.SetToolTip(this.setPhase_button, "Sets selected phase as new current phase");
			this.setPhase_button.UseVisualStyleBackColor = false;
			this.setPhase_button.Click += new System.EventHandler(this.SetPhase_buttonClick);
			// 
			// changePhase_button
			// 
			this.changePhase_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.changePhase_button.BackColor = System.Drawing.SystemColors.Window;
			this.changePhase_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.changePhase_button.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.changePhase_button.Location = new System.Drawing.Point(0, 353);
			this.changePhase_button.Margin = new System.Windows.Forms.Padding(0);
			this.changePhase_button.Name = "changePhase_button";
			this.changePhase_button.Size = new System.Drawing.Size(59, 20);
			this.changePhase_button.TabIndex = 43;
			this.changePhase_button.Text = "Modify";
			this.toolTip1.SetToolTip(this.changePhase_button, "Modify phase of selected objects");
			this.changePhase_button.UseVisualStyleBackColor = false;
			this.changePhase_button.Click += new System.EventHandler(this.ChangePhase_buttonClick);
			// 
			// redraw_button
			// 
			this.redraw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.redraw_button.BackColor = System.Drawing.SystemColors.Window;
			this.redraw_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.redraw_button.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.redraw_button.Location = new System.Drawing.Point(0, 415);
			this.redraw_button.Margin = new System.Windows.Forms.Padding(0);
			this.redraw_button.Name = "redraw_button";
			this.redraw_button.Size = new System.Drawing.Size(59, 25);
			this.redraw_button.TabIndex = 41;
			this.redraw_button.Text = "Redraw";
			this.toolTip1.SetToolTip(this.redraw_button, "Sets view filter");
			this.redraw_button.UseVisualStyleBackColor = false;
			this.redraw_button.Click += new System.EventHandler(this.Redraw_buttonClick);
			// 
			// unSelectView_checkBox
			// 
			this.unSelectView_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.unSelectView_checkBox.AutoCheck = false;
			this.unSelectView_checkBox.Location = new System.Drawing.Point(150, 415);
			this.unSelectView_checkBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.unSelectView_checkBox.Name = "unSelectView_checkBox";
			this.unSelectView_checkBox.Size = new System.Drawing.Size(13, 13);
			this.unSelectView_checkBox.TabIndex = 40;
			this.toolTip1.SetToolTip(this.unSelectView_checkBox, "Deselects all items on the list above");
			this.unSelectView_checkBox.UseVisualStyleBackColor = true;
			this.unSelectView_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnSelectView_checkBoxMouseDown);
			// 
			// selectView_checkBox
			// 
			this.selectView_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.selectView_checkBox.AutoCheck = false;
			this.selectView_checkBox.Checked = true;
			this.selectView_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.selectView_checkBox.Location = new System.Drawing.Point(126, 415);
			this.selectView_checkBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.selectView_checkBox.Name = "selectView_checkBox";
			this.selectView_checkBox.Size = new System.Drawing.Size(13, 13);
			this.selectView_checkBox.TabIndex = 39;
			this.toolTip1.SetToolTip(this.selectView_checkBox, "selects everything on the list above");
			this.selectView_checkBox.UseVisualStyleBackColor = true;
			this.selectView_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectView_checkBoxMouseDown);
			// 
			// unSelectSelect_checkBox
			// 
			this.unSelectSelect_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.unSelectSelect_checkBox.AutoCheck = false;
			this.unSelectSelect_checkBox.Location = new System.Drawing.Point(84, 415);
			this.unSelectSelect_checkBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.unSelectSelect_checkBox.Name = "unSelectSelect_checkBox";
			this.unSelectSelect_checkBox.Size = new System.Drawing.Size(13, 13);
			this.unSelectSelect_checkBox.TabIndex = 38;
			this.toolTip1.SetToolTip(this.unSelectSelect_checkBox, "Deselects all items on the list above");
			this.unSelectSelect_checkBox.UseVisualStyleBackColor = true;
			this.unSelectSelect_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnSelectSelect_checkBoxMouseDown);
			// 
			// selectSelect_checkBox
			// 
			this.selectSelect_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.selectSelect_checkBox.AutoCheck = false;
			this.selectSelect_checkBox.Checked = true;
			this.selectSelect_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.selectSelect_checkBox.Location = new System.Drawing.Point(62, 415);
			this.selectSelect_checkBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.selectSelect_checkBox.Name = "selectSelect_checkBox";
			this.selectSelect_checkBox.Size = new System.Drawing.Size(13, 13);
			this.selectSelect_checkBox.TabIndex = 37;
			this.toolTip1.SetToolTip(this.selectSelect_checkBox, "Select all items on the list above");
			this.selectSelect_checkBox.UseVisualStyleBackColor = true;
			this.selectSelect_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectSelect_checkBoxMouseDown);
			// 
			// unSelectCheck_checkBox
			// 
			this.unSelectCheck_checkBox.AutoCheck = false;
			this.unSelectCheck_checkBox.Location = new System.Drawing.Point(30, 21);
			this.unSelectCheck_checkBox.Name = "unSelectCheck_checkBox";
			this.unSelectCheck_checkBox.Size = new System.Drawing.Size(13, 13);
			this.unSelectCheck_checkBox.TabIndex = 63;
			this.toolTip1.SetToolTip(this.unSelectCheck_checkBox, "Unchecks all items below");
			this.unSelectCheck_checkBox.UseVisualStyleBackColor = true;
			this.unSelectCheck_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnSelectCheck_checkBoxMouseDown);
			// 
			// selectCheck_checkBox
			// 
			this.selectCheck_checkBox.AutoCheck = false;
			this.selectCheck_checkBox.Checked = true;
			this.selectCheck_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.selectCheck_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.selectCheck_checkBox.Location = new System.Drawing.Point(11, 21);
			this.selectCheck_checkBox.Name = "selectCheck_checkBox";
			this.selectCheck_checkBox.Size = new System.Drawing.Size(13, 13);
			this.selectCheck_checkBox.TabIndex = 62;
			this.toolTip1.SetToolTip(this.selectCheck_checkBox, "Checks all items below");
			this.selectCheck_checkBox.UseVisualStyleBackColor = true;
			this.selectCheck_checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectCheck_checkBoxMouseDown);
			// 
			// select_checkedListBox
			// 
			this.select_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.select_checkedListBox.BackColor = System.Drawing.SystemColors.Window;
			this.select_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.select_checkedListBox.CheckOnClick = true;
			this.select_checkedListBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.select_checkedListBox.FormattingEnabled = true;
			this.select_checkedListBox.Location = new System.Drawing.Point(59, 35);
			this.select_checkedListBox.Margin = new System.Windows.Forms.Padding(0);
			this.select_checkedListBox.Name = "select_checkedListBox";
			this.select_checkedListBox.Size = new System.Drawing.Size(80, 377);
			this.select_checkedListBox.TabIndex = 53;
			this.toolTip1.SetToolTip(this.select_checkedListBox, "Right click on the list changes selection filter");
			this.select_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox2SelectedIndexChanged);
			this.select_checkedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBox2MouseUp);
			// 
			// onlySelectedViews_checkBox
			// 
			this.onlySelectedViews_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.onlySelectedViews_checkBox.Location = new System.Drawing.Point(145, 19);
			this.onlySelectedViews_checkBox.Name = "onlySelectedViews_checkBox";
			this.onlySelectedViews_checkBox.Size = new System.Drawing.Size(125, 18);
			this.onlySelectedViews_checkBox.TabIndex = 65;
			this.onlySelectedViews_checkBox.Text = "Only selected views";
			this.toolTip1.SetToolTip(this.onlySelectedViews_checkBox, "Sets view filter only on selected views");
			this.onlySelectedViews_checkBox.UseVisualStyleBackColor = true;
			// 
			// grid_checkBox
			// 
			this.grid_checkBox.Checked = true;
			this.grid_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.grid_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.grid_checkBox.Location = new System.Drawing.Point(1, 35);
			this.grid_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.grid_checkBox.Name = "grid_checkBox";
			this.grid_checkBox.Size = new System.Drawing.Size(67, 14);
			this.grid_checkBox.TabIndex = 60;
			this.grid_checkBox.Text = "Grids";
			this.toolTip1.SetToolTip(this.grid_checkBox, "Turns on/off grids");
			this.grid_checkBox.UseVisualStyleBackColor = true;
			this.grid_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// holes_checkBox
			// 
			this.holes_checkBox.Checked = true;
			this.holes_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.holes_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.holes_checkBox.Location = new System.Drawing.Point(1, 65);
			this.holes_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.holes_checkBox.Name = "holes_checkBox";
			this.holes_checkBox.Size = new System.Drawing.Size(67, 14);
			this.holes_checkBox.TabIndex = 64;
			this.holes_checkBox.Text = "Holes";
			this.toolTip1.SetToolTip(this.holes_checkBox, "Turns on/off holes");
			this.holes_checkBox.UseVisualStyleBackColor = true;
			this.holes_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// bolt_checkBox
			// 
			this.bolt_checkBox.Checked = true;
			this.bolt_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.bolt_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bolt_checkBox.Location = new System.Drawing.Point(1, 50);
			this.bolt_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.bolt_checkBox.Name = "bolt_checkBox";
			this.bolt_checkBox.Size = new System.Drawing.Size(67, 14);
			this.bolt_checkBox.TabIndex = 54;
			this.bolt_checkBox.Text = "Bolts";
			this.toolTip1.SetToolTip(this.bolt_checkBox, "Turns on/off bolts");
			this.bolt_checkBox.UseVisualStyleBackColor = true;
			this.bolt_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// component_checkBox
			// 
			this.component_checkBox.Font = new System.Drawing.Font("Arial", 6.5F);
			this.component_checkBox.Location = new System.Drawing.Point(1, 127);
			this.component_checkBox.Name = "component_checkBox";
			this.component_checkBox.Size = new System.Drawing.Size(58, 28);
			this.component_checkBox.TabIndex = 55;
			this.component_checkBox.Text = "Components";
			this.toolTip1.SetToolTip(this.component_checkBox, "Turns on/off component symbols\r\n");
			this.component_checkBox.UseVisualStyleBackColor = true;
			this.component_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// lines_checkBox
			// 
			this.lines_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.lines_checkBox.Location = new System.Drawing.Point(1, 111);
			this.lines_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.lines_checkBox.Name = "lines_checkBox";
			this.lines_checkBox.Size = new System.Drawing.Size(67, 14);
			this.lines_checkBox.TabIndex = 56;
			this.lines_checkBox.Text = "Lines";
			this.toolTip1.SetToolTip(this.lines_checkBox, "Turns on/off construction lines");
			this.lines_checkBox.UseVisualStyleBackColor = true;
			this.lines_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// weld_checkBox
			// 
			this.weld_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.weld_checkBox.Location = new System.Drawing.Point(1, 80);
			this.weld_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.weld_checkBox.Name = "weld_checkBox";
			this.weld_checkBox.Size = new System.Drawing.Size(67, 14);
			this.weld_checkBox.TabIndex = 57;
			this.weld_checkBox.Text = "Welds";
			this.toolTip1.SetToolTip(this.weld_checkBox, "Turns on/off welds");
			this.weld_checkBox.UseVisualStyleBackColor = true;
			this.weld_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// cut_checkBox
			// 
			this.cut_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.cut_checkBox.Location = new System.Drawing.Point(1, 171);
			this.cut_checkBox.Name = "cut_checkBox";
			this.cut_checkBox.Size = new System.Drawing.Size(67, 14);
			this.cut_checkBox.TabIndex = 58;
			this.cut_checkBox.Text = "Cuts";
			this.toolTip1.SetToolTip(this.cut_checkBox, "Turns on/off cuts");
			this.cut_checkBox.UseVisualStyleBackColor = true;
			this.cut_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// fitting_checkBox
			// 
			this.fitting_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.fitting_checkBox.Location = new System.Drawing.Point(1, 154);
			this.fitting_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.fitting_checkBox.Name = "fitting_checkBox";
			this.fitting_checkBox.Size = new System.Drawing.Size(67, 16);
			this.fitting_checkBox.TabIndex = 59;
			this.fitting_checkBox.Text = "Fittings";
			this.toolTip1.SetToolTip(this.fitting_checkBox, "Turns on/off fittings");
			this.fitting_checkBox.UseVisualStyleBackColor = true;
			this.fitting_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// points_checkBox
			// 
			this.points_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.points_checkBox.Location = new System.Drawing.Point(1, 95);
			this.points_checkBox.Margin = new System.Windows.Forms.Padding(0);
			this.points_checkBox.Name = "points_checkBox";
			this.points_checkBox.Size = new System.Drawing.Size(67, 14);
			this.points_checkBox.TabIndex = 61;
			this.points_checkBox.Text = "Points";
			this.toolTip1.SetToolTip(this.points_checkBox, "Turns on/off points");
			this.points_checkBox.UseVisualStyleBackColor = true;
			this.points_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// view_checkedListBox
			// 
			this.view_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.view_checkedListBox.BackColor = System.Drawing.SystemColors.Window;
			this.view_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.view_checkedListBox.CheckOnClick = true;
			this.view_checkedListBox.FormattingEnabled = true;
			this.view_checkedListBox.Location = new System.Drawing.Point(139, 35);
			this.view_checkedListBox.Margin = new System.Windows.Forms.Padding(0);
			this.view_checkedListBox.Name = "view_checkedListBox";
			this.view_checkedListBox.Size = new System.Drawing.Size(107, 377);
			this.view_checkedListBox.TabIndex = 52;
			this.toolTip1.SetToolTip(this.view_checkedListBox, "Right click on the list changes view filter");
			this.view_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1SelectedIndexChanged);
			this.view_checkedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBox1MouseUp);
			// 
			// rebars_checkBox
			// 
			this.rebars_checkBox.Checked = true;
			this.rebars_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.rebars_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.rebars_checkBox.Location = new System.Drawing.Point(1, 190);
			this.rebars_checkBox.Name = "rebars_checkBox";
			this.rebars_checkBox.Size = new System.Drawing.Size(62, 14);
			this.rebars_checkBox.TabIndex = 72;
			this.rebars_checkBox.Text = "Rebars";
			this.toolTip1.SetToolTip(this.rebars_checkBox, "Turns on/off rebars");
			this.rebars_checkBox.UseVisualStyleBackColor = true;
			this.rebars_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// references_checkBox
			// 
			this.references_checkBox.Checked = true;
			this.references_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.references_checkBox.Font = new System.Drawing.Font("Arial", 6.5F);
			this.references_checkBox.Location = new System.Drawing.Point(1, 208);
			this.references_checkBox.Name = "references_checkBox";
			this.references_checkBox.Size = new System.Drawing.Size(62, 28);
			this.references_checkBox.TabIndex = 73;
			this.references_checkBox.Text = "References";
			this.toolTip1.SetToolTip(this.references_checkBox, "Turns on/off reference models");
			this.references_checkBox.UseVisualStyleBackColor = true;
			this.references_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// loads_checkBox
			// 
			this.loads_checkBox.Checked = true;
			this.loads_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.loads_checkBox.Font = new System.Drawing.Font("Arial", 7F);
			this.loads_checkBox.Location = new System.Drawing.Point(1, 233);
			this.loads_checkBox.Name = "loads_checkBox";
			this.loads_checkBox.Size = new System.Drawing.Size(62, 14);
			this.loads_checkBox.TabIndex = 74;
			this.loads_checkBox.Text = "Loads";
			this.toolTip1.SetToolTip(this.loads_checkBox, "Turns on/off loads");
			this.loads_checkBox.UseVisualStyleBackColor = true;
			this.loads_checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// viewAttributeLoad_button
			// 
			this.viewAttributeLoad_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.viewAttributeLoad_button.BackColor = System.Drawing.SystemColors.Window;
			this.viewAttributeLoad_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.viewAttributeLoad_button.Location = new System.Drawing.Point(198, 0);
			this.viewAttributeLoad_button.Margin = new System.Windows.Forms.Padding(0);
			this.viewAttributeLoad_button.Name = "viewAttributeLoad_button";
			this.viewAttributeLoad_button.Size = new System.Drawing.Size(22, 22);
			this.viewAttributeLoad_button.TabIndex = 67;
			this.viewAttributeLoad_button.Text = "L";
			this.toolTip1.SetToolTip(this.viewAttributeLoad_button, "Load checked phases to list from attribute file");
			this.viewAttributeLoad_button.UseVisualStyleBackColor = false;
			this.viewAttributeLoad_button.Click += new System.EventHandler(this.ViewAttributeLoad_buttonClick);
			// 
			// viewAttributeSave_button
			// 
			this.viewAttributeSave_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.viewAttributeSave_button.BackColor = System.Drawing.SystemColors.Window;
			this.viewAttributeSave_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.viewAttributeSave_button.Location = new System.Drawing.Point(220, 0);
			this.viewAttributeSave_button.Margin = new System.Windows.Forms.Padding(0);
			this.viewAttributeSave_button.Name = "viewAttributeSave_button";
			this.viewAttributeSave_button.Size = new System.Drawing.Size(22, 22);
			this.viewAttributeSave_button.TabIndex = 68;
			this.viewAttributeSave_button.Text = "S";
			this.toolTip1.SetToolTip(this.viewAttributeSave_button, "Save checkeded phases from list to attribute file");
			this.viewAttributeSave_button.UseVisualStyleBackColor = false;
			this.viewAttributeSave_button.Click += new System.EventHandler(this.ViewAttributeSave_buttonClick);
			// 
			// viewAttribute_comboBox
			// 
			this.viewAttribute_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.viewAttribute_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.viewAttribute_comboBox.FormattingEnabled = true;
			this.viewAttribute_comboBox.Location = new System.Drawing.Point(128, 0);
			this.viewAttribute_comboBox.Margin = new System.Windows.Forms.Padding(0);
			this.viewAttribute_comboBox.Name = "viewAttribute_comboBox";
			this.viewAttribute_comboBox.Size = new System.Drawing.Size(70, 21);
			this.viewAttribute_comboBox.TabIndex = 66;
			this.toolTip1.SetToolTip(this.viewAttribute_comboBox, "Save or load list of checked items from list bellow");
			// 
			// selectAttribute_comboBox
			// 
			this.selectAttribute_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.selectAttribute_comboBox.FormattingEnabled = true;
			this.selectAttribute_comboBox.Location = new System.Drawing.Point(1, 0);
			this.selectAttribute_comboBox.Margin = new System.Windows.Forms.Padding(0);
			this.selectAttribute_comboBox.Name = "selectAttribute_comboBox";
			this.selectAttribute_comboBox.Size = new System.Drawing.Size(127, 21);
			this.selectAttribute_comboBox.TabIndex = 69;
			this.toolTip1.SetToolTip(this.selectAttribute_comboBox, "Changes view representation");
			this.selectAttribute_comboBox.SelectedIndexChanged += new System.EventHandler(this.CheckBoxesChanged);
			// 
			// viewAttributeDelete_button
			// 
			this.viewAttributeDelete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.viewAttributeDelete_button.BackColor = System.Drawing.SystemColors.Window;
			this.viewAttributeDelete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.viewAttributeDelete_button.Location = new System.Drawing.Point(242, 0);
			this.viewAttributeDelete_button.Margin = new System.Windows.Forms.Padding(0);
			this.viewAttributeDelete_button.Name = "viewAttributeDelete_button";
			this.viewAttributeDelete_button.Size = new System.Drawing.Size(22, 22);
			this.viewAttributeDelete_button.TabIndex = 76;
			this.viewAttributeDelete_button.Text = "D";
			this.toolTip1.SetToolTip(this.viewAttributeDelete_button, "Deletes attribute file from the list");
			this.viewAttributeDelete_button.UseVisualStyleBackColor = false;
			this.viewAttributeDelete_button.Click += new System.EventHandler(this.ViewAttributeDelete_buttonClick);
			// 
			// rotateToNearestPlane_button
			// 
			this.rotateToNearestPlane_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rotateToNearestPlane_button.BackColor = System.Drawing.SystemColors.Window;
			this.rotateToNearestPlane_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.rotateToNearestPlane_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rotateToNearestPlane_button.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rotateToNearestPlane_button.Location = new System.Drawing.Point(182, 415);
			this.rotateToNearestPlane_button.Margin = new System.Windows.Forms.Padding(0);
			this.rotateToNearestPlane_button.Name = "rotateToNearestPlane_button";
			this.rotateToNearestPlane_button.Size = new System.Drawing.Size(82, 25);
			this.rotateToNearestPlane_button.TabIndex = 77;
			this.rotateToNearestPlane_button.Text = "Nearest plane";
			this.toolTip1.SetToolTip(this.rotateToNearestPlane_button, "Rotates selected view to nearest orthodonal plane");
			this.rotateToNearestPlane_button.UseVisualStyleBackColor = false;
			this.rotateToNearestPlane_button.Click += new System.EventHandler(this.RotateToNearestPlane_buttonClick);
			// 
			// hideShow_button
			// 
			this.hideShow_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.hideShow_button.BackColor = System.Drawing.SystemColors.Window;
			this.hideShow_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.hideShow_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.hideShow_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.hideShow_button.Location = new System.Drawing.Point(246, 35);
			this.hideShow_button.Margin = new System.Windows.Forms.Padding(0);
			this.hideShow_button.Name = "hideShow_button";
			this.hideShow_button.Size = new System.Drawing.Size(18, 377);
			this.hideShow_button.TabIndex = 78;
			this.hideShow_button.Text = "<";
			this.toolTip1.SetToolTip(this.hideShow_button, "Hide or show Filrering Tool");
			this.hideShow_button.UseVisualStyleBackColor = false;
			this.hideShow_button.Click += new System.EventHandler(this.HideShow_buttonClick);
			// 
			// ghostMode_checkBox
			// 
			this.ghostMode_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ghostMode_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ghostMode_checkBox.Location = new System.Drawing.Point(103, 427);
			this.ghostMode_checkBox.Name = "ghostMode_checkBox";
			this.ghostMode_checkBox.Size = new System.Drawing.Size(85, 18);
			this.ghostMode_checkBox.TabIndex = 79;
			this.ghostMode_checkBox.Text = "Ghost mode";
			this.toolTip1.SetToolTip(this.ghostMode_checkBox, "Hide window after 5 seconds");
			this.ghostMode_checkBox.UseVisualStyleBackColor = true;
			// 
			// onTop_checkBox
			// 
			this.onTop_checkBox.Checked = true;
			this.onTop_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.onTop_checkBox.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.onTop_checkBox.Location = new System.Drawing.Point(53, 20);
			this.onTop_checkBox.Name = "onTop_checkBox";
			this.onTop_checkBox.Size = new System.Drawing.Size(95, 17);
			this.onTop_checkBox.TabIndex = 75;
			this.onTop_checkBox.Text = "Always on top";
			this.onTop_checkBox.UseVisualStyleBackColor = true;
			this.onTop_checkBox.CheckedChanged += new System.EventHandler(this.OnTop_checkBoxCheckedChanged);
			// 
			// bolt_radioButton
			// 
			this.bolt_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bolt_radioButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bolt_radioButton.Location = new System.Drawing.Point(0, 296);
			this.bolt_radioButton.Margin = new System.Windows.Forms.Padding(0);
			this.bolt_radioButton.Name = "bolt_radioButton";
			this.bolt_radioButton.Size = new System.Drawing.Size(71, 15);
			this.bolt_radioButton.TabIndex = 51;
			this.bolt_radioButton.Text = "bolt";
			this.bolt_radioButton.UseVisualStyleBackColor = true;
			this.bolt_radioButton.CheckedChanged += new System.EventHandler(this.oae_RadioButtonChange);
			// 
			// element_radioButton
			// 
			this.element_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.element_radioButton.Font = new System.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.element_radioButton.Location = new System.Drawing.Point(0, 281);
			this.element_radioButton.Margin = new System.Windows.Forms.Padding(0);
			this.element_radioButton.Name = "element_radioButton";
			this.element_radioButton.Size = new System.Drawing.Size(71, 15);
			this.element_radioButton.TabIndex = 50;
			this.element_radioButton.Text = "part";
			this.element_radioButton.UseVisualStyleBackColor = true;
			this.element_radioButton.CheckedChanged += new System.EventHandler(this.oae_RadioButtonChange);
			// 
			// assembly_radioButton
			// 
			this.assembly_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.assembly_radioButton.Checked = true;
			this.assembly_radioButton.Font = new System.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.assembly_radioButton.Location = new System.Drawing.Point(0, 266);
			this.assembly_radioButton.Margin = new System.Windows.Forms.Padding(0);
			this.assembly_radioButton.Name = "assembly_radioButton";
			this.assembly_radioButton.Size = new System.Drawing.Size(64, 15);
			this.assembly_radioButton.TabIndex = 49;
			this.assembly_radioButton.TabStop = true;
			this.assembly_radioButton.Text = "assembly";
			this.assembly_radioButton.UseVisualStyleBackColor = true;
			this.assembly_radioButton.CheckedChanged += new System.EventHandler(this.oae_RadioButtonChange);
			// 
			// object_radioButton
			// 
			this.object_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.object_radioButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.object_radioButton.Location = new System.Drawing.Point(0, 251);
			this.object_radioButton.Margin = new System.Windows.Forms.Padding(0);
			this.object_radioButton.Name = "object_radioButton";
			this.object_radioButton.Size = new System.Drawing.Size(68, 15);
			this.object_radioButton.TabIndex = 48;
			this.object_radioButton.Text = "object";
			this.object_radioButton.UseVisualStyleBackColor = true;
			this.object_radioButton.CheckedChanged += new System.EventHandler(this.oae_RadioButtonChange);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(264, 442);
			this.Controls.Add(this.viewAttribute_comboBox);
			this.Controls.Add(this.view_checkedListBox);
			this.Controls.Add(this.hideShow_button);
			this.Controls.Add(this.rotateToNearestPlane_button);
			this.Controls.Add(this.viewAttributeDelete_button);
			this.Controls.Add(this.viewAttributeSave_button);
			this.Controls.Add(this.viewAttributeLoad_button);
			this.Controls.Add(this.onlySelectedViews_checkBox);
			this.Controls.Add(this.select_checkedListBox);
			this.Controls.Add(this.fitting_checkBox);
			this.Controls.Add(this.onTop_checkBox);
			this.Controls.Add(this.loads_checkBox);
			this.Controls.Add(this.references_checkBox);
			this.Controls.Add(this.rebars_checkBox);
			this.Controls.Add(this.selectAttribute_comboBox);
			this.Controls.Add(this.unSelectCheck_checkBox);
			this.Controls.Add(this.selectCheck_checkBox);
			this.Controls.Add(this.grid_checkBox);
			this.Controls.Add(this.holes_checkBox);
			this.Controls.Add(this.bolt_checkBox);
			this.Controls.Add(this.component_checkBox);
			this.Controls.Add(this.lines_checkBox);
			this.Controls.Add(this.weld_checkBox);
			this.Controls.Add(this.cut_checkBox);
			this.Controls.Add(this.points_checkBox);
			this.Controls.Add(this.bolt_radioButton);
			this.Controls.Add(this.element_radioButton);
			this.Controls.Add(this.assembly_radioButton);
			this.Controls.Add(this.object_radioButton);
			this.Controls.Add(this.select_button);
			this.Controls.Add(this.refresh_button);
			this.Controls.Add(this.add_button);
			this.Controls.Add(this.setPhase_button);
			this.Controls.Add(this.changePhase_button);
			this.Controls.Add(this.redraw_button);
			this.Controls.Add(this.unSelectView_checkBox);
			this.Controls.Add(this.selectView_checkBox);
			this.Controls.Add(this.unSelectSelect_checkBox);
			this.Controls.Add(this.selectSelect_checkBox);
			this.Controls.Add(this.ghostMode_checkBox);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(280, 480);
			this.Name = "MainForm";
			this.Opacity = 0.92D;
			this.Text = "Filtering Tool 4.10";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
		}
}
