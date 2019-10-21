/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FilteringTool.ExportImport;

namespace FilteringTool.UI
{

    public partial class ImportPhasesConflictForm : Form
    {
        public SerializablePhaseCollection PhasesToImport { get; set; }

        private string ignoreStatus = "Ignore";
        private string overrideStatus = "Import / Override";
        private SerializablePhaseCollection phasesFromFile;

        public ImportPhasesConflictForm(SerializablePhaseCollection phasesFromFile, SerializablePhaseCollection modelPhases)
        {
            InitializeComponent();
            this.phasesFromFile = phasesFromFile;
            FillTable(phasesFromFile, modelPhases);
        }

        void FillTable(SerializablePhaseCollection phasesFromFile, SerializablePhaseCollection modelPhases)
        {
            foreach (var phase in phasesFromFile.List)
            {
                string modelPhaseName = "";
                var modelPhase = modelPhases.List.Find(p => p.Number.Equals(phase.Number));
                if (modelPhase != null) modelPhaseName = GetTextFromNameAndComment(modelPhase.Name, modelPhase.Comment);

                AddRow(phase.Number, modelPhaseName, GetTextFromNameAndComment(phase.Name, phase.Comment));
            }
            SetColors();
            CorrectStatus();
        }

        private string GetTextFromNameAndComment(string name, string comment)
        {
            var ret = "";
            ret = ret + name;
            if (comment.Equals("") == false) ret = ret + " / " + comment;
            return ret;
        }

        void AddRow(int number, string oldName, string newName)
        {
            dataGridView1.Rows.Add(number.ToString(), oldName, newName, overrideStatus);
        }

        private void IgnoreAll_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = ignoreStatus;
            }
            SetColors();
            CorrectStatus();
        }

        private void OverrideAll_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = overrideStatus;
            }
            SetColors();
            CorrectStatus();
        }

        private void IgnoreSelected_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.SelectedRows[i].Cells[3].Value = ignoreStatus;
            }
            SetColors();
            CorrectStatus();
        }

        private void OverrideSelected_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.SelectedRows[i].Cells[3].Value = overrideStatus;
            }
            SetColors();
            CorrectStatus();
        }

        private void SetColors()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.Equals(ignoreStatus))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

                if (dataGridView1.Rows[i].Cells[1].Value.Equals(dataGridView1.Rows[i].Cells[2].Value))
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
                else
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void CorrectStatus()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.Equals(ignoreStatus) == false)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.Equals(dataGridView1.Rows[i].Cells[2].Value))
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "";
                    }
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            PhasesToImport = new SerializablePhaseCollection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.Equals(ignoreStatus) == false)
                {
                    PhasesToImport.Add(phasesFromFile.List[i]);
                }
            }

            base.OnClosing(e);
        }
    }
}
