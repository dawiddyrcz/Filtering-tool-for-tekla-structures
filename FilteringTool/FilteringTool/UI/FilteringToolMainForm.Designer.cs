/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

namespace FilteringTool.UI
{
    partial class FilteringToolMainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button redraw_button;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button changePhase_button;
        private System.Windows.Forms.Button setPhase_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox viewAttribute_comboBox;
        private System.Windows.Forms.Button viewAttributeLoad_button;
        private System.Windows.Forms.Button viewAttributeSave_button;
        private System.Windows.Forms.Button viewAttributeDelete_button;
        private System.Windows.Forms.Button hideShow_button;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteringToolMainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.select_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.setPhase_button = new System.Windows.Forms.Button();
            this.changePhase_button = new System.Windows.Forms.Button();
            this.redraw_button = new System.Windows.Forms.Button();
            this.viewAttributeLoad_button = new System.Windows.Forms.Button();
            this.viewAttributeSave_button = new System.Windows.Forms.Button();
            this.viewAttribute_comboBox = new System.Windows.Forms.ComboBox();
            this.viewAttributeDelete_button = new System.Windows.Forms.Button();
            this.hideShow_button = new System.Windows.Forms.Button();
            this.nearestPlane_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkboxesControl1 = new FilteringTool.UI.CheckboxesControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPanel2 = new System.Windows.Forms.Panel();
            this.buttonPanel1 = new System.Windows.Forms.Panel();
            this.select_checkedListBox = new FilteringTool.UI.SelectCheckedListBoxControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.view_checkedListBox = new FilteringTool.UI.ViewCheckedListBoxControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectNone_checkBox = new System.Windows.Forms.CheckBox();
            this.selectAllView_checkBox = new System.Windows.Forms.CheckBox();
            this.selectNoneSelect_checkBox = new System.Windows.Forms.CheckBox();
            this.selectAllSelect_checkBox = new System.Windows.Forms.CheckBox();
            this.objectInfo_label = new System.Windows.Forms.Label();
            this.mainMenuControl2 = new FilteringTool.UI.MainMenuControl();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.buttonPanel2.SuspendLayout();
            this.buttonPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // select_button
            // 
            this.select_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select_button.BackColor = System.Drawing.SystemColors.Window;
            this.select_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select_button.Font = new System.Drawing.Font("Arial", 8F);
            this.select_button.Location = new System.Drawing.Point(0, 21);
            this.select_button.Margin = new System.Windows.Forms.Padding(0);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(88, 25);
            this.select_button.TabIndex = 42;
            this.select_button.Text = "Set selection";
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
            this.refresh_button.Font = new System.Drawing.Font("Arial", 8F);
            this.refresh_button.Location = new System.Drawing.Point(0, 1);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(0);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(88, 21);
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
            this.add_button.Font = new System.Drawing.Font("Arial", 8F);
            this.add_button.Location = new System.Drawing.Point(0, 1);
            this.add_button.Margin = new System.Windows.Forms.Padding(0);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(88, 20);
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
            this.setPhase_button.Font = new System.Drawing.Font("Arial", 8F);
            this.setPhase_button.Location = new System.Drawing.Point(0, 22);
            this.setPhase_button.Margin = new System.Windows.Forms.Padding(0);
            this.setPhase_button.Name = "setPhase_button";
            this.setPhase_button.Size = new System.Drawing.Size(88, 21);
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
            this.changePhase_button.Font = new System.Drawing.Font("Arial", 8F);
            this.changePhase_button.Location = new System.Drawing.Point(0, 43);
            this.changePhase_button.Margin = new System.Windows.Forms.Padding(0);
            this.changePhase_button.Name = "changePhase_button";
            this.changePhase_button.Size = new System.Drawing.Size(88, 21);
            this.changePhase_button.TabIndex = 43;
            this.changePhase_button.Text = "Move to phase";
            this.toolTip1.SetToolTip(this.changePhase_button, "Modify phase of selected objects");
            this.changePhase_button.UseVisualStyleBackColor = false;
            this.changePhase_button.Click += new System.EventHandler(this.MoveToPhase_buttonClick);
            // 
            // redraw_button
            // 
            this.redraw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.redraw_button.BackColor = System.Drawing.SystemColors.Window;
            this.redraw_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redraw_button.Font = new System.Drawing.Font("Arial", 8F);
            this.redraw_button.Location = new System.Drawing.Point(0, 45);
            this.redraw_button.Margin = new System.Windows.Forms.Padding(0);
            this.redraw_button.Name = "redraw_button";
            this.redraw_button.Size = new System.Drawing.Size(88, 25);
            this.redraw_button.TabIndex = 41;
            this.redraw_button.Text = "Set view filter";
            this.toolTip1.SetToolTip(this.redraw_button, "Sets view filter");
            this.redraw_button.UseVisualStyleBackColor = false;
            this.redraw_button.Click += new System.EventHandler(this.Redraw_buttonClick);
            // 
            // viewAttributeLoad_button
            // 
            this.viewAttributeLoad_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAttributeLoad_button.BackColor = System.Drawing.SystemColors.Window;
            this.viewAttributeLoad_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAttributeLoad_button.Location = new System.Drawing.Point(317, 0);
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
            this.viewAttributeSave_button.Location = new System.Drawing.Point(339, 0);
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
            this.viewAttribute_comboBox.Location = new System.Drawing.Point(89, 1);
            this.viewAttribute_comboBox.Margin = new System.Windows.Forms.Padding(0);
            this.viewAttribute_comboBox.Name = "viewAttribute_comboBox";
            this.viewAttribute_comboBox.Size = new System.Drawing.Size(228, 21);
            this.viewAttribute_comboBox.TabIndex = 66;
            this.toolTip1.SetToolTip(this.viewAttribute_comboBox, "Save or load list of checked items from list bellow");
            // 
            // viewAttributeDelete_button
            // 
            this.viewAttributeDelete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAttributeDelete_button.BackColor = System.Drawing.SystemColors.Window;
            this.viewAttributeDelete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAttributeDelete_button.Location = new System.Drawing.Point(361, 0);
            this.viewAttributeDelete_button.Margin = new System.Windows.Forms.Padding(0);
            this.viewAttributeDelete_button.Name = "viewAttributeDelete_button";
            this.viewAttributeDelete_button.Size = new System.Drawing.Size(22, 22);
            this.viewAttributeDelete_button.TabIndex = 76;
            this.viewAttributeDelete_button.Text = "D";
            this.toolTip1.SetToolTip(this.viewAttributeDelete_button, "Deletes attribute file from the list");
            this.viewAttributeDelete_button.UseVisualStyleBackColor = false;
            this.viewAttributeDelete_button.Click += new System.EventHandler(this.ViewAttributeDelete_buttonClick);
            // 
            // hideShow_button
            // 
            this.hideShow_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hideShow_button.BackColor = System.Drawing.SystemColors.Window;
            this.hideShow_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hideShow_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideShow_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.hideShow_button.Location = new System.Drawing.Point(365, 22);
            this.hideShow_button.Margin = new System.Windows.Forms.Padding(0);
            this.hideShow_button.Name = "hideShow_button";
            this.hideShow_button.Size = new System.Drawing.Size(18, 505);
            this.hideShow_button.TabIndex = 78;
            this.hideShow_button.Text = "<";
            this.toolTip1.SetToolTip(this.hideShow_button, "Hide or show Filrering Tool");
            this.hideShow_button.UseVisualStyleBackColor = false;
            this.hideShow_button.Click += new System.EventHandler(this.HideShow_buttonClick);
            this.hideShow_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HideShow_button_MouseMove);
            // 
            // nearestPlane_button
            // 
            this.nearestPlane_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nearestPlane_button.BackColor = System.Drawing.SystemColors.Window;
            this.nearestPlane_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nearestPlane_button.Font = new System.Drawing.Font("Arial", 8F);
            this.nearestPlane_button.Location = new System.Drawing.Point(1, 64);
            this.nearestPlane_button.Margin = new System.Windows.Forms.Padding(0);
            this.nearestPlane_button.Name = "nearestPlane_button";
            this.nearestPlane_button.Size = new System.Drawing.Size(88, 21);
            this.nearestPlane_button.TabIndex = 47;
            this.nearestPlane_button.Text = "Nearest plane";
            this.toolTip1.SetToolTip(this.nearestPlane_button, "Rotate selected views to nearest plane");
            this.nearestPlane_button.UseVisualStyleBackColor = false;
            this.nearestPlane_button.Click += new System.EventHandler(this.NearestPlane_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkboxesControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 349);
            this.panel1.TabIndex = 81;
            // 
            // checkboxesControl1
            // 
            this.checkboxesControl1.BackColor = System.Drawing.SystemColors.Window;
            this.checkboxesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkboxesControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxesControl1.Location = new System.Drawing.Point(0, 0);
            this.checkboxesControl1.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxesControl1.ModifierKey = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.checkboxesControl1.Name = "checkboxesControl1";
            this.checkboxesControl1.Size = new System.Drawing.Size(88, 349);
            this.checkboxesControl1.TabIndex = 0;
            this.checkboxesControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckboxesControl1_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.buttonPanel2);
            this.panel4.Controls.Add(this.buttonPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 503);
            this.panel4.TabIndex = 0;
            // 
            // buttonPanel2
            // 
            this.buttonPanel2.Controls.Add(this.nearestPlane_button);
            this.buttonPanel2.Controls.Add(this.refresh_button);
            this.buttonPanel2.Controls.Add(this.changePhase_button);
            this.buttonPanel2.Controls.Add(this.setPhase_button);
            this.buttonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel2.Location = new System.Drawing.Point(0, 349);
            this.buttonPanel2.Name = "buttonPanel2";
            this.buttonPanel2.Size = new System.Drawing.Size(88, 84);
            this.buttonPanel2.TabIndex = 83;
            // 
            // buttonPanel1
            // 
            this.buttonPanel1.Controls.Add(this.redraw_button);
            this.buttonPanel1.Controls.Add(this.select_button);
            this.buttonPanel1.Controls.Add(this.add_button);
            this.buttonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel1.Location = new System.Drawing.Point(0, 433);
            this.buttonPanel1.Name = "buttonPanel1";
            this.buttonPanel1.Size = new System.Drawing.Size(88, 70);
            this.buttonPanel1.TabIndex = 82;
            // 
            // select_checkedListBox
            // 
            this.select_checkedListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.select_checkedListBox.Location = new System.Drawing.Point(0, 0);
            this.select_checkedListBox.Name = "select_checkedListBox";
            this.select_checkedListBox.Size = new System.Drawing.Size(60, 472);
            this.select_checkedListBox.TabIndex = 55;
            this.select_checkedListBox.TopIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(1, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 503);
            this.panel3.TabIndex = 83;
            this.panel3.Resize += new System.EventHandler(this.Panel3_Resize);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.view_checkedListBox);
            this.panel7.Controls.Add(this.select_checkedListBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(88, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 472);
            this.panel7.TabIndex = 43;
            // 
            // view_checkedListBox
            // 
            this.view_checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_checkedListBox.Location = new System.Drawing.Point(60, 0);
            this.view_checkedListBox.Name = "view_checkedListBox";
            this.view_checkedListBox.Size = new System.Drawing.Size(216, 472);
            this.view_checkedListBox.TabIndex = 1;
            this.view_checkedListBox.TopIndex = 0;
            this.view_checkedListBox.RedrawViewClicked += new System.Action(this.View_checkedListBox_RedrawViewClicked);
            this.view_checkedListBox.ViewMouseMove += new System.Action(this.ViewMouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectNone_checkBox);
            this.panel2.Controls.Add(this.selectAllView_checkBox);
            this.panel2.Controls.Add(this.selectNoneSelect_checkBox);
            this.panel2.Controls.Add(this.selectAllSelect_checkBox);
            this.panel2.Controls.Add(this.objectInfo_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(88, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 31);
            this.panel2.TabIndex = 42;
            // 
            // selectNone_checkBox
            // 
            this.selectNone_checkBox.AutoSize = true;
            this.selectNone_checkBox.Location = new System.Drawing.Point(89, 0);
            this.selectNone_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectNone_checkBox.Name = "selectNone_checkBox";
            this.selectNone_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectNone_checkBox.TabIndex = 45;
            this.selectNone_checkBox.UseVisualStyleBackColor = true;
            this.selectNone_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectNone_checkBox_MouseUp);
            // 
            // selectAllView_checkBox
            // 
            this.selectAllView_checkBox.AutoSize = true;
            this.selectAllView_checkBox.Checked = true;
            this.selectAllView_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectAllView_checkBox.Location = new System.Drawing.Point(74, 0);
            this.selectAllView_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectAllView_checkBox.Name = "selectAllView_checkBox";
            this.selectAllView_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectAllView_checkBox.TabIndex = 44;
            this.selectAllView_checkBox.UseVisualStyleBackColor = true;
            this.selectAllView_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectAllView_checkBox_MouseUp);
            // 
            // selectNoneSelect_checkBox
            // 
            this.selectNoneSelect_checkBox.AutoSize = true;
            this.selectNoneSelect_checkBox.Location = new System.Drawing.Point(27, 0);
            this.selectNoneSelect_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectNoneSelect_checkBox.Name = "selectNoneSelect_checkBox";
            this.selectNoneSelect_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectNoneSelect_checkBox.TabIndex = 43;
            this.selectNoneSelect_checkBox.UseVisualStyleBackColor = true;
            this.selectNoneSelect_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectNoneSelect_checkBox_MouseUp);
            // 
            // selectAllSelect_checkBox
            // 
            this.selectAllSelect_checkBox.AutoSize = true;
            this.selectAllSelect_checkBox.Checked = true;
            this.selectAllSelect_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectAllSelect_checkBox.Location = new System.Drawing.Point(12, 0);
            this.selectAllSelect_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectAllSelect_checkBox.Name = "selectAllSelect_checkBox";
            this.selectAllSelect_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectAllSelect_checkBox.TabIndex = 42;
            this.selectAllSelect_checkBox.UseVisualStyleBackColor = true;
            this.selectAllSelect_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectAllSelect_checkBox_MouseUp);
            // 
            // objectInfo_label
            // 
            this.objectInfo_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.objectInfo_label.AutoSize = true;
            this.objectInfo_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.objectInfo_label.Location = new System.Drawing.Point(3, 14);
            this.objectInfo_label.Name = "objectInfo_label";
            this.objectInfo_label.Size = new System.Drawing.Size(57, 14);
            this.objectInfo_label.TabIndex = 41;
            this.objectInfo_label.Text = "object info";
            // 
            // mainMenuControl2
            // 
            this.mainMenuControl2.Location = new System.Drawing.Point(2, 0);
            this.mainMenuControl2.Name = "mainMenuControl2";
            this.mainMenuControl2.Size = new System.Drawing.Size(69, 22);
            this.mainMenuControl2.TabIndex = 84;
            // 
            // FilteringToolMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(383, 524);
            this.Controls.Add(this.mainMenuControl2);
            this.Controls.Add(this.hideShow_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.viewAttribute_comboBox);
            this.Controls.Add(this.viewAttributeDelete_button);
            this.Controls.Add(this.viewAttributeSave_button);
            this.Controls.Add(this.viewAttributeLoad_button);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(150, 110);
            this.Name = "FilteringToolMainForm";
            this.Text = "Open source Filtering Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.buttonPanel2.ResumeLayout(false);
            this.buttonPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel buttonPanel2;
        private System.Windows.Forms.Panel buttonPanel1;
        private MainMenuControl mainMenuControl2;
        private CheckboxesControl checkboxesControl1;
        private System.Windows.Forms.Label objectInfo_label;
        private ViewCheckedListBoxControl view_checkedListBox;
        private SelectCheckedListBoxControl select_checkedListBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nearestPlane_button;
        private System.Windows.Forms.CheckBox selectNone_checkBox;
        private System.Windows.Forms.CheckBox selectAllView_checkBox;
        private System.Windows.Forms.CheckBox selectNoneSelect_checkBox;
        private System.Windows.Forms.CheckBox selectAllSelect_checkBox;
    }
}
