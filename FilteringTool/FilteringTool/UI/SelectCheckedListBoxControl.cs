/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class SelectCheckedListBoxControl : UserControl
    {
        public int TopIndex
        {
            get { return checkedListBox.TopIndex; }
            set { checkedListBox.TopIndex = value; }
        }

        public int PreferredHeight => checkedListBox.PreferredHeight;
        public int PrefferedWidth => CalculatePrefferedWidth();
        public int ItemsCount => checkedListBox.Items.Count;

        public event Action SelectViewClicked;
        public event Action RefreshClicked;
        public event Action ViewMouseMove;

        private object controlIsBusy = new object();

        public SelectCheckedListBoxControl()
        {
            InitializeComponent();
        }

        public int GetSelectedPhaseNumber()
        {
            lock (controlIsBusy)
            {
                if (checkedListBox.SelectedIndex < 0) return -1;
                return ((SelectPhaseRow)checkedListBox.SelectedItem).Number;
            }
        }

        public List<int> GetCheckedPhasesNumbers()
        {
            lock (controlIsBusy)
            {
                var retList = new List<int>();
                foreach (SelectPhaseRow phaseRow in checkedListBox.CheckedItems)
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
                    var phaseRow = (SelectPhaseRow)checkedListBox.Items[i];

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

        public void RefreshPhases()
        {
            lock (controlIsBusy)
            {
                var topIndex = checkedListBox.TopIndex;
                var viewCheckedItems = new List<int>(checkedListBox.CheckedItems.Count);

                foreach (SelectPhaseRow item in checkedListBox.CheckedItems) //Cannot just copy
                {
                    viewCheckedItems.Add(item.Number);
                }

                int viewSelectedPhase = -1;

                if (checkedListBox.SelectedItem != null)
                    viewSelectedPhase = ((SelectPhaseRow)checkedListBox.SelectedItem).Number;

                //Clearing the lists
                checkedListBox.Items.Clear();
                var phaseRowList = new List<SelectPhaseRow>();

                //Getting phases from model
                foreach (Tekla.Structures.Model.Phase phase in new Tekla.Structures.Model.Model().GetPhases())
                {
                    var phaseRow = new SelectPhaseRow()
                    {
                        Number = phase.PhaseNumber,
                    };
                    phaseRowList.Add(phaseRow);
                }

                //Sorting phases
                phaseRowList.Sort();

                checkedListBox.Items.AddRange(phaseRowList.ToArray());

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    var phaseRow = (SelectPhaseRow)checkedListBox.Items[i];
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
                        SelectViewClicked?.Invoke();
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

        private int CalculatePrefferedWidth()
        {
            int maxSize = 0;
            foreach (SelectPhaseRow phaseNumber in checkedListBox.Items)
            {
                maxSize = Math.Max(maxSize, phaseNumber.ToString().Length);
            }

            maxSize += 5 * maxSize + 30;
            return maxSize;
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("", "IDE0019")]
        private class SelectPhaseRow : IComparable
        {
            public int Number { get; set; } = -1;

            public override string ToString()
            {
                return "" + Number;
            }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;
                else
                {
                    var item = obj as SelectPhaseRow;
                    if (item == null) return 1;

                    if (Number <= item.Number) return -1;
                    else return 1;
                }
            }
        }


    }
}
