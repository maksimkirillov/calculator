using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class SquareTest
    {
        [TestFixture]
        public class square
        {
            [TestCase(9, 81)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Square();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(81, actualResult);
            }
        }
    }
}
