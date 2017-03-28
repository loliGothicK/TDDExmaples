using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cranberries.Util;


namespace UnitTestProject1
{
    public static class ATest
    {
        public static int Method(int a)
            => B.Method(a);
    }


    [TestClass]
    public class StubDriverTest
    {
        [TestMethod]
        public void StubDriverTestMethod()
        {
            Assert.AreEqual(20,ATest.Method(10));
        }
    }
}
