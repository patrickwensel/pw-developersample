using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            else
                return number * GetFactorial(number - 1);

        }

        public static string FormatSeparators(params string[] items)
        {
            return $"{string.Join(", ", items.Take(items.Length - 1))} and {items.Last()}";
        }
    }
}