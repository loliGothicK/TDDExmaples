using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Cranberries.Util.TestExamples;

namespace UnitTestProject1
{
    [TestClass]
    public class DummyObjectTest
    {
        [TestMethod]
        public void DummyObjectTestMethod()
        {
            Assert.AreEqual(10, Hoge(0));
        }
    }
}
