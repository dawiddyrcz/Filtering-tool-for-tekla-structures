/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using Tekla.Structures.Model;

namespace FilteringTool.TeklaObjects
{
    internal class TeklaObject
    {
        public static string GetInfo(ModelObject selectedObject)
        {
            var info = "";
            if (selectedObject is Part)
            {
                info = GetModelObjectInfo(selectedObject, FTSettings.Settings.ObjectInfoPart);
            }
            else if (selectedObject is BoltGroup)
            {
                info = GetModelObjectInfo(selectedObject, FTSettings.Settings.ObjectInfoBolt);
            }
            else if (selectedObject is Assembly)
            {
                info = GetModelObjectInfo(selectedObject, FTSettings.Settings.ObjectInfoAssembly);
            }
            else if (selectedObject is Reinforcement)
            {
                info = GetModelObjectInfo(selectedObject, FTSettings.Settings.ObjectInfoRebar);
            }

            return info.Replace("\n", "");
        }
        
        private static string GetModelObjectInfo(ModelObject modelObject, string settingsText)
        {
            var modelObjectReportProperties = SettingsParser.Parse(settingsText, out string outputText);
            var propertyValues = new string[modelObjectReportProperties.Count];

            for (int i = 0; i < modelObjectReportProperties.Count; i++)
            {
                propertyValues[i] = modelObjectReportProperties[i].GetValueInString(modelObject);
            }

            return string.Format(outputText, propertyValues);
        }
    }
}
