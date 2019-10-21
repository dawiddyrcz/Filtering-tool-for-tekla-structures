/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using NUnit.Framework;

namespace FilteringTool.TeklaObjects.Tests
{
    public class SettingsParserTests
    {
        [Test]
        public void CorrectText()
        {
            var shouldReturnProps = new string[]
            {
                "WEIGHT",
                "NAME",
                "TOP_LEVEL"
            };

            string textToParse = "Weight: %WEIGHT% / Name: %NAME% Top level: %TOP_LEVEL%";
            var modObjReportProperties = SettingsParser.Parse(textToParse, out string outputString);

            Console.WriteLine("OutputString " + outputString);
            Assert.IsTrue(outputString.Equals("Weight: {0} / Name: {1} Top level: {2}"), "Output strings are not equal");

            Console.WriteLine("Mod props count: " + modObjReportProperties.Count);
            Assert.IsTrue(shouldReturnProps.Length == modObjReportProperties.Count, "Props count are different");

            var propsAreEqual = true;
            for (int i = 0; i < modObjReportProperties.Count; i++)
            {
                Console.WriteLine("Property " + i + " value: " + modObjReportProperties[i].Name);
                propsAreEqual = propsAreEqual & modObjReportProperties[i].Name.Equals(shouldReturnProps[i]);
            }

            Assert.IsTrue(propsAreEqual, "Props are not equals");
        }

        [Test]
        public void UserMistake_WithoutCharInTheEnd()
        {
            var shouldReturnProps = new string[]
            {
                "WEIGHT",
                "NAME",
            };

            string textToParse = "Weight: %WEIGHT% / Name: %NAME% Top level: %TOP_LEVEL";
            var modObjReportProperties = SettingsParser.Parse(textToParse, out string outputString);

            Console.WriteLine("OutputString " + outputString);
            Assert.IsTrue(outputString.Equals("Weight: {0} / Name: {1} Top level: "), "Output strings are not equal");

            Console.WriteLine("Mod props count: " + modObjReportProperties.Count);
            Assert.IsTrue(shouldReturnProps.Length == modObjReportProperties.Count, "Props count are different");

            var propsAreEqual = true;
            for (int i = 0; i < modObjReportProperties.Count; i++)
            {
                Console.WriteLine("Property " + i + " value: " + modObjReportProperties[i].Name);
                propsAreEqual = propsAreEqual & modObjReportProperties[i].Name.Equals(shouldReturnProps[i]);
            }

            Assert.IsTrue(propsAreEqual, "Props are not equals");
        }

        [Test]
        public void UserMistake_DoublePercentChar()
        {
            var shouldReturnProps = new string[]
            {
                "",
                " / Name: ",
                " Top level: ",
            };

            string textToParse = "Weight: %%WEIGHT% / Name: %NAME% Top level: %TOP_LEVEL%";
            var modObjReportProperties = SettingsParser.Parse(textToParse, out string outputString);

            Console.WriteLine("OutputString " + outputString);
            Assert.IsTrue(outputString.Equals("Weight: {0}WEIGHT{1}NAME{2}TOP_LEVEL"), "Output strings are not equal");

            Console.WriteLine("Mod props count: " + modObjReportProperties.Count);
            Assert.IsTrue(shouldReturnProps.Length == modObjReportProperties.Count, "Props count are different");

            var propsAreEqual = true;
            for (int i = 0; i < modObjReportProperties.Count; i++)
            {
                Console.WriteLine("Property " + i + " value: " + modObjReportProperties[i].Name);
                propsAreEqual = propsAreEqual & modObjReportProperties[i].Name.Equals(shouldReturnProps[i]);
            }

            Assert.IsTrue(propsAreEqual, "Props are not equals");
        }

        [Test]
        public void WithoutPropertiesText()
        {
            var shouldReturnProps = new string[]
            {
            };

            string textToParse = "Weight:  / Name:  Top level: ";
            var modObjReportProperties = SettingsParser.Parse(textToParse, out string outputString);

            Console.WriteLine("OutputString " + outputString);
            Assert.IsTrue(outputString.Equals("Weight:  / Name:  Top level: "), "Output strings are not equal");

            Console.WriteLine("Mod props count: " + modObjReportProperties.Count);
            Assert.IsTrue(shouldReturnProps.Length == modObjReportProperties.Count, "Props count are different");

            var propsAreEqual = true;
            for (int i = 0; i < modObjReportProperties.Count; i++)
            {
                Console.WriteLine("Property " + i + " value: " + modObjReportProperties[i].Name);
                propsAreEqual = propsAreEqual & modObjReportProperties[i].Name.Equals(shouldReturnProps[i]);
            }

            Assert.IsTrue(propsAreEqual, "Props are not equals");
        }

        [Test]
        public void EmptyText()
        {
            var shouldReturnProps = new string[]
            {
            };

            string textToParse = "";
            var modObjReportProperties = SettingsParser.Parse(textToParse, out string outputString);

            Console.WriteLine("OutputString " + outputString);
            Assert.IsTrue(outputString.Equals(""), "Output strings are not equal");

            Console.WriteLine("Mod props count: " + modObjReportProperties.Count);
            Assert.IsTrue(shouldReturnProps.Length == modObjReportProperties.Count, "Props count are different");

            var propsAreEqual = true;
            for (int i = 0; i < modObjReportProperties.Count; i++)
            {
                Console.WriteLine("Property " + i + " value: " + modObjReportProperties[i].Name);
                propsAreEqual = propsAreEqual & modObjReportProperties[i].Name.Equals(shouldReturnProps[i]);
            }

            Assert.IsTrue(propsAreEqual, "Props are not equals");
        }

        [Test]
        public void NullText()
        {
            var shouldReturnProps = new string[]
            {
            };

            string textToParse = null;
            var modObjReportProperties = SettingsParser.Parse(textToParse, out string outputString);

            Console.WriteLine("OutputString " + outputString);
            Assert.IsTrue(outputString.Equals(""), "Output strings are not equal");

            Console.WriteLine("Mod props count: " + modObjReportProperties.Count);
            Assert.IsTrue(shouldReturnProps.Length == modObjReportProperties.Count, "Props count are different");

            var propsAreEqual = true;
            for (int i = 0; i < modObjReportProperties.Count; i++)
            {
                Console.WriteLine("Property " + i + " value: " + modObjReportProperties[i].Name);
                propsAreEqual = propsAreEqual & modObjReportProperties[i].Name.Equals(shouldReturnProps[i]);
            }

            Assert.IsTrue(propsAreEqual, "Props are not equals");
        }
    }
}