using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Cranberries.Util;

namespace UnitTestProject1
{

    [TestClass]
    public class MockTest
    {

        [TestMethod]
        public void HandMockTestMethod()
        {
            var mocked = new MockedTestExamples<int>();
            mocked.CaseSetup(1,2,6);
            Assert.AreEqual(6,mocked.TwiceAdd(1, 2));
            mocked.CaseSetup(2, 3, 10);
            Assert.AreEqual(10, mocked.TwiceAdd(2, 3));
            Assert.IsTrue(mocked.VerifyAll);
        }


        [TestMethod]
        public void MoqTestMethod()
        {
            //TestExamplesクラスのモックを作成
            Mock<TestExamples> mock = new Mock<TestExamples>();

            //Addメソッドが1と2で呼ばれたら「6」を返す設定
            mock.Setup(m => m.TwiceAdd(1, 2)).Returns(6);
            //Addメソッドが2と3で呼ばれたら「10」を返す設定
            mock.Setup(m => m.TwiceAdd(2, 3)).Returns(10);

            //モックが正しく動くか確認
            TestExamples c = mock.Object;
            Assert.AreEqual(6, c.TwiceAdd(1, 2));
            Assert.AreEqual(10, c.TwiceAdd(2, 3));
            //設定していない場合は0
            Assert.AreEqual(0, c.TwiceAdd(3, 4));

            //モックの振る舞いが呼び出されたかを確認
            mock.VerifyAll();
        }
    }
}
