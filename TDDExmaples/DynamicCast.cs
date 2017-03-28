using System;

namespace Cranberries.Util
{
    public static class DynamicCast
    {
        public static To DefaultCast<To>(Object o)
            => o is To ? (To)o : default(To);

        public static To? NullableCast<To>(Object o) where To : struct
            => (o is To?) ? (To?)o : null;
    }
}