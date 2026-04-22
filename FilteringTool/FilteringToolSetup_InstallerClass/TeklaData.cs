using Microsoft.Win32;
using System.IO;

namespace FilteringToolSetup
{
    /// <summary>
    /// This class gets Tekla Structures information from registry
    /// </summary>
    internal class TeklaData
    {
        /// <summary>
        /// Gets Tekla Structures folders information from registry and save it in properties
        /// </summary>
        /// <param name="version">Version of Tekla Structures eg: "20.1", "21.0", "2016", "2017i"</param>
        /// <param name="tsVersionDir">Name of Tekla Structures instalation directory eg: "20.1", "21.0", "2016", "2017i"</param>
        /// <param name="regKey">Registry key (in HKLM) where data is stored eg: @"SOFTWARE\Tekla\Structures\2016\setup" </param>
        private TeklaData(string version, string tsVersionDir, string regKey, bool isNewTekla)
        {
            this.Version = version;
            this.tsVersionDir = tsVersionDir;
            this.regKey = regKey;
            this.IsNewTekla = isNewTekla;
            this.IsTeklaInstaled = false;

            GetDataFromRegistry();
            if (this.IsTeklaInstaled)
                SetOtherDirectories();
        }
        public bool IsNewTekla { get; internal set; }
        public string Version { get; internal set; }
        public bool IsTeklaInstaled { get; internal set; }

        private readonly string tsVersionDir;
        private readonly string regKey;
        public const string configFileName = "TeklaStructures.exe.config";

        //Registry values
        public string AppDir { get; internal set; }
        public string EnvDir { get; internal set; }
        public string EnvCommonExtensionDir { get; internal set; }
        public string EnvCommonInpDirectory { get; internal set; }
        public string HelpLocation { get; internal set; }
        public string ModelDir { get; internal set; }

        //Other values
        public string TSDirectory { get; internal set; }
        public string TSBinDirectory { get; internal set; }
        public string TSPluginDirectory { get; internal set; }
        public string EnvCommonSystemDirectory { get; internal set; }
        public string EnvBmpDirectory { get; internal set; }
        public string TSConfigFileFullPath { get; internal set; }

        public string USAImperialSystemDirectory { get; internal set; }
        public string USAMetricSystemDirectory { get; internal set; }


        private void GetDataFromRegistry()
        {
            RegistryKey localKey32 =
                 RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine,
                     RegistryView.Registry32);
            localKey32 = localKey32.OpenSubKey(this.regKey);

            if (localKey32 != null)
            {
                this.AppDir = string.Empty;
                this.AppDir = localKey32.GetValue("MainDir").ToString();
                this.EnvDir = string.Empty;
                this.EnvDir = localKey32.GetValue("EnvDir").ToString();
                this.HelpLocation = string.Empty;
                this.HelpLocation = localKey32.GetValue("HelpLocation").ToString();
                this.ModelDir = string.Empty;
                this.ModelDir = localKey32.GetValue("ModelDir").ToString();
                localKey32.Close();

                if (this.AppDir != string.Empty & this.EnvDir != string.Empty & this.HelpLocation != string.Empty & this.ModelDir != string.Empty)
                    this.IsTeklaInstaled = true;
                else
                    this.IsTeklaInstaled = false;
            }
            else
            {
                //If localkey 32 bit is null than check 64 bit
                RegistryKey localKey64 =
                    RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine,
                        RegistryView.Registry64);
                localKey64 = localKey64.OpenSubKey(this.regKey);

