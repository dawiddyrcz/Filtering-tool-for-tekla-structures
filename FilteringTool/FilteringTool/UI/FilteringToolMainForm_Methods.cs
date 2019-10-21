/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FilteringTool.UI
{
    partial class FilteringToolMainForm
    {
        private object _refreshPhasesLock = new object();

        private void RefreshPhases()
        {
            lock (_refreshPhasesLock)
            {
                var topIndex = view_checkedListBox.TopIndex;
                view_checkedListBox.RefreshPhases();
                select_checkedListBox.RefreshPhases();

                var pw = select_checkedListBox.PrefferedWidth;

                select_checkedListBox.Size = new Size(pw, select_checkedListBox.Size.Height);

                if (topIndex < view_checkedListBox.ItemsCount & topIndex >= 0)
                {
                    view_checkedListBox.TopIndex = topIndex;
                    select_checkedListBox.TopIndex = topIndex;
                }
            }
        }

        private object _refreshAtributesLock = new object();

        private void RefreshAttributesList(bool silent = false)
        {
            lock (_refreshAtributesLock)
            {
                try
                {
                    var viewAtribFiles = checkedPhasesAttributes.GetAllAttributeFileNames();
                    viewAttribute_comboBox.Items.Clear();
                    viewAttribute_comboBox.Items.AddRange(viewAtribFiles.ToArray());
                }
                catch (Exceptions.FilteringToolException ex) { if (!silent) MessageBox.Show(ex.Message); }
                catch (Exception ex) { if (!silent) MessageBox.Show(ex.ToString()); }

            }
        }

        private void AddPhase()
        {
            AddPhaseForm AddPhaseForm = new AddPhaseForm();
            AddPhaseForm.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height / 2);
            AddPhaseForm.ShowDialog();
            RefreshPhases();
            RepairHidingTeklaWindows();
        }

        private void RenamePhase()
        {
            var selectedPhaseNumber = view_checkedListBox.GetSelectedPhaseNumber();
            if (selectedPhaseNumber < 0) return;
            var renamePhaseForm = new RenamePhaseForm(selectedPhaseNumber);
            renamePhaseForm.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height / 2);
            renamePhaseForm.ShowDialog();
            this.RefreshPhases();
            RepairHidingTeklaWindows();
        }

        private void MoveToPhase()
        {
            var selectedPhaseNumber = view_checkedListBox.GetSelectedPhaseNumber();
            if (selectedPhaseNumber < 0) return;

            var changedObjects = filteringTool.MoveSelectedObjectsToPhase(selectedPhaseNumber);
            MessageBox.Show(changedObjects + " were moved to phase: " + selectedPhaseNumber);

            RepairHidingTeklaWindows();
        }

        private void SetCurrentPhase()
        {
            var selectedPhaseNumber = view_checkedListBox.GetSelectedPhaseNumber();
            if (selectedPhaseNumber < 0) return;

            filteringTool.SetCurrentPhase(selectedPhaseNumber);

            RefreshPhases();
            RepairHidingTeklaWindows();
        }

        private List<int> GetCheckedPhaseNumbersFromCheckedListBox(CheckedListBox checkedListBox)
        {
            var retList = new List<int>();

            foreach (TeklaPhase phase in checkedListBox.CheckedItems)
            {
                retList.Add(phase.GetNumber());
            }
            return retList;
        }

        private void SetSelect()
        {
            try
            {
                if (filteringTool.IsDrawingOpened()) return;

                var checkedPhases = select_checkedListBox.GetCheckedPhasesNumbers();
                filteringTool.SetSelectionFilter(checkedPhases);

            }
            catch (Exceptions.FilteringToolTeklaSettingsException ex) { AddErrorMessageToObjectInfo(ex.Message); }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void Redraw()
        {
            try
            {
                if (filteringTool.IsDrawingOpened()) return;
                var checkedPhases = view_checkedListBox.GetCheckedPhasesNumbers();

                if (CheckedPhasesChanged())
                {
                    if (FTSettings.Settings.ChangeOnlySelectedViews)
                    {
                        filteringTool.SetViewFilterOfSelectedViews(checkedPhases);
                    }
                    else
                    {
                        filteringTool.SetViewFilterOfAllViews(checkedPhases);
                    }
                }

                try
                {
                    checkedPhasesAttributes.SaveAttributeFile(LAST_FILTER_NAME, view_checkedListBox.GetCheckedPhasesNumbers());
                }
                catch (Exception) { }

                if (checkboxesControl1.CheckboxesChanged())
                {
                    if (!FTSettings.Settings.ChangeOnlySelectedViews) filteringTool.SelectAllModelViews();
                    var viewDisplay = checkboxesControl1.GetViewDisplay();
                    filteringTool.SetViewDisplayOfSelectedViews(viewDisplay);
                    checkboxesControl1.SetCheckboxChanged(false);
                }

                RepairHidingTeklaWindows();
            }
            catch (Exceptions.FilteringToolTeklaSettingsException ex) { AddErrorMessageToObjectInfo(ex.Message); }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private int attemptNumber = 0;
        private List<int> lastCheckedPhases = new List<int>();

        private bool CheckedPhasesChanged()
        {
            var currentCheckedPhases = view_checkedListBox.GetCheckedPhasesNumbers();
            currentCheckedPhases.Sort();

            if (ListsAreDifferent(currentCheckedPhases, lastCheckedPhases) | attemptNumber.Equals(4))
            {
                lastCheckedPhases.Clear();
                lastCheckedPhases.AddRange(currentCheckedPhases);
                attemptNumber = 0;
                return true;
            }
            else
            {
                attemptNumber++;
                return false;
            }
        }

        private bool ListsAreDifferent(List<int> list1, List<int> list2)
        {
            if (list1.Count.Equals(list2.Count))
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i].Equals(list2[i]) == false) return true;
                }
                return false;
            }
            else return true;
        }

        private void RotateViewToNearestPlane()
        {
            try
            {
                var selectedViews = Tekla.Structures.Model.UI.ViewHandler.GetSelectedViews();

                if (selectedViews.Count == 0)
                    selectedViews = Tekla.Structures.Model.UI.ViewHandler.GetVisibleViews();

                while (selectedViews.MoveNext())
                {
                    var view = selectedViews.Current;

                    var Camera = new Tekla.Structures.Model.UI.ViewCamera();
                    Camera.View = view;

                    Camera.Select();

                    var directionVector = new Tekla.Structures.Geometry3d.Vector(
                        Math.Round(Camera.DirectionVector.X),
                        Math.Round(Camera.DirectionVector.Y),
                        Math.Round(Camera.DirectionVector.Z)
                        );
                    Camera.DirectionVector = directionVector;

                    var upVecor = new Tekla.Structures.Geometry3d.Vector(
                        Math.Round(Camera.UpVector.X),
                        Math.Round(Camera.UpVector.Y),
                        Math.Round(Camera.UpVector.Z)
                        );
                    Camera.UpVector = upVecor;
                    Camera.Modify();
                    Camera.ZoomFactor = 1.5 * Camera.ZoomFactor;
                    Camera.Modify();

                    RepairHidingTeklaWindows();
                }
            }
            catch (Exception) { }
        }

        private void TryToRepairHidingTeklaWindowsAfterSecond()
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        Thread.Sleep(1000);
                        BeginInvoke(new MethodInvoker(() =>
                        {
                            RepairHidingTeklaWindows();
                        }));
                    }
                    catch (Exception) { }
                });
            }
            catch (Exception) { }
        }

        private void RepairHidingTeklaWindows()
        {
            this.TopMost = true;
            this.TopMost = false;
        }

        private DateTime lastRefreshOnMouseMove = new DateTime();

        private void ViewMouseMove()
        {
            try
            {
                int index = this.view_checkedListBox.TopIndex;
                this.select_checkedListBox.TopIndex = index;

                if (DateTime.Now.AddSeconds(-10) > lastRefreshOnMouseMove)
                {
                    this.Refresh();
                    lastRefreshOnMouseMove = DateTime.Now;
                }
            }
            catch (Exception) { }

        }


    }
}
