/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using NUnit.Framework;
using System;

namespace FilteringToolTests.TeklaObjects
{
    public class StringFormatTest
    {
        [Test]
        public void TestStringFormat()
        {
            var texts = new string[]
            {
                "text1",
                "text2",
                "text3"
            };

            string textWithBraces = "To jest {0} a po nim {1} a jeszce po nim {2}";
            string outputString = string.Format(textWithBraces, texts);
            Console.WriteLine(outputString);
            Assert.IsTrue(outputString.Equals("To jest text1 a po nim text2 a jeszce po nim text3"));
        }
    }
}
