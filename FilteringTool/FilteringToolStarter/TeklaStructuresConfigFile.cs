/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.IO;

namespace FilteringToolStarter
{
    class TeklaStructuresConfigFile
    {
        public void CorrectAndCopy(string inputConfilFile, string outputConfigFile)
        {
            File.Copy(inputConfilFile, outputConfigFile, true);
            ChangeTeklaStructuresConfigFileIfNescesary(outputConfigFile);
        }

        private void MakeBacup(string configFileFullName)
        {
            if (File.Exists(configFileFullName))
            {
                string configFileText = File.ReadAllText(configFileFullName);

                if (configFileText.Contains("-99.1.0.0"))
                {
                    var bakConfilFileFullName = Path.Combine(configFileFullName + ".bak");
                    if (!File.Exists(bakConfilFileFullName)) File.Copy(configFileFullName, bakConfilFileFullName, true);
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
                    configFileText = configFileText.Replace("-99.1.0.0", "-9999.1.0.0");
                    File.WriteAllText(configFileFullName, configFileText);
                }
            }
        }
    }
}
