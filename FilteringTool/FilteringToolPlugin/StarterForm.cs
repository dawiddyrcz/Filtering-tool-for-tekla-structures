using System;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace FilteringToolN
{
    public partial class StarterForm :  Tekla.Structures.Dialog.PluginFormBase
    {
        private readonly string _appName = "FilteringTool.exe";
        private readonly string _tsepDirName = "DDBIMFilteringTool";
        private readonly string _appDirectory = Path.Combine("plugins", "Tekla", "Model", "DDBIMFilteringTool");

        private static readonly BackgroundWorker backgroundWorker = new BackgroundWorker();
        public StarterForm()
        {
            InitializeComponent();
            this.Shown += DummyForm_Shown;

            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            backgroundWorker.RunWorkerCompleted -= BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.DoWork -= BackgroundWorker_DoWork;

            base.OnClosing(e);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            var processName = Path.GetFileNameWithoutExtension(_appName);
            var processes = System.Diagnostics.Process.GetProcessesByName(processName);

            if (processes.Length == 0)
            {
                var appFullPath = GetApplicationExePath();
                System.Diagnostics.Process.Start(appFullPath);

                Tekla.Structures.Model.Operations.Operation.DisplayPrompt(
                    DateTime.Now.ToString("HH:mm:ss.fff") + " Trying to start application: " + appFullPath);
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void DummyForm_Shown(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy == false)
                backgroundWorker.RunWorkerAsync();
        }

        private string GetApplicationExePath()
        {
            string appFileFullPath = "";

            string XS_Variable = System.Environment.GetEnvironmentVariable("XSDATADIR");
            string extensionDirectory = Path.Combine(XS_Variable, "Environments", "common", "extensions");

            if (!string.IsNullOrWhiteSpace(XS_Variable))
                appFileFullPath = Path.Combine(extensionDirectory, _tsepDirName, _appName);

            if (File.Exists(appFileFullPath)) return appFileFullPath;

            var teklaBinDir = System.Environment.GetEnvironmentVariable("XSBIN");
            if (!string.IsNullOrWhiteSpace(teklaBinDir))
                appFileFullPath = Path.Combine(teklaBinDir, _appDirectory, _appName);

            if (File.Exists(appFileFullPath)) 
                return appFileFullPath;


            var assemblyFile = System.Reflection.Assembly.GetExecutingAssembly().Location; // sometimes returns string empty
            if (!string.IsNullOrWhiteSpace(assemblyFile))
                appFileFullPath = Path.Combine(Path.GetDirectoryName(assemblyFile), _appName);

            if (File.Exists(appFileFullPath)) 
                return appFileFullPath;

            throw new Exception($"Could not find {_appName} file");
        }


        private void CloseAllProcesses()
        {
            var processName = Path.GetFileNameWithoutExtension(_appName);
            var processes = System.Diagnostics.Process.GetProcessesByName(processName);

            if (processes != null)
            {
                foreach (var process in processes)
                {
                    process.Kill();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DummyForm_Shown(this, new EventArgs());
        }
    }
}
