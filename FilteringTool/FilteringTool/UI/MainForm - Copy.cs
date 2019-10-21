/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using ITeklaIOInterface;
using FilteringTool;

namespace AdministratorFaz
{
	public partial class MainForm : Form
	{
        private FilteringTool.FilteringTool filteringTool;

		public string _filterType = "co_assembly";
		private bool _checkBoxesChanged;
		
		public MainForm()
		{
			InitializeComponent();
            filteringTool = new FilteringTool.FilteringTool();	
            


			this.select_checkedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Select_checkedListBoxMouseUp);
			this.view_checkedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.View_checkedListBoxMouseUp);
			
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			
			if (teklaIO != null) teklaIO.RefreshPhases(this.view_checkedListBox, this.select_checkedListBox);
			
			
			if (teklaIO != null) 
			{
				teklaIO.RefreshAttributeList(selectAttribute_comboBox, viewAttribute_comboBox);
				viewAttribute_comboBox.Text = "lastfilter";
				ViewAttributeLoad_buttonClick(new object(),new EventArgs());
			}
			
			_checkBoxesChanged = true;
			
			if (teklaIO != null) teklaIO.CreateSetStandartSelectFilterMacro();
			if (teklaIO != null) teklaIO.CreateSetWorkSelectFilterMacro();
			if (teklaIO != null) teklaIO.CreateSetDrawingSelectorMacro();
			if (teklaIO != null) teklaIO.CreateSetDrawingSelectorStandardMacro();
			
			if (teklaIO != null) teklaIO.CreateDisplayChangeMacro
				(
				bolt_checkBox,
				component_checkBox,
				cut_checkBox,
				fitting_checkBox,
				grid_checkBox,
				holes_checkBox,
				points_checkBox,
				lines_checkBox,
				weld_checkBox,
				loads_checkBox,
				references_checkBox,
				rebars_checkBox,
				selectAttribute_comboBox
			);
			
