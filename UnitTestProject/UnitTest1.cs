using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cranberries.Util;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("NO", TestExamples.IsLeap(1001));
            Assert.AreEqual("YES", TestExamples.IsLeap(2012));
            Assert.AreEqual("NO", TestExamples.IsLeap(2100));
            Assert.AreEqual("YES", TestExamples.IsLeap(2000));
        }
    }
}
