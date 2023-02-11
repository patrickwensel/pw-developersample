using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Theory()]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void CanGetFactorial(int number, int factorial)
        {
            Assert.Equal(factorial, Algorithms.GetFactorial(number));
        }

        [Theory()]
        [InlineData(new string[] { "a", "b", "c" }, "a, b and c")]
        [InlineData(new string[] { "1", "2", "3" }, "1, 2 and 3")]
        [InlineData(new string[] { "u", "me", "our" }, "u, me and our")]
        public void CanFormatSeparators(string[] items, string formattedString)
        {
            Assert.Equal(formattedString, Algorithms.FormatSeparators(items));
        }
    }
}