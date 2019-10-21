/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FilteringTool.ExportImport;

namespace FilteringTool.UI
{
    public partial class ExportPhasesForm : Form
    {
        public SerializablePhaseCollection PhasesToExport { get; set; }

        private string ignoreStatus = "Ignore";
        private string exportStatus = "Export";
        private SerializablePhaseCollection modelPhases;

        public ExportPhasesForm(SerializablePhaseCollection modelPhases)
        {
            InitializeComponent();
            this.modelPhases = modelPhases;
            FillTable(modelPhases);
        }

        private void FillTable(SerializablePhaseCollection modelPhases)
        {
            foreach (var phase in modelPhases.List)
            {
                AddRow(phase.Number, phase.Name);
            }
            SetColors();
        }

        private string GetTextFromNameAndComment(string name, string comment)
        {
            var ret = "";
            ret = ret + name;
            if (comment.Equals("") == false) ret = ret + " / " + comment;
            return ret;
        }

        private void AddRow(int number, string name)
        {
            dataGridView1.Rows.Add(number.ToString(), name, exportStatus);
        }

        private void IgnoreAll_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = ignoreStatus;
            }
            SetColors();
        }

        private void OverrideAll_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = exportStatus;
            }
            SetColors();
        }

        private void IgnoreSelected_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.SelectedRows[i].Cells[2].Value = ignoreStatus;
            }
            SetColors();
        }

        private void OverrideSelected_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.SelectedRows[i].Cells[2].Value = exportStatus;
            }
            SetColors();
        }

        private void SetColors()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.Equals(ignoreStatus))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            PhasesToExport = new SerializablePhaseCollection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.Equals(ignoreStatus) == false)
                {
                    PhasesToExport.Add(modelPhases.List[i]);
                }
            }

            base.OnClosing(e);
        }
    }
}
