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
            this.selectNone_checkBox = new System.Windows.Forms.CheckBox();
            this.selectAllView_checkBox = new System.Windows.Forms.CheckBox();
            this.selectNoneSelect_checkBox = new System.Windows.Forms.CheckBox();
            this.selectAllSelect_checkBox = new System.Windows.Forms.CheckBox();
            this.objectInfo_label = new System.Windows.Forms.Label();
            this.top_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuControl2 = new FilteringTool.UI.MainMenuControl();
            this.button_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkboxesControl1 = new FilteringTool.UI.CheckboxesControl();
            this.center_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.view_checkedListBox = new FilteringTool.UI.ViewCheckedListBoxControl();
            this.select_checkedListBox = new FilteringTool.UI.SelectCheckedListBoxControl();
            this.newVersion_linkLabel = new System.Windows.Forms.LinkLabel();
            this.top_tableLayoutPanel.SuspendLayout();
            this.button_tableLayoutPanel.SuspendLayout();
            this.center_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // select_button
            // 
            this.select_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.select_button.AutoSize = true;
            this.select_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.select_button.BackColor = System.Drawing.SystemColors.Window;
            this.select_button.Font = new System.Drawing.Font("Arial", 8F);
            this.select_button.Location = new System.Drawing.Point(0, 476);
            this.select_button.Margin = new System.Windows.Forms.Padding(0);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(104, 24);
            this.select_button.TabIndex = 42;
            this.select_button.Text = "Set selection";
            this.toolTip1.SetToolTip(this.select_button, "Sets selection filter");
            this.select_button.UseVisualStyleBackColor = false;
            this.select_button.Click += new System.EventHandler(this.Select_buttonClick);
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_button.AutoSize = true;
            this.refresh_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refresh_button.BackColor = System.Drawing.SystemColors.Window;
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refresh_button.Font = new System.Drawing.Font("Arial", 8F);
            this.refresh_button.Location = new System.Drawing.Point(0, 356);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(0);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(104, 24);
            this.refresh_button.TabIndex = 46;
            this.refresh_button.Text = "Refresh";
            this.toolTip1.SetToolTip(this.refresh_button, "Refreshes lists on the right");
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.Refresh_buttonClick);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.AutoSize = true;
            this.add_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_button.BackColor = System.Drawing.SystemColors.Window;
            this.add_button.Font = new System.Drawing.Font("Arial", 8F);
            this.add_button.Location = new System.Drawing.Point(0, 452);
            this.add_button.Margin = new System.Windows.Forms.Padding(0);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(104, 24);
            this.add_button.TabIndex = 45;
            this.add_button.Text = "Add phase";
            this.toolTip1.SetToolTip(this.add_button, "Adds new phase to the model");
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.Add_buttonClick);
            // 
            // setPhase_button
            // 
            this.setPhase_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setPhase_button.AutoSize = true;
            this.setPhase_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setPhase_button.BackColor = System.Drawing.SystemColors.Window;
            this.setPhase_button.Font = new System.Drawing.Font("Arial", 8F);
            this.setPhase_button.Location = new System.Drawing.Point(0, 380);
            this.setPhase_button.Margin = new System.Windows.Forms.Padding(0);
            this.setPhase_button.Name = "setPhase_button";
            this.setPhase_button.Size = new System.Drawing.Size(104, 24);
            this.setPhase_button.TabIndex = 44;
            this.setPhase_button.Text = "Set current";
            this.toolTip1.SetToolTip(this.setPhase_button, "Sets selected phase as new current phase");
            this.setPhase_button.UseVisualStyleBackColor = false;
            this.setPhase_button.Click += new System.EventHandler(this.SetPhase_buttonClick);
            // 
            // changePhase_button
            // 
            this.changePhase_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changePhase_button.AutoSize = true;
            this.changePhase_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changePhase_button.BackColor = System.Drawing.SystemColors.Window;
            this.changePhase_button.Font = new System.Drawing.Font("Arial", 8F);
            this.changePhase_button.Location = new System.Drawing.Point(0, 404);
            this.changePhase_button.Margin = new System.Windows.Forms.Padding(0);
            this.changePhase_button.Name = "changePhase_button";
            this.changePhase_button.Size = new System.Drawing.Size(104, 24);
            this.changePhase_button.TabIndex = 43;
            this.changePhase_button.Text = "Move to phase";
            this.toolTip1.SetToolTip(this.changePhase_button, "Modify phase of selected objects");
            this.changePhase_button.UseVisualStyleBackColor = false;
            this.changePhase_button.Click += new System.EventHandler(this.MoveToPhase_buttonClick);
            // 
            // redraw_button
            // 
            this.redraw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.redraw_button.AutoSize = true;
            this.redraw_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.redraw_button.BackColor = System.Drawing.SystemColors.Window;
            this.redraw_button.Font = new System.Drawing.Font("Arial", 8F);
            this.redraw_button.Location = new System.Drawing.Point(0, 500);
            this.redraw_button.Margin = new System.Windows.Forms.Padding(0);
            this.redraw_button.Name = "redraw_button";
            this.redraw_button.Size = new System.Drawing.Size(104, 24);
            this.redraw_button.TabIndex = 41;
            this.redraw_button.Text = "Set view filter";
            this.toolTip1.SetToolTip(this.redraw_button, "Sets view filter");
            this.redraw_button.UseVisualStyleBackColor = false;
            this.redraw_button.Click += new System.EventHandler(this.Redraw_buttonClick);
            // 
            // viewAttributeLoad_button
            // 
            this.viewAttributeLoad_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewAttributeLoad_button.AutoSize = true;
            this.viewAttributeLoad_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewAttributeLoad_button.BackColor = System.Drawing.SystemColors.Window;
            this.viewAttributeLoad_button.Location = new System.Drawing.Point(320, 1);
            this.viewAttributeLoad_button.Margin = new System.Windows.Forms.Padding(0);
            this.viewAttributeLoad_button.Name = "viewAttributeLoad_button";
            this.viewAttributeLoad_button.Size = new System.Drawing.Size(23, 24);
            this.viewAttributeLoad_button.TabIndex = 67;
            this.viewAttributeLoad_button.Text = "L";
            this.toolTip1.SetToolTip(this.viewAttributeLoad_button, "Load checked phases to list from attribute file");
            this.viewAttributeLoad_button.UseVisualStyleBackColor = false;
            this.viewAttributeLoad_button.Click += new System.EventHandler(this.ViewAttributeLoad_buttonClick);
            // 
            // viewAttributeSave_button
            // 
            this.viewAttributeSave_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewAttributeSave_button.AutoSize = true;
            this.viewAttributeSave_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewAttributeSave_button.BackColor = System.Drawing.SystemColors.Window;
            this.viewAttributeSave_button.Location = new System.Drawing.Point(343, 1);
            this.viewAttributeSave_button.Margin = new System.Windows.Forms.Padding(0);
            this.viewAttributeSave_button.Name = "viewAttributeSave_button";
            this.viewAttributeSave_button.Size = new System.Drawing.Size(24, 24);
            this.viewAttributeSave_button.TabIndex = 68;
            this.viewAttributeSave_button.Text = "S";
            this.toolTip1.SetToolTip(this.viewAttributeSave_button, "Save checkeded phases from list to attribute file");
            this.viewAttributeSave_button.UseVisualStyleBackColor = false;
            this.viewAttributeSave_button.Click += new System.EventHandler(this.ViewAttributeSave_buttonClick);
            // 
            // viewAttribute_comboBox
            // 
            this.viewAttribute_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAttribute_comboBox.Font = new System.Drawing.Font("Arial", 8F);
            this.viewAttribute_comboBox.FormattingEnabled = true;
            this.viewAttribute_comboBox.Location = new System.Drawing.Point(61, 2);
            this.viewAttribute_comboBox.Margin = new System.Windows.Forms.Padding(1);
            this.viewAttribute_comboBox.Name = "viewAttribute_comboBox";
            this.viewAttribute_comboBox.Size = new System.Drawing.Size(258, 22);
            this.viewAttribute_comboBox.TabIndex = 66;
            this.toolTip1.SetToolTip(this.viewAttribute_comboBox, "Save or load list of checked items from list bellow");
            // 
            // viewAttributeDelete_button
            // 
            this.viewAttributeDelete_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewAttributeDelete_button.AutoSize = true;
            this.viewAttributeDelete_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewAttributeDelete_button.BackColor = System.Drawing.SystemColors.Window;
            this.viewAttributeDelete_button.Location = new System.Drawing.Point(367, 1);
            this.viewAttributeDelete_button.Margin = new System.Windows.Forms.Padding(0);
            this.viewAttributeDelete_button.Name = "viewAttributeDelete_button";
            this.viewAttributeDelete_button.Size = new System.Drawing.Size(24, 24);
            this.viewAttributeDelete_button.TabIndex = 76;
            this.viewAttributeDelete_button.Text = "D";
            this.toolTip1.SetToolTip(this.viewAttributeDelete_button, "Deletes attribute file from the list");
            this.viewAttributeDelete_button.UseVisualStyleBackColor = false;
            this.viewAttributeDelete_button.Click += new System.EventHandler(this.ViewAttributeDelete_buttonClick);
            // 
            // hideShow_button
            // 
            this.hideShow_button.AutoSize = true;
            this.hideShow_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hideShow_button.BackColor = System.Drawing.SystemColors.Window;
            this.hideShow_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideShow_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hideShow_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hideShow_button.Location = new System.Drawing.Point(391, 0);
            this.hideShow_button.Margin = new System.Windows.Forms.Padding(0);
            this.hideShow_button.Name = "hideShow_button";
            this.hideShow_button.Size = new System.Drawing.Size(23, 550);
            this.hideShow_button.TabIndex = 78;
            this.hideShow_button.Text = "<\r\n";
            this.toolTip1.SetToolTip(this.hideShow_button, "Hide or show Filrering Tool");
            this.hideShow_button.UseVisualStyleBackColor = false;
            this.hideShow_button.Click += new System.EventHandler(this.HideShow_buttonClick);
            this.hideShow_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HideShow_button_MouseMove);
            // 
            // nearestPlane_button
            // 
            this.nearestPlane_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nearestPlane_button.AutoSize = true;
            this.nearestPlane_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nearestPlane_button.BackColor = System.Drawing.SystemColors.Window;
            this.nearestPlane_button.Font = new System.Drawing.Font("Arial", 8F);
            this.nearestPlane_button.Location = new System.Drawing.Point(0, 428);
            this.nearestPlane_button.Margin = new System.Windows.Forms.Padding(0);
            this.nearestPlane_button.Name = "nearestPlane_button";
            this.nearestPlane_button.Size = new System.Drawing.Size(104, 24);
            this.nearestPlane_button.TabIndex = 47;
            this.nearestPlane_button.Text = "Nearest plane";
            this.toolTip1.SetToolTip(this.nearestPlane_button, "Rotate selected views to nearest plane");
            this.nearestPlane_button.UseVisualStyleBackColor = false;
            this.nearestPlane_button.Click += new System.EventHandler(this.NearestPlane_button_Click);
            // 
            // selectNone_checkBox
            // 
            this.selectNone_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectNone_checkBox.AutoSize = true;
            this.selectNone_checkBox.Location = new System.Drawing.Point(81, 461);
            this.selectNone_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.selectNone_checkBox.Name = "selectNone_checkBox";
            this.selectNone_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectNone_checkBox.TabIndex = 45;
            this.selectNone_checkBox.UseVisualStyleBackColor = true;
            this.selectNone_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectNone_checkBox_MouseUp);
            // 
            // selectAllView_checkBox
            // 
            this.selectAllView_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectAllView_checkBox.AutoSize = true;
            this.selectAllView_checkBox.Checked = true;
            this.selectAllView_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectAllView_checkBox.Location = new System.Drawing.Point(64, 461);
            this.selectAllView_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.selectAllView_checkBox.Name = "selectAllView_checkBox";
            this.selectAllView_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectAllView_checkBox.TabIndex = 44;
            this.selectAllView_checkBox.UseVisualStyleBackColor = true;
            this.selectAllView_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectAllView_checkBox_MouseUp);
            // 
            // selectNoneSelect_checkBox
            // 
            this.selectNoneSelect_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectNoneSelect_checkBox.AutoSize = true;
            this.selectNoneSelect_checkBox.Location = new System.Drawing.Point(22, 461);
            this.selectNoneSelect_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.selectNoneSelect_checkBox.Name = "selectNoneSelect_checkBox";
            this.selectNoneSelect_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectNoneSelect_checkBox.TabIndex = 43;
            this.selectNoneSelect_checkBox.UseVisualStyleBackColor = true;
            this.selectNoneSelect_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectNoneSelect_checkBox_MouseUp);
            // 
            // selectAllSelect_checkBox
            // 
            this.selectAllSelect_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectAllSelect_checkBox.AutoSize = true;
            this.selectAllSelect_checkBox.Checked = true;
            this.selectAllSelect_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectAllSelect_checkBox.Location = new System.Drawing.Point(5, 461);
            this.selectAllSelect_checkBox.Margin = new System.Windows.Forms.Padding(1);
            this.selectAllSelect_checkBox.Name = "selectAllSelect_checkBox";
            this.selectAllSelect_checkBox.Size = new System.Drawing.Size(15, 14);
            this.selectAllSelect_checkBox.TabIndex = 42;
            this.selectAllSelect_checkBox.UseVisualStyleBackColor = true;
            this.selectAllSelect_checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectAllSelect_checkBox_MouseUp);
            // 
            // objectInfo_label
            // 
            this.objectInfo_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.objectInfo_label.AutoSize = true;
            this.center_tableLayoutPanel.SetColumnSpan(this.objectInfo_label, 8);
            this.objectInfo_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.objectInfo_label.Location = new System.Drawing.Point(3, 479);
            this.objectInfo_label.Margin = new System.Windows.Forms.Padding(3);
            this.objectInfo_label.MaximumSize = new System.Drawing.Size(0, 50);
            this.objectInfo_label.Name = "objectInfo_label";
            this.objectInfo_label.Size = new System.Drawing.Size(281, 28);
            this.objectInfo_label.TabIndex = 41;
            this.objectInfo_label.Text = "You can use SHIFT to multi select or CTRL to open context menu. RIGHT mouse click" +
    " to redraw";
            // 
            // top_tableLayoutPanel
            // 
            this.top_tableLayoutPanel.AutoSize = true;
            this.top_tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.top_tableLayoutPanel.ColumnCount = 5;
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.top_tableLayoutPanel.Controls.Add(this.viewAttribute_comboBox, 1, 0);
            this.top_tableLayoutPanel.Controls.Add(this.mainMenuControl2, 0, 0);
            this.top_tableLayoutPanel.Controls.Add(this.viewAttributeLoad_button, 2, 0);
            this.top_tableLayoutPanel.Controls.Add(this.viewAttributeDelete_button, 4, 0);
            this.top_tableLayoutPanel.Controls.Add(this.viewAttributeSave_button, 3, 0);
            this.top_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.top_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.top_tableLayoutPanel.Name = "top_tableLayoutPanel";
            this.top_tableLayoutPanel.RowCount = 1;
            this.top_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.top_tableLayoutPanel.Size = new System.Drawing.Size(391, 26);
            this.top_tableLayoutPanel.TabIndex = 85;
            // 
            // mainMenuControl2
            // 
            this.mainMenuControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainMenuControl2.AutoSize = true;
            this.mainMenuControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenuControl2.Location = new System.Drawing.Point(1, 1);
            this.mainMenuControl2.Margin = new System.Windows.Forms.Padding(1);
            this.mainMenuControl2.Name = "mainMenuControl2";
            this.mainMenuControl2.Size = new System.Drawing.Size(58, 24);
            this.mainMenuControl2.TabIndex = 84;
            // 
            // button_tableLayoutPanel
            // 
            this.button_tableLayoutPanel.AutoSize = true;
            this.button_tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_tableLayoutPanel.ColumnCount = 1;
            this.button_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tableLayoutPanel.Controls.Add(this.checkboxesControl1, 0, 0);
            this.button_tableLayoutPanel.Controls.Add(this.redraw_button, 0, 7);
            this.button_tableLayoutPanel.Controls.Add(this.nearestPlane_button, 0, 4);
            this.button_tableLayoutPanel.Controls.Add(this.select_button, 0, 6);
            this.button_tableLayoutPanel.Controls.Add(this.refresh_button, 0, 1);
            this.button_tableLayoutPanel.Controls.Add(this.add_button, 0, 5);
            this.button_tableLayoutPanel.Controls.Add(this.changePhase_button, 0, 3);
            this.button_tableLayoutPanel.Controls.Add(this.setPhase_button, 0, 2);
            this.button_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_tableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.button_tableLayoutPanel.Name = "button_tableLayoutPanel";
            this.button_tableLayoutPanel.RowCount = 8;
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.button_tableLayoutPanel.Size = new System.Drawing.Size(104, 524);
            this.button_tableLayoutPanel.TabIndex = 86;
            // 
            // checkboxesControl1
            // 
            this.checkboxesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkboxesControl1.AutoSize = true;
            this.checkboxesControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxesControl1.BackColor = System.Drawing.SystemColors.Window;
            this.checkboxesControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxesControl1.Location = new System.Drawing.Point(0, 0);
            this.checkboxesControl1.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxesControl1.ModifierKey = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.checkboxesControl1.Name = "checkboxesControl1";
            this.checkboxesControl1.Size = new System.Drawing.Size(104, 356);
            this.checkboxesControl1.TabIndex = 0;
            this.checkboxesControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckboxesControl1_MouseUp);
            // 
            // center_tableLayoutPanel
            // 
            this.center_tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.center_tableLayoutPanel.ColumnCount = 8;
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.center_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.center_tableLayoutPanel.Controls.Add(this.view_checkedListBox, 4, 0);
            this.center_tableLayoutPanel.Controls.Add(this.selectNone_checkBox, 6, 1);
            this.center_tableLayoutPanel.Controls.Add(this.select_checkedListBox, 0, 0);
            this.center_tableLayoutPanel.Controls.Add(this.objectInfo_label, 0, 2);
            this.center_tableLayoutPanel.Controls.Add(this.selectAllView_checkBox, 5, 1);
            this.center_tableLayoutPanel.Controls.Add(this.selectAllSelect_checkBox, 1, 1);
            this.center_tableLayoutPanel.Controls.Add(this.selectNoneSelect_checkBox, 2, 1);
            this.center_tableLayoutPanel.Controls.Add(this.newVersion_linkLabel, 1, 3);
            this.center_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_tableLayoutPanel.Location = new System.Drawing.Point(104, 26);
            this.center_tableLayoutPanel.Name = "center_tableLayoutPanel";
            this.center_tableLayoutPanel.RowCount = 4;
            this.center_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.center_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.center_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.center_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.center_tableLayoutPanel.Size = new System.Drawing.Size(287, 524);
            this.center_tableLayoutPanel.TabIndex = 87;
            // 
            // view_checkedListBox
            // 
            this.view_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.center_tableLayoutPanel.SetColumnSpan(this.view_checkedListBox, 4);
            this.view_checkedListBox.Location = new System.Drawing.Point(44, 1);
            this.view_checkedListBox.Margin = new System.Windows.Forms.Padding(1);
            this.view_checkedListBox.Name = "view_checkedListBox";
            this.view_checkedListBox.Size = new System.Drawing.Size(242, 458);
            this.view_checkedListBox.TabIndex = 1;
            this.view_checkedListBox.TopIndex = 0;
            this.view_checkedListBox.RedrawViewClicked += new System.Action(this.View_checkedListBox_RedrawViewClicked);
            this.view_checkedListBox.ViewMouseMove += new System.Action(this.ViewMouseMove);
            // 
            // select_checkedListBox
            // 
            this.select_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.select_checkedListBox.AutoSize = true;
            this.select_checkedListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.center_tableLayoutPanel.SetColumnSpan(this.select_checkedListBox, 4);
            this.select_checkedListBox.Location = new System.Drawing.Point(1, 1);
            this.select_checkedListBox.Margin = new System.Windows.Forms.Padding(1);
            this.select_checkedListBox.Name = "select_checkedListBox";
            this.select_checkedListBox.Size = new System.Drawing.Size(41, 458);
            this.select_checkedListBox.TabIndex = 55;
            this.select_checkedListBox.TopIndex = 0;
            // 
            // newVersion_linkLabel
            // 
            this.newVersion_linkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newVersion_linkLabel.AutoSize = true;
            this.center_tableLayoutPanel.SetColumnSpan(this.newVersion_linkLabel, 7);
            this.newVersion_linkLabel.Location = new System.Drawing.Point(4, 510);
            this.newVersion_linkLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newVersion_linkLabel.Name = "newVersion_linkLabel";
            this.newVersion_linkLabel.Size = new System.Drawing.Size(217, 14);
            this.newVersion_linkLabel.TabIndex = 56;
            this.newVersion_linkLabel.TabStop = true;
            this.newVersion_linkLabel.Text = "New version of this program 0.0 is avaiable";
            this.newVersion_linkLabel.Visible = false;
            this.newVersion_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewVersion_linkLabel_LinkClicked);
            // 
            // FilteringToolMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(414, 550);
            this.Controls.Add(this.center_tableLayoutPanel);
            this.Controls.Add(this.button_tableLayoutPanel);
            this.Controls.Add(this.top_tableLayoutPanel);
            this.Controls.Add(this.hideShow_button);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "FilteringToolMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtering Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.top_tableLayoutPanel.ResumeLayout(false);
            this.top_tableLayoutPanel.PerformLayout();
            this.button_tableLayoutPanel.ResumeLayout(false);
            this.button_tableLayoutPanel.PerformLayout();
            this.center_tableLayoutPanel.ResumeLayout(false);
            this.center_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private MainMenuControl mainMenuControl2;
        private CheckboxesControl checkboxesControl1;
        private System.Windows.Forms.Label objectInfo_label;
        private ViewCheckedListBoxControl view_checkedListBox;
        private SelectCheckedListBoxControl select_checkedListBox;
        private System.Windows.Forms.Button nearestPlane_button;
        private System.Windows.Forms.CheckBox selectNone_checkBox;
        private System.Windows.Forms.CheckBox selectAllView_checkBox;
        private System.Windows.Forms.CheckBox selectNoneSelect_checkBox;
        private System.Windows.Forms.CheckBox selectAllSelect_checkBox;
        private System.Windows.Forms.TableLayoutPanel top_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel button_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel center_tableLayoutPanel;
        private System.Windows.Forms.LinkLabel newVersion_linkLabel;
    }
}
