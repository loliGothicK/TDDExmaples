using System;
using Cranberries.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    public class SpiedTest<E> : TestExamples
    {
        private E sypiedValue;

        public E SypiedValue { get => sypiedValue; }

        public override T DoSomething<T>(T a) {
            var multi = Operator<T>.Multiply;
            a = multi(a, a);
            sypiedValue = ConvertTo<E>.Accept(a);
            return base.DoSomething(a);
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
