using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class SubtractionTest
    {
        [TestFixture]
        public class subtractionTest
        {
            [TestCase(5, 5, 0)]
            [TestCase(25, 25, 25)]
            [TestCase(0, 0, 0)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new sabtraction();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(0, actualResult);
            }
        }
    }
}
