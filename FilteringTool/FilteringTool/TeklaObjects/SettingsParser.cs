/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.Collections.Generic;
using System.Text;

namespace FilteringTool.TeklaObjects
{
    public class SettingsParser
    {
        public static List<ModelObjectRepotProperty> Parse(string inputText, out string outputText)
        {
            var returnList = new List<ModelObjectRepotProperty>();
            if (inputText == null)
            {
                outputText = "";
                return returnList;
            }

            var outputStringBuilder = new StringBuilder(inputText.Length);
            var chars = inputText.ToCharArray();
            var propertyOpened = false;
            var currentPropertyStringBuilder = new StringBuilder(30);
            var propertyIndex = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                var ch = chars[i];

                if (ch.Equals('%') & propertyOpened == false)
                {
                    propertyOpened = true;
                }
                else if (ch.Equals('%') & propertyOpened == true)
                {
                    propertyOpened = false;
                    returnList.Add(new ModelObjectRepotProperty() { Name = currentPropertyStringBuilder.ToString() });
                    currentPropertyStringBuilder.Clear();
                    outputStringBuilder.Append("{" + propertyIndex + "}");
                    propertyIndex++;
                }
                else if (propertyOpened == true)
                {
                    currentPropertyStringBuilder.Append(ch);
                }
                else
                {
                    outputStringBuilder.Append(ch);
                }

            }

            outputText = outputStringBuilder.ToString();
            return returnList;
        }
    }
}
