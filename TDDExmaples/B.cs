namespace Cranberries.Util
{
    public class B
    {
        public static int Method(int a)
        {
            var result = C.Method(a);
            result *= 2;
            return result;
        }
    }
}