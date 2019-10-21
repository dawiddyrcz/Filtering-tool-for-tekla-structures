/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using NUnit.Framework;
using System;

namespace FilteringTool.TeklaObjects.Tests
{
    public class SomeTests
    {
        [Test]
        public void MyTestMethod()
        {
            var someDate = new DateTime(2019, 04, 16, 22, 00, 00);
            var someDate2 = new DateTime(2019, 04, 16, 22, 00, 10);

            var newDate = (someDate - someDate2).Duration();

            Assert.IsFalse(newDate > new TimeSpan(0, 1, 0));
            Assert.IsFalse(newDate > new TimeSpan(0, 0, 10));
            Assert.IsTrue(newDate > new TimeSpan(0, 0, 9));
        }
    }
}
