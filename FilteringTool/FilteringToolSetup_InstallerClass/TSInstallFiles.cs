using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace FilteringToolSetup
{
    /// <summary>
    /// This class copy (or delete) files from the directories of Tekla Structures Application
    /// </summary>
    internal class TSInstallFiles
    {
        public TSInstallFiles()
        {

        }

        private readonly List<TeklaData> tsData = new List<TeklaData>();

        /// <summary>
        /// Adds Tekla Version to internal list and gets information from the system registry
        /// </summary>
        /// <param name="version"></param>
        public void AddTeklaVersion(string version)
        {
            if (TeklaData.TryToGet(version, out TeklaData newTSData))
            {
                var exsistingTSDataIndex = this.tsData.FindIndex(x => x.Version == version);

                if (exsistingTSDataIndex < 0)
                    this.tsData.Add(newTSData);
                else
                    this.tsData[exsistingTSDataIndex] = newTSData;
            }
        }

        /// <summary>
        /// Copies all files from the list to the Teklas directory: TSDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void CopyFilesTo_TSDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) 
                        CopyFileToDirectory(currentFilePath, currentTeklaData.TSDirectory);
                }
            }
        }

        /// <summary>
        /// Delete all files from the list from the Teklas directory: TSDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void DeleteFilesFrom_TSDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) DeleteFileFromDirectory(currentFilePath, currentTeklaData.TSDirectory);
                }
            }
        }

        /// <summary>
        /// Copies all files from the list to the Teklas directory: TSPluginDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void CopyFilesTo_TSPluginDirectory(List<string> filesFullPathList, string subDirectory)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                    {
                        var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);
                        CopyFileToDirectory(currentFilePath, outputDir);
                    }
                }
            }
        }

        public void CopyFilesTo_TSPluginDirectory_Specific(List<SpecificTeklaFile> filePathesAndVersions, string subDirectory)
        {
            foreach (var currentFileData in filePathesAndVersions)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                    {
                        if (currentTeklaData.Version.Equals(currentFileData.TeklaVersion, StringComparison.InvariantCulture)
                            ||
                            (currentTeklaData.IsNewTekla && currentFileData.TeklaVersion.Equals("new"))
                            )
                        {
                            var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);
                            CopyFileToDirectory(currentFileData.FileName, outputDir);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Delete all files from the list from the Teklas directory: TSPluginDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void DeleteFilesFrom_TSPluginDirectory(List<string> filesFullPathList, string subDirectory)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                    {
                        var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);
                        DeleteFileFromDirectory(currentFilePath, outputDir);
                    }
                }
            }
        }

        public void DeleteFilesFrom_TSPluginDirectory_Specific(List<SpecificTeklaFile> filesFullPathListWithVersions, string subDirectory)
        {
            foreach (var currentFileData in filesFullPathListWithVersions)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                    {
                        try
                        {
                            var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);
                            DeleteFileFromDirectory(currentFileData.FileName, outputDir);
                            DeleteFileFromDirectory(currentFileData.FileName.Replace(".dll", ".dll.config"), outputDir);
                        }
                        catch { }
                    }
                }
            }
        }

        /// <summary>
        /// Copies all files from the list to the Teklas directory: EnvCommonSystemDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void CopyFilesTo_EnvCommonSystemDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) 
                        CopyFileToDirectory(currentFilePath, currentTeklaData.EnvCommonSystemDirectory);
                }
            }
        }

        /// <summary>
        /// Delete all files from the list from the Teklas directory: EnvCommonSystemDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void DeleteFilesFrom_EnvCommonSystemDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) 
                        DeleteFileFromDirectory(currentFilePath, currentTeklaData.EnvCommonSystemDirectory);
                }
            }
        }

        /// <summary>
        /// Copies all files from the list to the Teklas directory: Enviroments Common extension directory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void CopyFilesTo_EnvCommonExtensionDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        CopyFileToDirectory(currentFilePath, currentTeklaData.EnvCommonExtensionDir);
                }
            }
        }

        /// <summary>
        /// Delete all files from the list from the Teklas directory: Enviroments Common extension directory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void DeleteFilesFrom_EnvCommonExtensionDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) 
                        DeleteFileFromDirectory(currentFilePath, currentTeklaData.EnvCommonExtensionDir);
                }
            }
        }

        public void CopyFilesTo_USAImperialSystemDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        CopyFileToDirectory(currentFilePath, currentTeklaData.USAImperialSystemDirectory);
                }
            }
        }

        public void DeleteFilesFrom_USAImperialSystemDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        DeleteFileFromDirectory(currentFilePath, currentTeklaData.USAImperialSystemDirectory);
                }
            }
        }

        public void CopyFilesTo_USAMetricSystemDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        CopyFileToDirectory(currentFilePath, currentTeklaData.USAMetricSystemDirectory);
                }
            }
        }

        public void DeleteFilesFrom_USAMetricSystemDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        DeleteFileFromDirectory(currentFilePath, currentTeklaData.USAMetricSystemDirectory);
                }
            }
        }

        public void CopyFilesTo_EnvCommonInpDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        CopyFileToDirectory(currentFilePath, currentTeklaData.EnvCommonInpDirectory);
                }
            }
        }

        public void DeleteFilesFrom_EnvCommonInpDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled)
                        DeleteFileFromDirectory(currentFilePath, currentTeklaData.EnvCommonInpDirectory);
                }
            }
        }

        /// <summary>
        /// Copies all files from the list to the Teklas directory: EnvBmpDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void CopyFilesTo_EnvBmpDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) 
                        CopyFileToDirectory(currentFilePath, currentTeklaData.EnvBmpDirectory);
                }
            }
        }

        /// <summary>
        /// Delete all files from the list from the Teklas directory: EnvBmpDirectory
        /// </summary>
        /// <param name="filesFullPathList"></param>
        public void DeleteFilesFrom_EnvBmpDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled) 
                        DeleteFileFromDirectory(currentFilePath, currentTeklaData.EnvBmpDirectory);
                }
            }
        }

        private void CopyFileToDirectory(string sourceFilePath, string destinationDirectory)
        {
            if (File.Exists(sourceFilePath))
            {
                if (!Directory.Exists(destinationDirectory))
                {
                    try { Directory.CreateDirectory(destinationDirectory); } catch { }
                }

                if (Directory.Exists(destinationDirectory))
                {
                    var fileName = new FileInfo(sourceFilePath).Name;
                    var destinationPath = Path.Combine(destinationDirectory, fileName);
                    File.Copy(sourceFilePath, destinationPath, true);

                    var destinationFileInfo = new FileInfo(destinationPath);
                    var accessControl = destinationFileInfo.GetAccessControl();
                    accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
                    destinationFileInfo.SetAccessControl(accessControl);
                }
            }
        }

        private void DeleteFileFromDirectory(string sourceFilePath, string destinationDirectory)
        {
            var fileName = new FileInfo(sourceFilePath).Name;
            string fileFullName = Path.Combine(destinationDirectory, fileName);

            if (File.Exists(fileFullName))
            {
                File.Delete(fileFullName);
            }
        }

        public void CopyTeklaStructuresConfigFiles(List<string> filesFullPathList, string subDirectory)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled 
                        && File.Exists(currentFilePath) 
                        && File.Exists(currentTeklaData.TSConfigFileFullPath))
                    {
                        ChangeTeklaStructuresConfigFileIfNescesary(currentTeklaData.TSConfigFileFullPath);

                        var currentFileName = new FileInfo(currentFilePath).Name;
                        var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);
                        var configDllFileName = Path.Combine(outputDir, currentFileName + ".config");

                        File.Copy(currentTeklaData.TSConfigFileFullPath, configDllFileName, true);
                    }
                }
            }
        }

        public void CopyTeklaStructuresConfigFiles_Specific(List<SpecificTeklaFile> filesFullPathListWithVersions, string subDirectory)
        {
            foreach (var currentFileData in filesFullPathListWithVersions)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.Version.Equals(currentFileData.TeklaVersion, StringComparison.InvariantCulture)
                            ||
                            (currentTeklaData.IsNewTekla && currentFileData.TeklaVersion.Equals("new"))
                            )
                    {
                        if (currentTeklaData.IsTeklaInstaled && File.Exists(currentFileData.FileName) && File.Exists(currentTeklaData.TSConfigFileFullPath))
                        {
                            ChangeTeklaStructuresConfigFileIfNescesary(currentTeklaData.TSConfigFileFullPath);

                            var currentFileName = new FileInfo(currentFileData.FileName).Name;
                            var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);

                            var configDllFileName = Path.Combine(outputDir, currentFileName + ".config");

                            File.Copy(currentTeklaData.TSConfigFileFullPath, configDllFileName, true);
                        }
                    }
                }
            }
        }

        public void CopyTeklaStructuresConfigFilesToCommonExtensionDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTSData in this.tsData)
                {
                    if (currentTSData.IsTeklaInstaled 
                        && File.Exists(currentFilePath) 
                        && File.Exists(currentTSData.TSConfigFileFullPath))
                    {
                        ChangeTeklaStructuresConfigFileIfNescesary(currentTSData.TSConfigFileFullPath);

                        var currentFileName = new FileInfo(currentFilePath).Name;
                        var configDllFileName = Path.Combine(currentTSData.EnvCommonExtensionDir, currentFileName + ".config");

                        if (Directory.Exists(Path.GetDirectoryName(configDllFileName)))
                        {
                            File.Copy(currentTSData.TSConfigFileFullPath, configDllFileName, true);
                        }
                    }
                }
            }
        }

        public void DeleteConfigFiles(List<string> filesFullPathList, string subDirectory)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTeklaData in this.tsData)
                {
                    if (currentTeklaData.IsTeklaInstaled 
                        && File.Exists(currentTeklaData.TSConfigFileFullPath))
                    {
                        var currentFileName = new FileInfo(currentFilePath).Name;
                        var outputDir = string.IsNullOrWhiteSpace(subDirectory) ? currentTeklaData.TSPluginDirectory : Path.Combine(currentTeklaData.TSPluginDirectory, subDirectory);
                        var configDllFileName = Path.Combine(outputDir, currentFileName + ".config");

                        if (File.Exists(configDllFileName)) File.Delete(configDllFileName);
                    }
                }
            }
        }

        public void DeleteConfigFilesFromCommonExtensionDirectory(List<string> filesFullPathList)
        {
            foreach (var currentFilePath in filesFullPathList)
            {
                foreach (var currentTSData in this.tsData)
                {
                    if (currentTSData.IsTeklaInstaled 
                        && File.Exists(currentTSData.TSConfigFileFullPath))
                    {
                        var currentFileName = new FileInfo(currentFilePath).Name;
                        var configDllFileName = Path.Combine(currentTSData.EnvCommonExtensionDir, currentFileName + ".config");

                        if (File.Exists(configDllFileName)) File.Delete(configDllFileName);
                    }
                }
            }
        }

        private void ChangeTeklaStructuresConfigFileIfNescesary(string configFileFullName)
        {
            //For Tekla Structures up to 21.1 redirection in config is to version 99.1.0.0 of assemblies. It is needed to change it to 9999.1.0.0
            if (File.Exists(configFileFullName))
            {
                string configFileText = File.ReadAllText(configFileFullName);

                if (configFileText.Contains("-99.1.0.0"))
                {
                    var bakConfilFileFullName = Path.Combine(configFileFullName + ".bak");
                    if (!File.Exists(bakConfilFileFullName))
                        File.Copy(configFileFullName, bakConfilFileFullName, true);
                    configFileText = configFileText.Replace("-99.1.0.0", "-9999.1.0.0");
                    File.WriteAllText(configFileFullName, configFileText);
                }

                configFileText = File.ReadAllText(configFileFullName);
            }
        }
    }
}
