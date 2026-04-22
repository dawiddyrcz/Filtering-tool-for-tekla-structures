using System;
using System.Diagnostics;

namespace FilteringTool
{
    internal static class ModelSettings
    {
        private static bool? teklaIsConnected;
        private static bool? designMode;

        private static bool teklaVersionHasValue = false;
        private static Version teklaVersion = new Version();

        public static Version TeklaVersion
        {
            get
            {
                if (ModelNotConnectedOrDesignMode()) //TO avoid exceptions in test projects and windows forms designer
                    return new Version(9999, 0, 0);

                if (!teklaVersionHasValue)
                {
                    teklaVersion = GetTeklaVersion();
                    teklaVersionHasValue = true;
                }

                return teklaVersion;
            }
        }

        private static string teklaVersionBeautifullInfo = null;
        public static string TeklaVersionBeautifullInfo
        {
            get
            {
                if (ModelNotConnectedOrDesignMode()) //TO avoid exceptions in test projects and windows forms designer
                    return new Version(9999, 0, 0).ToString();

                if (teklaVersionBeautifullInfo is null)
                {
                    teklaVersionBeautifullInfo = Tekla.Structures.TeklaStructuresInfo.GetCurrentProgramVersion();
                }

                return teklaVersionBeautifullInfo;
            }
        }

        public static System.Version GetTeklaVersion()
        {
            var binPath = "";
            Tekla.Structures.TeklaStructuresSettings.GetAdvancedOption("XSBIN", ref binPath);
            var pathToExe = System.IO.Path.Combine(binPath, "TeklaStructures.exe");
            var versionInfo = FileVersionInfo.GetVersionInfo(pathToExe);
            string versionTxt = versionInfo.FileVersion;
            versionTxt = versionTxt.Replace(",", ".");

            if (Version.TryParse(versionTxt, out Version version))
            {
                return version;
            }

            return new System.Version();
        }
        public static bool ModelNotConnectedOrDesignMode()
        {
            if (designMode is null)
            {
                designMode = System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
            }

            if (designMode.Value)
                return true;

            if (teklaIsConnected is null)
            {
                teklaIsConnected = new Tekla.Structures.Model.Model().GetConnectionStatus();
            }

            if (!teklaIsConnected.Value)
                return true;

            return false;
        }

    }
}
