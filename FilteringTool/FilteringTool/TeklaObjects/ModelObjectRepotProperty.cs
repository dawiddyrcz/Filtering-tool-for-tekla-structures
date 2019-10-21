/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringTool.TeklaObjects
{
    public class ModelObjectRepotProperty
    {
        public string Name = "";
        public int DecimalsToRound = 1;

        public string GetValueInString(Tekla.Structures.Model.ModelObject modelObject)
        {
            string textValue = "abcdefghijkl";
            int intValue = 987654321;
            double doubleValue = 987654321.123456;

            bool b1 = modelObject.GetReportProperty(Name, ref textValue);
            bool b2 = modelObject.GetReportProperty(Name, ref intValue);
            bool b3 = modelObject.GetReportProperty(Name, ref doubleValue);

            if (intValue != 0 & intValue != 987654321)
                return intValue.ToString();

            if (doubleValue != 0.0 & doubleValue != 987654321.123456)
                return RoundDoubleValue(doubleValue).ToString();

            if (textValue.Equals("abcdefghijkl") == false)
                return textValue;

            return Name;
        }

        private double RoundDoubleValue(double value)
        {
            if (DecimalsToRound <= 0) return Math.Round(value);

            double ten = Math.Pow(10.0, DecimalsToRound);
            return Math.Round(value * ten) / ten;
        }
    }
}
