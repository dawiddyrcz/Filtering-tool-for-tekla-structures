/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using FilteringTool.ExportImport;
using System;
using System.Windows.Forms;

namespace FilteringTool.UI
{
    public partial class MainMenuControl : UserControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
        }

        HelpForm helpForm = new HelpForm();
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (helpForm.IsDisposed) helpForm = new HelpForm();
            helpForm.Show();
        }

        private void ImportPhaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = ExportFileFormat.EXPORT_FILE_FORMAT_NAME + "|*" + ExportFileFormat.EXPORT_FILE_FORMAT;
                var dialResult = openFileDialog1.ShowDialog();
                if (dialResult == DialogResult.Cancel) return;

                var importer = new PhaseImporter();
                var phasesFromFile = importer.LoadPhasesFromFile(openFileDialog1.FileName);
                if (phasesFromFile.GetSize() == 0)
                    throw new Exceptions.FilteringToolException("File has not phases");

                var phasesInModel = importer.GetPhasesFromModel();


                var importDialog = new ImportPhasesConflictForm(phasesFromFile, phasesInModel);
                var dialogResult = importDialog.ShowDialog();

                if (dialogResult == DialogResult.Cancel) return;

                var phasesToInsert = importDialog.PhasesToImport;
                importer.InsertOrModifyPhasesInTekla(phasesToInsert);
            }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void ExportPhaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var exporter = new PhaseExporter();
                var modelPhases = exporter.GetPhasesFromModel();

                var exportForm = new ExportPhasesForm(modelPhases);
                var dialogResult = exportForm.ShowDialog();
                if (dialogResult == DialogResult.Cancel) return;

                var phasesToExport = exportForm.PhasesToExport;
                if (phasesToExport.List.Count == 0) throw new Exceptions.FilteringToolException("No phases selected to export");

                var name = new Tekla.Structures.Model.Model().GetInfo().ModelName.Replace(".db1", "");
                saveFileDialog1.FileName = name;
                saveFileDialog1.Filter = ExportFileFormat.EXPORT_FILE_FORMAT_NAME + "|*" + ExportFileFormat.EXPORT_FILE_FORMAT;
                dialogResult = saveFileDialog1.ShowDialog();
                if (dialogResult == DialogResult.Cancel) return;

                var fileName = saveFileDialog1.FileName;
                exporter.ExportPhases(fileName, phasesToExport);
            }
            catch (Exceptions.FilteringToolException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void LicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var licenseForm = new LicenseForm();
            licenseForm.ShowDialog();
        }

        private void CheckUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var versionForm = new VersionForm();
            versionForm.ShowDialog();
        }

        private void ReleaseNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var releaseNoteForm = new ReleaseNoteForm();
            releaseNoteForm.ShowDialog();
        }
    }
}
