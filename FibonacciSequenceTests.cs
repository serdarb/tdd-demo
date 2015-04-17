using System.Collections.Generic;
using NUnit.Framework;

namespace tdd_demo
{
    [TestFixture]
    public class FibonacciSequenceTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Fibonacci_GetValue_Returns_Value(int value)
        {
            //arrange
            var assertionValues = new Dictionary<int, int> { { 0, 0 }, { 1, 1 }, { 2, 1 }, { 3, 2 }, { 4, 3 }, { 5, 5 } };
            var fibonacci = new Fibonacci();

            //act
            var result = fibonacci.GetValue(value);

            //assert
            Assert.AreEqual(assertionValues[value], result);
        }
    }


    /// <summary>
    /// f[0] is 0
    /// f[1] is 1
    /// f[n] is (f[n-1]) + f[n-2])
    /// 
    /// for more info; http://en.wikipedia.org/wiki/Fibonacci_number
    /// </summary>
    class Fibonacci
    {
        public int GetValue(int i)
        {
            if (i == 0) { return 0; }
            if (i == 1) { return 1; }

            return GetValue(i - 1) + GetValue(i - 2);
        }
    }
}