
using System;
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
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new division();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(5, actualResult);
            }

            [Test]
            public void divisionexeptiontest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("division");
                Assert.Throws<Exception>(() => calculator.Calculator(5,0));
            }
        }
    }
}

