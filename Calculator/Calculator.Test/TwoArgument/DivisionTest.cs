﻿
using NUnit.Framework;

namespace Calculator.Test
{
    class DivisionTest
    {
        [TestFixture]
        public class divisionTest
        {
            [TestCase(25, 5, 5)]
            [TestCase(50, 10, 5)]
            [TestCase(50, 10, 5)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new division();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(5, actualResult);
            }
        }
    }
}

