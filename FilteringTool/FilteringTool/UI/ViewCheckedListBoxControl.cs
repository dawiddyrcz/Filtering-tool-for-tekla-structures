/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class ViewCheckedListBoxControl : UserControl
    {
        public int TopIndex
        {
            get { return checkedListBox.TopIndex; }
            set { checkedListBox.TopIndex = value; }
        }

        public int PreferredHeight => checkedListBox.PreferredHeight;
        public int ItemsCount => checkedListBox.Items.Count;

        public event Action RedrawViewClicked;
        public event Action SetCurrentPhaseClicked;
        public event Action MoveToPhaseClicked;
        public event Action AddNewPhaseClicked;
        public event Action RenamePhaseClicked;
        public event Action RefreshClicked;
        public event Action ViewMouseMove;
        public event Action SelectObjectsByPhaseClicked;

        private object controlIsBusy = new object();

        public ViewCheckedListBoxControl()
        {
            InitializeComponent();
        }

        public int GetSelectedPhaseNumber()
        {
            lock (controlIsBusy)
            {
                if (checkedListBox.SelectedIndex < 0) return -1;
                return ((PhaseRow)checkedListBox.SelectedItem).Number;
            }
        }

        public List<int> GetCheckedPhasesNumbers()
        {
            lock (controlIsBusy)
            {
                var retList = new List<int>();
                foreach (PhaseRow phaseRow in checkedListBox.CheckedItems)
                {
                    retList.Add(phaseRow.Number);
                }
                return retList;
            }
        }

        public void CheckPhases(List<int> phasesToCheck)
        {
            lock (controlIsBusy)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, false);
                    var phaseRow = (PhaseRow)checkedListBox.Items[i];

                    if (phasesToCheck.Contains(phaseRow.Number))
                        checkedListBox.SetItemChecked(i, true);
                }
            }
        }

        public void CheckAllPhases()
        {
            lock (controlIsBusy)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
        }

        public void UnCheckAllPhases()
        {
            lock (controlIsBusy)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }

        public bool PhasesChanged()
        {
            bool ret = false;
            try
            {
                var phaseRowsFromModel = GetPhasesFromModel();
                if (phaseRowsFromModel.Count != checkedListBox.Items.Count) return true;

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    if (checkedListBox.Items[i].Equals(phaseRowsFromModel[i]) == false)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            catch (Exception) { }
            return ret;
        }

        public void RefreshPhases()
        {
            lock (controlIsBusy)
            {
                var topIndex = checkedListBox.TopIndex;
                var viewCheckedItems = new List<int>(checkedListBox.CheckedItems.Count);

                foreach (PhaseRow item in checkedListBox.CheckedItems) //Cannot just copy
                {
                    viewCheckedItems.Add(item.Number);
                }

                int viewSelectedPhase = -1;

                if (checkedListBox.SelectedItem != null)
                    viewSelectedPhase = ((PhaseRow)checkedListBox.SelectedItem).Number;

                //Clearing the lists
                checkedListBox.Items.Clear();
                List<PhaseRow> phaseRowList = GetPhasesFromModel();

                checkedListBox.Items.AddRange(phaseRowList.ToArray());

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    var phaseRow = (PhaseRow)checkedListBox.Items[i];
                    if (viewCheckedItems.Contains(phaseRow.Number))
                    {
                        checkedListBox.SetItemChecked(i, true);
                    }
                }


                var viewSelectedIndex = phaseRowList.FindIndex(p => p.Number == viewSelectedPhase);
                if (viewSelectedIndex >= 0) checkedListBox.SetSelected(viewSelectedIndex, true);

                checkedListBox.TopIndex = topIndex;
            }
        }

        private static List<PhaseRow> GetPhasesFromModel()
        {
            var phaseRowList = new List<PhaseRow>();

            //Getting phases from model
            foreach (Tekla.Structures.Model.Phase phase in new Tekla.Structures.Model.Model().GetPhases())
            {
                var phaseRow = new PhaseRow()
                {
                    Number = phase.PhaseNumber,
                    Name = phase.PhaseName,
                    IsCurrent = Convert.ToBoolean(phase.IsCurrentPhase)
                };
                phaseRowList.Add(phaseRow);
            }

            //Sorting phases
            phaseRowList.Sort();
            return phaseRowList;
        }

        bool multiCheckEnded = true;

        void CheckedListBoxMouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (Control.ModifierKeys == Keys.Control)
                    {
                        checkedListBox.SelectedIndex = GetIndexFormMousePosition(e.X, e.Y);
                        contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y + 7);
                    }
                    else
                    {
                        RedrawViewClicked?.Invoke();
                    }
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (Control.ModifierKeys == Keys.Control)
                        ReverseCheckOnSelectedRow();
                    else if (Control.ModifierKeys == Keys.Shift)
                    {
                        if (multiCheckEnded)
                            StartMultiCheck();
                        else
                            EndMultiCheck();
                    }
                    else
                    {
                        StartMultiCheck();
                    }
                }
            }
            catch (Exception) { }
        }

        private int startItemIndex = -1;
        private bool startItemCheckState = false;

        private void EndMultiCheck()
        {
            var endItemIndex = checkedListBox.SelectedIndex;
            if (endItemIndex < 0)

            {
                return;
            }

            int a = Math.Min(startItemIndex, endItemIndex);
            int b = Math.Max(startItemIndex, endItemIndex);
            for (int i = a; i <= b; i++)
            {
                checkedListBox.SetItemChecked(i, startItemCheckState);
            }
            multiCheckEnded = true;
        }

        private void StartMultiCheck()
        {
            startItemIndex = checkedListBox.SelectedIndex;
            if (startItemIndex < 0) return;
            startItemCheckState = checkedListBox.GetItemChecked(startItemIndex);
            multiCheckEnded = false;
        }

        private int GetIndexFormMousePosition(int x, int y)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                var rectangle = checkedListBox.GetItemRectangle(i);
                if (rectangle.Contains(x, y)) return i;
            }
            return -1;
        }

        private void ReverseCheckOnSelectedRow()
        {
            var selectedIndex = checkedListBox.SelectedIndex;
            if (selectedIndex < 0) return;
            checkedListBox.SetItemChecked(selectedIndex, !checkedListBox.GetItemChecked(selectedIndex));
        }

        private void SetCurrentPhaseToolStripMenuItem_Click(object sender, EventArgs e) => SetCurrentPhaseClicked?.Invoke();

        private void MoveObjectsToPhaseToolStripMenuItem_Click(object sender, EventArgs e) => MoveToPhaseClicked?.Invoke();

        private void AddNewPhaseToolStripMenuItem_Click(object sender, EventArgs e) => AddNewPhaseClicked?.Invoke();

        private void RenamePhaseToolStripMenuItem_Click(object sender, EventArgs e) => RenamePhaseClicked?.Invoke();

        private void View_checkedListBox_MouseMove(object sender, MouseEventArgs e) => ViewMouseMove?.Invoke();

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e) => RefreshClicked?.Invoke();

        private void SelectAllPhasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }

        private void UnselectAllPhasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void SelectObjectsByPhaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedIndex = checkedListBox.SelectedIndex;
            if (selectedIndex < 0) return;

            SelectObjectsByPhaseClicked?.Invoke();

            try
            {
                PhaseObjectSelector.SelectObjects(this.GetSelectedPhaseNumber());
            }
            catch (Exception) { }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("", "IDE0019")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("", "CS0659")]
        private class PhaseRow : IComparable
        {
            public int Number { get; set; } = -1;
            public string Name { get; set; } = "";
            public bool IsCurrent { get; set; } = false;

            public override string ToString()
            {
                if (IsCurrent)
                {
                    return "@" + Number + "  " + Name + "   @ current phase";
                }
                else
                {
                    return "" + Number + "  " + Name;
                }
            }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;
                else
                {
                    var item = obj as PhaseRow;
                    if (item == null) return 1;

                    if (Number <= item.Number) return -1;
                    else return 1;
                }
            }

            public override bool Equals(object obj)
            {
                var pRow = obj as PhaseRow;
                if (pRow == null) return false;
                return this.ToString().Equals(pRow.ToString());
            }
        }


    }
}