                if (localKey64 != null)
                {
                    this.AppDir = string.Empty;
                    this.AppDir = localKey64.GetValue("MainDir").ToString();
                    this.EnvDir = string.Empty;
                    this.EnvDir = localKey64.GetValue("EnvDir").ToString();
                    this.HelpLocation = string.Empty;
                    this.HelpLocation = localKey64.GetValue("HelpLocation").ToString();
                    this.ModelDir = string.Empty;
                    this.ModelDir = localKey64.GetValue("ModelDir").ToString();
                    localKey64.Close();

                    if (this.AppDir != string.Empty & this.EnvDir != string.Empty & this.HelpLocation != string.Empty & this.ModelDir != string.Empty)
                        this.IsTeklaInstaled = true;
                    else
                        this.IsTeklaInstaled = false;
                }
                else
                {
                    //No 32 bit and no 64 bit key
                    this.IsTeklaInstaled = false;
                }
            }

        }

        private void SetOtherDirectories()
        {
            this.TSDirectory = Path.Combine(this.AppDir, this.tsVersionDir);
            this.TSBinDirectory = Path.Combine(this.TSDirectory, "nt", "bin");
            this.TSPluginDirectory = Path.Combine(this.TSBinDirectory, "plugins");
            this.EnvCommonSystemDirectory = Path.Combine(this.EnvDir, this.tsVersionDir, "Environments", "common", "system");
            this.EnvCommonInpDirectory = Path.Combine(this.EnvDir, this.tsVersionDir, "Environments", "common", "inp");
            this.EnvBmpDirectory = Path.Combine(this.EnvDir, this.tsVersionDir, "Bitmaps");

            this.TSConfigFileFullPath = Path.Combine(this.TSBinDirectory, configFileName);


            this.EnvCommonExtensionDir = Path.Combine(this.EnvDir, this.tsVersionDir, "Environments", "common", "extensions");
            this.USAImperialSystemDirectory = Path.Combine(this.EnvDir, this.tsVersionDir, "Environments", "usimp", "system");
            this.USAMetricSystemDirectory = Path.Combine(this.EnvDir, this.tsVersionDir, "Environments", "usmet", "system");
        }

        public static bool TryToGet(string version, out TeklaData newTSData)
        {
            newTSData = null;

            //Bellow you can add another TS version with its registry key
            //Version 17.0 dont have redirections in TeklaStructures.exe.config file so it will not working
            //Version 18.0 not confirmed
            //Version 2019, 2019i, 2020, 2020i added in 2018 year so not confirmed

            switch (version)
            {
                case "18.1":
                    {
                        newTSData = new TeklaData(version, "18.1", @"SOFTWARE\Tekla\Structures\18.1\setup", false);
                        break;
                    }
                case "19.0":
                    {
                        newTSData = new TeklaData(version, "19.0", @"SOFTWARE\Tekla\Structures\19.0\setup", false);
                        break;
                    }
                case "19.1":
                    {
                        newTSData = new TeklaData(version, "19.1", @"SOFTWARE\Tekla\Structures\19.1\setup", false);
                        break;
                    }
                case "20.0":
                    {
                        newTSData = new TeklaData(version, "20.0", @"SOFTWARE\Tekla\Structures\20.0\setup", false);
                        break;
                    }
                case "20.1":
                    {
                        newTSData = new TeklaData(version, "20.1", @"SOFTWARE\Tekla\Structures\20.1\setup", false);
                        break;
                    }
                case "21.0":
                    {
                        newTSData = new TeklaData(version, "21.0", @"SOFTWARE\Tekla\Structures\21.0\setup", false);
                        break;
                    }
                case "21.1":
                    {
                        newTSData = new TeklaData(version, "21.1", @"SOFTWARE\Tekla\Structures\21.1\setup", false);
                        break;
                    }
                case "2016":
                    {
                        newTSData = new TeklaData(version, "2016", @"SOFTWARE\Tekla\Structures\2016\setup", true);
                        break;
                    }
                case "2016i":
                    {
                        newTSData = new TeklaData(version, "2016i", @"SOFTWARE\Tekla\Structures\2016i\setup", true);
                        break;
                    }
                case "2017":
                    {
                        newTSData = new TeklaData(version, "2017", @"SOFTWARE\Tekla\Structures\2017\setup", true);
                        break;
                    }
                case "2017i":
                    {
                        newTSData = new TeklaData(version, "2017i", @"SOFTWARE\Tekla\Structures\2017i\setup", true);
                        break;
                    }
                case "2018":
                    {
                        newTSData = new TeklaData(version, "2018", @"SOFTWARE\Tekla\Structures\2018\setup", true);
                        break;
                    }
                case "2018i":
                    {
                        newTSData = new TeklaData(version, "2018i", @"SOFTWARE\Tekla\Structures\2018i\setup", true);
                        break;
                    }
                case "2019":
                    {
                        newTSData = new TeklaData(version, "2019.0", @"SOFTWARE\TRIMBLE\Tekla Structures\2019.0\setup", true);
                        break;
                    }
                case "2019i":
                    {
                        newTSData = new TeklaData(version, "2019.1", @"SOFTWARE\TRIMBLE\Tekla Structures\2019.1\setup", true);
                        break;
                    }
              
            }

            return newTSData != null;
        }
    }


}
