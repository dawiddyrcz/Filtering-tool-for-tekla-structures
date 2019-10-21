/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.IO;
using System.Text;

namespace FilteringToolStarter
{
    public class FilteringToolTEMPDirectory
    {
        public string GetTempPath()
        {
            return Path.Combine(GetSystemTempPath(), Settings.TEMP_DIRECTORY_NAME);
        }

        public string GetVersionTempPath(TeklaFileVersion teklaFileVersion)
        {
            string teklaFileVersionString = GetStringFromTeklaFileVersion(teklaFileVersion);
            return Path.Combine(GetSystemTempPath(), Settings.TEMP_DIRECTORY_NAME, teklaFileVersionString);
        }

        private string GetSystemTempPath()
        {
            return Path.GetTempPath();
        }

        private string GetStringFromTeklaFileVersion(TeklaFileVersion teklaFileVersion)
        {
            var sb = new StringBuilder(100);
            sb.Append(teklaFileVersion.Major);
            sb.Append("_");
            sb.Append(teklaFileVersion.Minor);
            sb.Append("_");
            sb.Append(teklaFileVersion.Build);
            sb.Append("_");
            sb.Append(teklaFileVersion.Build2);
            return sb.ToString();
        }
    }
}
