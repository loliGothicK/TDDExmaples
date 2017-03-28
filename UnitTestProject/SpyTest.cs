using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    public class SpiedTest<E> : Cranberries.Util.TestExamples
    {
        private E sypiedValue;

        public E SypiedValue { get => sypiedValue; }

        public E DoSomething(E a) {
            var multi = Cranberries.Util.Operator<E>.Multiply;
            a = multi(a, a);
            sypiedValue = a;
            return base.DoSmoething(a);
        }
    }
    [TestClass]
    public class SpyTest
    {
        [TestMethod]
        public void SpyTestMethod()
        {
            var t = new SpiedTest<int>();
            var r1 = t.DoSomething(2);
            Assert.AreEqual(4, t.SypiedValue);
            var r2 = t.DoSomething(3);
            Assert.AreEqual(9, t.SypiedValue);

        }
    }
}
