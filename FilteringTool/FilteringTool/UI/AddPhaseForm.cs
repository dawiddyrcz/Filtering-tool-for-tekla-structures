/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class AddPhaseForm : Form
    {
        public AddPhaseForm()
        {
            InitializeComponent();
        }

        private void Cancel_buttonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPhase_buttonClick(object sender, EventArgs e)
        {
            try
            {

                int number = Convert.ToInt32(this.phaseNumber_textBox.Text);

                if (number <= 0) throw new System.FormatException();

                var newTeklaPhase = new TeklaPhase(number, this.phaseName_textBox.Text);
                newTeklaPhase.Insert();

                this.Close();
            }
            catch (System.FormatException) { MessageBox.Show("Incorrect phase number", "Error"); }
            catch (Exception) { }
        }
    }
}
