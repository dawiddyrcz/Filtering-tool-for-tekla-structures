using System.IO;
using System.Linq;

namespace FilteringTool
{
    internal class TeklaMacroDirectory
    {
        /// <summary>Checks if directory from setting XS_​MACRO_​DIRECTORY exsists. 
        /// Macrobuilder use first directory so only first is checked</summary>
        /// <exception cref="Exceptions.FilteringToolTeklaSettingsException">When macro directory not exists</exception>
        public static void CheckIfExists()
        {
            string settingValue = "";
            Tekla.Structures.TeklaStructuresSettings.GetAdvancedOption("XS_MACRO_DIRECTORY", ref settingValue);

            if (settingValue.Contains(';'))
            {
                var splited = settingValue.Split(';');
                settingValue = splited[0];
            }

            if (Directory.Exists(settingValue).Equals(false))
                throw new Exceptions.FilteringToolTeklaSettingsException("Macro directory not exists. Some functions not work. " +
                    "Check   XS_MACRO_DIRECTORY   option. Directory:   " + settingValue + "   not exists");
        }
    }
}
