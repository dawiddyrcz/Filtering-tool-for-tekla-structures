/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("", "IDE0017")]

    public partial class FilteringToolMainForm : Form
    {
        private const string LAST_FILTER_NAME = "lastfilter";

        private FilteringToolClass filteringTool = new FilteringToolClass();
        private CheckedPhasesAttributes checkedPhasesAttributes = new CheckedPhasesAttributes();

        public FilteringToolMainForm()
        {
            InitializeComponent();
            this.Name = "FilteringToolMainForm";
            this.TopLevel = true;

            this.select_checkedListBox.MouseUp += new MouseEventHandler(this.Select_checkedListBoxMouseUp);

            this.ClientSize = new Size(this.ClientSize.Width, Math.Min(620, Math.Max(this.ClientSize.Height, 0 + this.view_checkedListBox.PreferredHeight)));

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text = this.Text + " " + fileVersionInfo.FileMajorPart + "." + fileVersionInfo.FileMinorPart;

            view_checkedListBox.SetCurrentPhaseClicked += new Action(SetCurrentPhase);
            view_checkedListBox.MoveToPhaseClicked += new Action(MoveToPhase);

            view_checkedListBox.AddNewPhaseClicked += new Action(AddPhase);
            view_checkedListBox.ViewMouseMove += new Action(ViewMouseMove);
            view_checkedListBox.RefreshClicked += new Action(RefreshPhases);

            view_checkedListBox.RenamePhaseClicked += RenamePhase;

            select_checkedListBox.SelectViewClicked += new Action(SetSelect);
            select_checkedListBox.RefreshClicked += new Action(RefreshPhases);

            checkboxesControl1.MouseRightClicked += new Action(Redraw);

            view_checkedListBox.AutoScrollMinSize = new Size(0, 0);
            view_checkedListBox.AutoScroll = false;
            select_checkedListBox.AutoScrollMinSize = new Size(0, 0);
            select_checkedListBox.AutoScroll = false;

            checkboxesControl1.ToolTipPopup += new Action(TryToRepairHidingTeklaWindowsAfterSecond);

            RefreshAttributesList();
            RefreshPhases();
            viewAttribute_comboBox.Text = LAST_FILTER_NAME;
            ViewAttributeLoad_buttonClick(new object(), new EventArgs());
        }

        private void Add_buttonClick(object sender, EventArgs e) => AddPhase();

        private void MoveToPhase_buttonClick(object sender, EventArgs e) => MoveToPhase();

        private void SetPhase_buttonClick(object sender, EventArgs e) => SetCurrentPhase();

        private void Refresh_buttonClick(object sender, EventArgs e)
        {
            RefreshPhases();
            RefreshAttributesList();
            viewAttribute_comboBox.Text = LAST_FILTER_NAME;
            ViewAttributeLoad_buttonClick(new object(), new EventArgs());
            RepairHidingTeklaWindows();
        }

        private void Select_buttonClick(object sender, EventArgs e)
        {
            SetSelect();
            RepairHidingTeklaWindows();
        }

        private void Redraw_buttonClick(object sender, EventArgs e)
        {
            Redraw();
            RepairHidingTeklaWindows();
        }

        private void View_checkedListBox_RedrawViewClicked()
        {
            Redraw();
            RepairHidingTeklaWindows();
        }

        private void Select_checkedListBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SetSelect();
            }
            RepairHidingTeklaWindows();
        }

        private void CheckboxesControl1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Redraw();
            }
            RepairHidingTeklaWindows();
        }

        private void ViewAttributeLoad_buttonClick(object sender, EventArgs e)
        {
            try
            {
                var atrFile = this.viewAttribute_comboBox.Text;
                if (checkedPhasesAttributes.FileExsist(atrFile))
                {
                    var checkedPhases = checkedPhasesAttributes.GetCheckedPhasesFromAttributeFile(atrFile);
                    view_checkedListBox.CheckPhases(checkedPhases);
                }
            }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            RepairHidingTeklaWindows();
        }

        private void ViewAttributeSave_buttonClick(object sender, EventArgs e)
        {
            try
            {
                var atrFile = viewAttribute_comboBox.Text;
                if (checkedPhasesAttributes.FileExsist(atrFile))
                {
                    var dialResult = MessageBox.Show("Do you want to overwrite exsisting file " + atrFile, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialResult == DialogResult.No) return;
                }

                var checkedList = view_checkedListBox.GetCheckedPhasesNumbers();

                checkedPhasesAttributes.SaveAttributeFile(atrFile, checkedList);
                RefreshAttributesList();
            }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            RepairHidingTeklaWindows();

        }

        private void ViewAttributeDelete_buttonClick(object sender, EventArgs e)
        {
            try
            {
                var atrFile = this.viewAttribute_comboBox.Text;
                if (checkedPhasesAttributes.FileExsist(atrFile))
                {
                    var dialResult = MessageBox.Show("Do you want to delete file " + atrFile, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialResult == DialogResult.No) return;

                    checkedPhasesAttributes.DeleteAttributeFile(atrFile);
                    RefreshAttributesList();
                    this.viewAttribute_comboBox.Text = LAST_FILTER_NAME;
                }
            }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            RepairHidingTeklaWindows();
        }

        private bool isFormHidded = false;
        private Size currentWindowSize = new Size(500, 500);
        private Size currentWindowMinimumSize = new Size(500, 500);

        private void HideShow_buttonClick(object sender, EventArgs e)
        {
            try
            {
                if (isFormHidded)
                {
                    //show form
                    foreach (Control currentControl in this.Controls)
                    {
                        if (currentControl != hideShow_button)
                        {
                            currentControl.Visible = true;
                        }
                    }

                    this.Size = currentWindowSize;
                    this.MinimumSize = currentWindowMinimumSize;
                    this.FormBorderStyle = FormBorderStyle.Sizable;

                    hideShow_button.Text = "<";
                    isFormHidded = false;
                }
                else
                {
                    //hide form
                    isFormHidded = true;
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
                    this.Size = new Size(30, this.Size.Height);


                    hideShow_button.Text = ">";
                }
                RepairHidingTeklaWindows();
            }
            catch (Exception) { }
        }

        private bool minWindow = false;
        private void Panel3_Resize(object sender, EventArgs e)
        {
            if (panel3.Size.Width < 150 & !isFormHidded & this.WindowState != FormWindowState.Minimized)
            {
                panel4.Hide();
                select_checkedListBox.Hide();
                minWindow = true;
                selectAllSelect_checkBox.Hide();
                selectNoneSelect_checkBox.Hide();
            }
            if (panel3.Size.Width >= 550 & minWindow)
            {
                panel4.Show();
                select_checkedListBox.Show();
                minWindow = false;
                selectAllSelect_checkBox.Show();
                selectNoneSelect_checkBox.Show();
            }
            if (panel3.Size.Height < 425 & this.WindowState != FormWindowState.Minimized)
            {
                buttonPanel1.Hide();
            }
            if (panel3.Size.Height >= 425)
            {
                buttonPanel1.Show();
            }
            if (panel3.Size.Height < 350 & this.WindowState != FormWindowState.Minimized)
            {
                buttonPanel2.Hide();
            }
            if (panel3.Size.Height >= 350)
            {
                buttonPanel2.Show();
            }
            if (this.WindowState != FormWindowState.Minimized)
            {
                RepairHidingTeklaWindows();
            }
        }

        private void Select_checkedListBox_MouseMove(object sender, MouseEventArgs e)
        {
            int index = this.select_checkedListBox.TopIndex;
            this.view_checkedListBox.TopIndex = index;
        }

        private void HideShow_button_MouseMove(object sender, MouseEventArgs e) => ViewMouseMove();

        private void NearestPlane_button_Click(object sender, EventArgs e) => RotateViewToNearestPlane();

        private void SelectAllSelect_checkBox_MouseUp(object sender, MouseEventArgs e)
        {
            select_checkedListBox.CheckAllPhases();
            selectAllSelect_checkBox.Checked = true;
        }

        private void SelectNoneSelect_checkBox_MouseUp(object sender, MouseEventArgs e)
        {
            select_checkedListBox.UnCheckAllPhases();
            selectNoneSelect_checkBox.Checked = false;
        }

        private void SelectAllView_checkBox_MouseUp(object sender, MouseEventArgs e)
        {
            view_checkedListBox.CheckAllPhases();
            selectAllView_checkBox.Checked = true;
        }

        private void SelectNone_checkBox_MouseUp(object sender, MouseEventArgs e)
        {
            view_checkedListBox.UnCheckAllPhases();
            selectNone_checkBox.Checked = false;
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            TryToRepairHidingTeklaWindowsAfterSecond();
        }

    }

}
