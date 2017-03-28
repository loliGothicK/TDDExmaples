using System.Linq;
using static Cranberries.Util.TestExamples;
using Cranberries.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cranberries
{

    [TestClass]
    public class IsLeapTest1
    {
        
        [TestMethod]
        public void IsLeapTestMethod1()
        {
            Enumerable.Range(1, 10)
                .Select(e => e * 4)
                .ToList()
                .ForEach(e => { Assert.AreEqual("YES", IsLeap(e)); });

            Enumerable.Range(1, 3)
                .Select(e => e * 100)
                .ToList()
                .ForEach(e => { Assert.AreEqual("NO", IsLeap(e)); });

            Enumerable.Range(1, 10)
                .Select(e => e * 400)
                .ToList()
                .ForEach(e => { Assert.AreEqual("YES", IsLeap(e)); });

            Assert.AreEqual("NO", IsLeap(1));
            Assert.AreEqual("NO", IsLeap(101));
            Assert.AreEqual("NO", IsLeap(123));
            Assert.AreEqual("NO", IsLeap(2013));


            var engine = new System.Random();
            Enumerables.Random()
                .Take(100000)
                .ToList()
                .ForEach(
                e => {
                    if (e % 400 == 0) Assert.AreEqual("YES", IsLeap(e));
                    else if (e % 100 == 0) Assert.AreEqual("NO", IsLeap(e));
                    else if (e % 4 == 0) Assert.AreEqual("YES", IsLeap(e));
                    else Assert.AreEqual("NO", IsLeap(e));
                });
        }
    }
}