			this.ClientSize = new System.Drawing.Size(this.ClientSize.Width,Math.Min(620,Math.Max(this.ClientSize.Height, 0 + this.view_checkedListBox.PreferredHeight /*+ this.view_checkedListBox.Location.Y*/)));
			AddTeklaVersion();	
						
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			

		}

		void Button2Click(object sender, EventArgs e)
		{
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.SelectStandard();
		}
		
		void SelectCheck_checkBoxMouseDown(object sender, MouseEventArgs e)
		{
			this.grid_checkBox.Checked = true;
			this.lines_checkBox.Checked = true;
			this.points_checkBox.Checked = true;
			this.bolt_checkBox.Checked = true;
			this.component_checkBox.Checked = true;
			this.cut_checkBox.Checked = true;
			this.fitting_checkBox.Checked = true;
			this.weld_checkBox.Checked = true;
			this.holes_checkBox.Checked = true;
			this.rebars_checkBox.Checked = true;
			this.loads_checkBox.Checked = true;
			this.references_checkBox.Checked = true;
		}
		void UnSelectCheck_checkBoxMouseDown(object sender, MouseEventArgs e)
		{
			this.grid_checkBox.Checked = false;
			this.lines_checkBox.Checked = false;
			this.points_checkBox.Checked = false;
			this.bolt_checkBox.Checked = false;
			this.component_checkBox.Checked = false;
			this.cut_checkBox.Checked = false;
			this.fitting_checkBox.Checked = false;
			this.weld_checkBox.Checked = false;
			this.holes_checkBox.Checked = false;
			this.rebars_checkBox.Checked = false;
			this.loads_checkBox.Checked = false;
			this.references_checkBox.Checked = false;
		}
		void SelectSelect_checkBoxMouseDown(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.select_checkedListBox.Items.Count; i++) 
			{
				this.select_checkedListBox.SetItemChecked(i, true);
			}
		}
		
		void UnSelectSelect_checkBoxMouseDown(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.select_checkedListBox.Items.Count; i++) 
			{
				this.select_checkedListBox.SetItemChecked(i, false);
			}
		}
		void SelectView_checkBoxMouseDown(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.select_checkedListBox.Items.Count; i++) 
			{
				this.view_checkedListBox.SetItemChecked(i, true);
			}
		}
		void UnSelectView_checkBoxMouseDown(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.select_checkedListBox.Items.Count; i++) 
			{
				this.view_checkedListBox.SetItemChecked(i, false);
			}
		}
		
		void Add_buttonClick(object sender, EventArgs e)
		{
			AddPhaseForm AddPhaseForm = new AddPhaseForm();
			AddPhaseForm.Location = new Point( this.Location.X + this.add_button.Location.X, this.Location.Y + this.add_button.Location.Y - AddPhaseForm.Size.Height);
			AddPhaseForm.ShowDialog();
			
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.RefreshPhases(this.view_checkedListBox, this.select_checkedListBox);
						
		}
		
		void ChangePhase_buttonClick(object sender, EventArgs e)
		{	
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			teklaIO.ChangePhase(this.view_checkedListBox);
		}
		void SetPhase_buttonClick(object sender, EventArgs e)
		{	
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.SetCurrentPhase(this.view_checkedListBox);
			if (teklaIO != null) teklaIO.RefreshPhases(this.view_checkedListBox, this.select_checkedListBox);
		}
		
		void Refresh_buttonClick(object sender, EventArgs e)
		{	
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO == null) MessageBox.Show("tekla is null");
			
			if (teklaIO != null) teklaIO.RefreshPhases(this.view_checkedListBox, this.select_checkedListBox);
			if (teklaIO != null) teklaIO.RefreshAttributeList(selectAttribute_comboBox, viewAttribute_comboBox);
			
			viewAttribute_comboBox.Text = "lastfilter";
			ViewAttributeLoad_buttonClick(new object(),new EventArgs());

        }

		void CheckBoxesChanged(object sender, EventArgs e)
		{
			this._checkBoxesChanged = true;
		}
		
		void Select_buttonClick(object sender, EventArgs e)
		{
            if (filteringTool.IsDrawingOpened()) return;

            if (this.select_checkedListBox.CheckedItems.Count != 0) 
			{
				ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
				
				//if (!filteringTool.IsDrawingOpened())
				//{
					if (teklaIO != null) teklaIO.SelectCheckedPhases(select_checkedListBox, this._filterType);
				//}
				//else
				//{
				//	if (teklaIO != null) teklaIO.CreateFilterFile("_currentFilter.dsf", select_checkedListBox.CheckedItems.GetEnumerator(),this._filterType);
				//	if (teklaIO != null) teklaIO.CreateSetDrawingSelectorMacro();
				//	if (teklaIO != null) teklaIO.RunMacro("SetDrawingSelector.cs", true);
				//}
			}
			else
			{
				ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
				//if (!filteringTool.IsDrawingOpened())
				//{
					if (teklaIO != null) teklaIO.SelectStandard();
				//}
				//else
				//{
				//	if (teklaIO != null) teklaIO.CreateSetDrawingSelectorStandardMacro();
				//	if (teklaIO != null) teklaIO.RunMacro("SetDrawingSelectorStandard.cs", true);
				//}
			}
			
		}
				
		void Redraw_buttonClick(object sender, EventArgs e)
		{
            if (filteringTool.IsDrawingOpened()) return;

            ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			//if (!filteringTool.IsDrawingOpened()) 
			//{
				//Show checked phases
				
				bool isAnySelected = false;
				if (teklaIO != null) teklaIO.ShowCheckedPhases(view_checkedListBox, onlySelectedViews_checkBox,this._filterType, ref isAnySelected);
				
				//Turn on macro to change display properties
				if (this._checkBoxesChanged && isAnySelected) 
				{
						if (teklaIO != null) teklaIO.CreateDisplayChangeMacro
							(
							bolt_checkBox,
							component_checkBox,
							cut_checkBox,
							fitting_checkBox,
							grid_checkBox,
							holes_checkBox,
							points_checkBox,
							lines_checkBox,
							weld_checkBox,
							loads_checkBox,
							references_checkBox,
							rebars_checkBox,
							selectAttribute_comboBox
						);
						
						if (teklaIO != null) teklaIO.RunMacro("DisplayChangeMacro.cs");
						this._checkBoxesChanged = false;
				}
			//}                                        
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			//try
			//{
			//	CopyUpdater();
			//	System.Diagnostics.Process.Start("Updater.exe");	
			//}
			//catch (Exception) {}
		}

		
		void View_checkedListBoxMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right) 
			{
				Redraw_buttonClick(view_checkedListBox, new EventArgs());
				//Select_buttonClick(view_checkedListBox, new EventArgs());
			}
		}
		void Select_checkedListBoxMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right) 
			{
				Select_buttonClick(view_checkedListBox, new EventArgs());
				//Redraw_buttonClick(view_checkedListBox, new EventArgs());
			}
		}
		
		void ViewAttributeLoad_buttonClick(object sender, EventArgs e)
		{
			
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.ViewAttributeLoad_buttonClick(viewAttribute_comboBox, view_checkedListBox);
		}
		
		
		void ViewAttributeSave_buttonClick(object sender, EventArgs e)
		{			
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.ViewAttributeSave_buttonClick(viewAttribute_comboBox, view_checkedListBox);
			if (teklaIO != null) teklaIO.RefreshAttributeList(selectAttribute_comboBox, viewAttribute_comboBox);
			
		}
		
		void ViewAttributeDelete_buttonClick(object sender, EventArgs e)
		{			
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.ViewAttributeDelete_buttonClick(viewAttribute_comboBox, view_checkedListBox);
			if (teklaIO != null) teklaIO.RefreshAttributeList(selectAttribute_comboBox, viewAttribute_comboBox);
			
		}
		
		void oae_RadioButtonChange(object sender, EventArgs e)
		{
			if (element_radioButton.Checked) this._filterType = "co_part";
			else if (assembly_radioButton.Checked) this._filterType = "co_assembly";
			else if (bolt_radioButton.Checked) this._filterType = "co_bolt";
			else this._filterType = "co_object";
		}
	
		
		void OnTop_checkBoxCheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = this.onTop_checkBox.Checked;
		}


		//HACK: zaznaczanie wielu elementów na listach
		
		
		bool ChLB1_multicheck = false;
		int ChLB1_lastitem = -1;
		int ChLB1_lastitem2 = -1;
		
		CheckState ChLB1_checkstate; 
					
		void CheckedListBox1MouseUp(object sender, MouseEventArgs e)
		{	
			if (ChLB1_multicheck) 
			{		
				int a = Math.Min(ChLB1_lastitem, ChLB1_lastitem2);
				int b = Math.Max(ChLB1_lastitem, ChLB1_lastitem2);
				for (int i = a; i <= b; i++)
				{					
					view_checkedListBox.SetItemCheckState(i, ChLB1_checkstate);
				}
				ChLB1_multicheck = false;
			}
		}
		
		void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			ChLB1_lastitem2 = ChLB1_lastitem;
			
			if (Control.ModifierKeys == Keys.Shift && ChLB1_lastitem >= 0) 
			{
				ChLB1_multicheck = true;
				ChLB1_checkstate = view_checkedListBox.GetItemCheckState(ChLB1_lastitem2);
			}
			ChLB1_lastitem = view_checkedListBox.SelectedIndex;
		}
		
		
		bool ChLB2_multicheck = false;
		int ChLB2_lastitem = -1;
		int ChLB2_lastitem2 = -1;
		
		CheckState ChLB2_checkstate; 
					
		void CheckedListBox2MouseUp(object sender, MouseEventArgs e)
		{	
			if (ChLB2_multicheck) 
			{		
				int a = Math.Min(ChLB2_lastitem, ChLB2_lastitem2);
				int b = Math.Max(ChLB2_lastitem, ChLB2_lastitem2);
				for (int i = a; i <= b; i++)
				{					
					select_checkedListBox.SetItemCheckState(i, ChLB2_checkstate);
				}
				ChLB2_multicheck = false;
			}
		}
		
		void CheckedListBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			ChLB2_lastitem2 = ChLB2_lastitem;
			
			if (Control.ModifierKeys == Keys.Shift && ChLB2_lastitem >= 0) 
			{
				ChLB2_multicheck = true;
				ChLB2_checkstate = select_checkedListBox.GetItemCheckState(ChLB2_lastitem2);
			}
			ChLB2_lastitem = select_checkedListBox.SelectedIndex;
		}
		
		
		void RotateToNearestPlane_buttonClick(object sender, EventArgs e)
		{
			ITeklaIO teklaIO = new TeklaIOHandler().TeklaIO;
			if (teklaIO != null) teklaIO.RotateViewToNearestPlane();
		}
		
		
		bool isFormHidded = false;
		Size currentWindowSize = new Size(500,500);
		Size currentWindowMinimumSize = new Size(500,500);
		
		void HideShow_buttonClick(object sender, EventArgs e)
		{
			if (isFormHidded) 
			{
				// show form
				foreach (Control currentControl in this.Controls) 
				{
					if (currentControl != hideShow_button) 
					{
						currentControl.Visible = true;
					}
				}
				
				this.FormBorderStyle = FormBorderStyle.Sizable;
				this.Size = currentWindowSize;
				this.MinimumSize = currentWindowMinimumSize;
				
				hideShow_button.Text = "<";
				isFormHidded = false;
			}
			else
			{
				//hide form
				foreach (Control currentControl in this.Controls) 
				{
					if (currentControl != hideShow_button) 
					{
						currentControl.Visible = false;
					}
				}
				currentWindowSize = this.Size;
				currentWindowMinimumSize = this.MinimumSize;
				
				this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
				this.MinimumSize = new Size(30, this.MinimumSize.Height);
				this.Size = new Size(30,this.Size.Height);
				
				
				hideShow_button.Text = ">";
				isFormHidded = true;
			}
		}
	
		
	
		
	
	}
}
