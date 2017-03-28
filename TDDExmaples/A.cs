using System;

namespace Cranberries.Util
{
    public class A
    {
        public static int Method(int a)
        {
            // Not implemented
            var result = B.Method(a);
            throw new NotImplementedException();
        }
    }
}