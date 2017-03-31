using System;
using System.Collections.Generic;

namespace Cranberries.Util
{
    public class MockedTestExamples<E> : TestExamples
    {
        private bool TwiceFlag { get; set; }
        private bool PlusFlag { get; set; }
        private Dictionary<(E,E),E> mockupCase;

        public MockedTestExamples()
            => (TwiceFlag, PlusFlag, mockupCase) = (false, false, new Dictionary<(E, E), E>());

        public void CaseSetup(E a, E b, E r)
            => mockupCase.Add((a,b),r);

        public override T Plus<T>(T a, T b)
        {
            PlusFlag = true;
            return default(T);
        }

        public override T Twice<T>(T a)
        {
            TwiceFlag = true;
            return default(T);
        }

        public override T TwiceAdd<T>(T a, T b)
        {
            Plus(Twice(a), Twice(b));

            var x = (E)((Object)a);
            var y = ConvertTo<E>.Accept(b);

            return ConvertTo<T>.Accept(mockupCase[(x, y)]);
        }

        public bool VerifyAll
        {
            get
            {
                return PlusFlag && TwiceFlag;
            }
        }
    }
}