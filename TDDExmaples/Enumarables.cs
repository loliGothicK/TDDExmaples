using System;
using System.Collections.Generic;

namespace Cranberries.Util
{
    public class Enumerables
    {
        public static IEnumerable<int> Random()
        {
            var engine = new Random();
            while (true) yield return engine.Next();
        }

        public static IEnumerable<int> Random(int maxVlaue)
        {
            var engine = new Random();
            while (true) yield return engine.Next(maxVlaue);
        }

        public static IEnumerable<int> Random(int minValue, int maxValue)
        {
            var engine = new Random();
            while (true) yield return engine.Next(minValue, maxValue);
        }

        public static IEnumerable<int> Random(Random engine)
        {
            while (true) yield return engine.Next();
        }

        public static IEnumerable<int> Random(Random engine, int maxValue)
        {
            while (true) yield return engine.Next(maxValue);
        }

        public static IEnumerable<int> Random(Random engine, int minValue, int maxValue)
        {
            while (true) yield return engine.Next(minValue, maxValue);
        }

        public static IEnumerable<double> GenerateCanonical()
        {
            var engine = new Random();
            while (true) yield return engine.NextDouble();
        }

    }
}
