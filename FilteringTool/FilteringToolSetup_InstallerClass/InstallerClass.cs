using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace FilteringToolSetup
{
    [RunInstaller(true)]
    public partial class InstallerClass : System.Configuration.Install.Installer
    {
        //This class is very hard to debug. Very hard.

        //How it works?
        //MSI installer copies files to "C:\Program Files\Manufacturer\ProductName" directory.
        //Then...
        //MSI installer loads this class and runs proper methods to copy files (from Program Files) to proper "Tekla Structures\bin\plugins" Directory.
        //User has good experience of clicking "next", "next", "next".
        //User has elevated (admin) privilanges, so files can be copied to "Program Files" directory without error. 

        //For Tekla Structures 2016+ the better way of installing tekla macros is TSEP. Not MSI. This method is for older Tekla Structures like 20.0 

        public InstallerClass()
        {
            //You can add versions from TS18.1 to TS2019i
            tSInstallFiles = new TSInstallFiles();

            tSInstallFiles.AddTeklaVersion("20.0");
            tSInstallFiles.AddTeklaVersion("20.1");
            tSInstallFiles.AddTeklaVersion("21.0");
            tSInstallFiles.AddTeklaVersion("21.1");

            InitializeComponent();
        }

        private readonly TSInstallFiles tSInstallFiles;

        //Subdirectory path inside Tekla bin\plugins folder. 
        private readonly string subDirectory = Path.Combine("Tekla", "Model", "DDBIMFilteringTool");

        //This file pathes are local path in Program Files Directory
        //What does it mean?
        //If in your program files directory something is inside folder, bellow you have to specify this folder name in path
        //For example "SubFolderName\\Myfile.exe"

        private readonly List<string> filesToCopy_ToPluginFolder_with_config_files = new List<string>()
        {
            "FilteringTool\\FilteringTool.exe"
        };

        private readonly List<string> filesToCopy_ToPluginFolder = new List<string>()
        {
            "FilteringToolPlugin.dll",
            "FilteringTool\\Newtonsoft.Json.dll",
            "License.rtf",
            "License.txt",
            "ReleaseNote.txt",
        };

        private readonly List<string> filesToCopy_ToBitmapFolder = new List<string>()
        {
            "et_element_Filtering Tool.bmp"
        };

        private readonly List<SpecificTeklaFile> filesToCopy_ToPluginFolder_specific = new List<SpecificTeklaFile>()
        {
            //new SpecificTeklaFile("21.1", "SomeFileVersion21.1")
        };

        private readonly List<string> toRemoveDuringInstallation = new List<string>()
        {
            //Always remove during installation
        };

        private readonly List<string> filesToCopy_commonInpDirectory = new List<string>()
        {

        };

        private readonly List<string> filesToCopy_ToCommonSystemFolder = new List<string>()
        {

        };

        private readonly List<string> filesToCopy_commonExtensionDirectory = new List<string>()
        {

        };

        private readonly List<string> filesToCopy_USAImperialSystemDirectory = new List<string>()
        {

        };

        private readonly List<string> filesToCopy_USAMetricSystemDirectory = new List<string>()
        {

        };

        /// <summary>
        /// Change local pathes (from this class fields above) to full pathes
        /// Example: "SubFolder\\File1.txt" -> "C:\\Program Files\\Manufacturer\\ProductName\\SubFolder\\File1.txt"
        /// </summary>
        private void CorrectFilePathes(string targetDir)
        {
            for (int i = 0; i < toRemoveDuringInstallation.Count; i++)
            {
                toRemoveDuringInstallation[i] = Path.Combine(targetDir, toRemoveDuringInstallation[i]);
            }

            for (int i = 0; i < filesToCopy_ToPluginFolder_with_config_files.Count; i++)
            {
                filesToCopy_ToPluginFolder_with_config_files[i] = Path.Combine(targetDir, filesToCopy_ToPluginFolder_with_config_files[i]);
            }

            for (int i = 0; i < filesToCopy_ToPluginFolder.Count; i++)
            {
                filesToCopy_ToPluginFolder[i] = Path.Combine(targetDir, filesToCopy_ToPluginFolder[i]);
            }

            for (int i = 0; i < filesToCopy_ToPluginFolder_specific.Count; i++)
            {
                filesToCopy_ToPluginFolder_specific[i].FileName = Path.Combine(targetDir, filesToCopy_ToPluginFolder_specific[i].FileName);
            }

            for (int i = 0; i < filesToCopy_ToBitmapFolder.Count; i++)
            {
                filesToCopy_ToBitmapFolder[i] = Path.Combine(targetDir, filesToCopy_ToBitmapFolder[i]);
            }

            for (int i = 0; i < filesToCopy_ToCommonSystemFolder.Count; i++)
            {
                filesToCopy_ToCommonSystemFolder[i] = Path.Combine(targetDir, filesToCopy_ToCommonSystemFolder[i]);
            }

            for (int i = 0; i < filesToCopy_commonExtensionDirectory.Count; i++)
            {
                filesToCopy_commonExtensionDirectory[i] = Path.Combine(targetDir, filesToCopy_commonExtensionDirectory[i]);
            }

            for (int i = 0; i < filesToCopy_commonInpDirectory.Count; i++)
            {
                filesToCopy_commonInpDirectory[i] = Path.Combine(targetDir, filesToCopy_commonInpDirectory[i]);
            }

            for (int i = 0; i < filesToCopy_USAMetricSystemDirectory.Count; i++)
            {
                filesToCopy_USAMetricSystemDirectory[i] = Path.Combine(targetDir, filesToCopy_USAMetricSystemDirectory[i]);
            }

            for (int i = 0; i < filesToCopy_USAImperialSystemDirectory.Count; i++)
            {
                filesToCopy_USAImperialSystemDirectory[i] = Path.Combine(targetDir, filesToCopy_USAImperialSystemDirectory[i]);
            }
        }

        private void CloseTeklaMessage()
        {
        AGAIN:
            int tsProcessesCount = 0;

            foreach (var currentProces in Process.GetProcesses())
            {
                if (currentProces.ProcessName == "TeklaStructures")
                {
                    if (currentProces != null) tsProcessesCount++;
                }
            }

            if (tsProcessesCount > 0)
            {
                var msgBoxResult = System.Windows.Forms.MessageBox.Show("Close all Tekla Structures processes!", "Close Tekla Structures", System.Windows.Forms.MessageBoxButtons.RetryCancel);

                if (msgBoxResult == System.Windows.Forms.DialogResult.Retry) goto AGAIN;
                else throw new Exception("Instalation canceled by user");
            }
        }

        public override void Install(IDictionary stateSaver)
        {
            CloseTeklaMessage();

            //During MSI Installation user can change the desitnation folder.
            //We have to get this folder and then correct our local pathes to full pathes. 
            //The TargetDir attribute stores can be usedfor this. 

            //In MSI project add to custom actions atributes:  /TargetDir="[TARGETDIR]\" 
            var targetDir = Context.Parameters["TargetDir"].ToString();  
            CorrectFilePathes(targetDir);

            tSInstallFiles.CopyFilesTo_EnvBmpDirectory(filesToCopy_ToBitmapFolder);
            tSInstallFiles.CopyFilesTo_EnvCommonSystemDirectory(filesToCopy_ToCommonSystemFolder);
            tSInstallFiles.CopyFilesTo_TSPluginDirectory(filesToCopy_ToPluginFolder_with_config_files, subDirectory);
            tSInstallFiles.CopyFilesTo_TSPluginDirectory(filesToCopy_ToPluginFolder, subDirectory);
            tSInstallFiles.CopyTeklaStructuresConfigFiles(filesToCopy_ToPluginFolder_with_config_files, subDirectory);
            tSInstallFiles.CopyFilesTo_EnvCommonExtensionDirectory(filesToCopy_commonExtensionDirectory);
            tSInstallFiles.CopyFilesTo_USAImperialSystemDirectory(filesToCopy_USAImperialSystemDirectory);
            tSInstallFiles.CopyFilesTo_USAMetricSystemDirectory(filesToCopy_USAMetricSystemDirectory);
            tSInstallFiles.CopyFilesTo_EnvCommonInpDirectory(filesToCopy_commonInpDirectory);
            tSInstallFiles.CopyTeklaStructuresConfigFilesToCommonExtensionDirectory(filesToCopy_commonExtensionDirectory);

            tSInstallFiles.CopyFilesTo_TSPluginDirectory_Specific(filesToCopy_ToPluginFolder_specific, subDirectory);
            tSInstallFiles.CopyTeklaStructuresConfigFiles_Specific(filesToCopy_ToPluginFolder_specific, subDirectory);

            try
            {
                tSInstallFiles.DeleteFilesFrom_TSPluginDirectory(toRemoveDuringInstallation, subDirectory);
            }
            catch { }

            base.Install(stateSaver);
        }

        public override void Uninstall(IDictionary savedState)
        {
            CloseTeklaMessage();

            //During MSI Installation user can change the desitnation folder.
            //We have to get this folder and then correct our local pathes to full pathes. 
            //The TargetDir attribute stores can be usedfor this. 

            //In MSI project add to custom actions atributes:  /TargetDir="[TARGETDIR]\"
            var targetDir = Context.Parameters["TargetDir"].ToString();  
            CorrectFilePathes(targetDir);

            tSInstallFiles.DeleteFilesFrom_EnvBmpDirectory(filesToCopy_ToBitmapFolder);
            tSInstallFiles.DeleteFilesFrom_EnvCommonSystemDirectory(filesToCopy_ToCommonSystemFolder);
            tSInstallFiles.DeleteFilesFrom_TSPluginDirectory(filesToCopy_ToPluginFolder_with_config_files, subDirectory);
            tSInstallFiles.DeleteFilesFrom_TSPluginDirectory(filesToCopy_ToPluginFolder, subDirectory);
            tSInstallFiles.DeleteConfigFiles(filesToCopy_ToPluginFolder_with_config_files, subDirectory);
            tSInstallFiles.DeleteFilesFrom_EnvCommonExtensionDirectory(filesToCopy_commonExtensionDirectory);
            tSInstallFiles.DeleteFilesFrom_USAImperialSystemDirectory(filesToCopy_USAImperialSystemDirectory);
            tSInstallFiles.DeleteFilesFrom_USAMetricSystemDirectory(filesToCopy_USAMetricSystemDirectory);
            tSInstallFiles.DeleteFilesFrom_EnvCommonInpDirectory(filesToCopy_commonInpDirectory);
            tSInstallFiles.DeleteConfigFiles(filesToCopy_commonExtensionDirectory, "");

            tSInstallFiles.DeleteFilesFrom_TSPluginDirectory_Specific(filesToCopy_ToPluginFolder_specific, subDirectory);

            base.Uninstall(savedState);
        }
    }
}
