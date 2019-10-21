/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Diagnostics;
using System.IO;

namespace FilteringToolStarter
{
    class FilteringToolStarter
    {
        public void StartFilteringTool()
        {
            Properties.Settings.Default.Reload();
            var lastFTStart = Properties.Settings.Default.LastFTStart;
            var fromLastStart = (DateTime.Now - lastFTStart).Duration();

            if (fromLastStart <= new TimeSpan(0, 0, 10))
                return;

            var teklaProcess = new TeklaProcess();
            if (teklaProcess.IsTeklaRunning())
            {
                if (teklaProcess.GetTeklaProcessesCount() == 1)
                {
                    TryToCloseFilteringToolProcessesIfExsist();
                    TryToDeleteLastTempSubDirectories();
                    string filePath = CopyFilteringToolToTempDirectory(teklaProcess);
                    CorrectAndCopyConfigFile(teklaProcess);
                    var ftProcess = Process.Start(filePath);

                    if (ftProcess != null)
                    {
                        Properties.Settings.Default.LastFTStart = DateTime.Now;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    throw new Exceptions.FilteringToolStarterException("More than one Tekla is running. Filtering tool supports only one process");
                }
            }
            else
            {
                throw new Exceptions.FilteringToolStarterException("Could not find any Tekla Structures processes");
            }
        }

        private void TryToCloseFilteringToolProcessesIfExsist()
        {
            var processName = Path.GetFileNameWithoutExtension(Settings.FILTERING_TOOL_EXE_NAME);
            var ftProcesses = Process.GetProcessesByName(processName);
            foreach (Process process in ftProcesses)
            {
                try
                {
                    process.Kill();
                }
                catch (Exception) { }
            }
            System.Threading.Thread.Sleep(500);
        }

        private void TryToDeleteLastTempSubDirectories()
        {
            try
            {
                var tmpDir = new FilteringToolTEMPDirectory().GetTempPath();
                foreach (var directory in new DirectoryInfo(tmpDir).GetDirectories())
                {
                    DirecoryTools.DeleteDir(tmpDir);
                }
            }
            catch (Exception) { }
        }

        private string CopyFilteringToolToTempDirectory(TeklaProcess teklaProcess)
        {
            try
            {
                var inputDir = Settings.INPUT_DIRECTORY_NAME;
                var tmpDir = new FilteringToolTEMPDirectory();
                var outputDir = tmpDir.GetVersionTempPath(teklaProcess.GetTeklaStructuresVersion());
                DirecoryTools.CopyDir(inputDir, outputDir);

                foreach (var aditionalFileName in Settings.ADDITIONAL_FILE_NAMES)
                {
                    try
                    {
                        File.Copy(aditionalFileName, Path.Combine(outputDir, aditionalFileName));
                    }
                    catch (Exception) { }
                }

                return Path.Combine(outputDir, Settings.FILTERING_TOOL_EXE_NAME);
            }
            catch (Exception innerException)
            {
                throw new Exceptions.FilteringToolStarterIOException("Could not start filtering tool. Cannot copy to temp directory", innerException);
            }
        }

        private void CorrectAndCopyConfigFile(TeklaProcess teklaProcess)
        {
            try
            {
                string inputConfigFile = Path.Combine(teklaProcess.GetTeklaProcessDirectoryPath(), Settings.TEKLA_STRUCTURES_CONFIG_NAME);
                var tmp = new FilteringToolTEMPDirectory();
                string outputFile = Path.Combine(tmp.GetVersionTempPath(teklaProcess.GetTeklaStructuresVersion()), Settings.FILTERING_TOOL_CONFIG_NAME);
                new TeklaStructuresConfigFile().CorrectAndCopy(inputConfigFile, outputFile);
            }
            catch (Exception innerException)
            {
                throw new Exceptions.FilteringToolStarterIOException("Could not start filtering tool. Cannot correct and copy config file", innerException);
            }
        }
    }
}
