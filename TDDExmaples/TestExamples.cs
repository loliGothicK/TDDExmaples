using System;
using static Cranberries.External;

namespace Cranberries.Util
{
    public class TestExamples
    {
        public static String IsLeap(int years)
            => years % 400 == 0 ? "YES" :
               years % 100 == 0 ? "NO" :
               years % 4 == 0 ? "YES" :
               /* else */         "NO";

        public virtual T DoSmoething<T>(T a)
        {
            return ExternalMethod(a);
        }

        public static int Hoge(int a)
        {
            return 10;
        }

        public virtual T Plus<T>(T a, T b)
        {
            throw new NotImplementedException();
        }

        public virtual T Twice<T>(T a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  モックしたい関数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a*2 + b*2</returns>
        public virtual T TwiceAdd<T>(T a, T b)
        {
            return Plus(Twice(a), Twice(b));
        }
    }
}