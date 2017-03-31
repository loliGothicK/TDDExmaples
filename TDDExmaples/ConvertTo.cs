using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Cranberries.Util
{
    public static class ConvertTo<To>
    {
        public static To Accept<From>(From value)
            => value is To ? (To)(Object)value
                : value is IConvertible ? (To)Convert.ChangeType(value, typeof(To))
                : default(To);
    }
}