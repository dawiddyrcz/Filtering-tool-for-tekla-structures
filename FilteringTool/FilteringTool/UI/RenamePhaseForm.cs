/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class RenamePhaseForm : Form
    {
        private int phaseNumber;
        private Tekla.Structures.Model.Phase phase;
        private Tekla.Structures.Model.Model model;

        public RenamePhaseForm(int phaseNumber)
        {
            InitializeComponent();
            this.phaseNumber = phaseNumber;

            this.model = new Tekla.Structures.Model.Model();
            var phases = model.GetPhases();

            foreach (Tekla.Structures.Model.Phase phase in phases)
            {
                if (phase.PhaseNumber.Equals(phaseNumber))
                {
                    this.phase = phase;
                    break;
                }
            }

            phaseName_textBox.Text = phase.PhaseName;
        }

        void Cancel_buttonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void RenamePhase_buttonClick(object sender, EventArgs e)
        {
            try
            {
                this.phase.PhaseName = phaseName_textBox.Text;
                this.phase.Modify();
                this.model.CommitChanges();
                this.Close();
            }
            catch (Exception) { }
        }
    }
}
