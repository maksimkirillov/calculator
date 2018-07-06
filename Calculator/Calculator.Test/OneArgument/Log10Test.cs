using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class Log10Test
    {
        [TestFixture]
        public class log10
        {
            [TestCase(2, 0.301)]
            [TestCase(12, 0.670)]
            [TestCase(19, 1.297)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Log10();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result, 0.001);
            }
            [Test]
            public void log10exeptiontest()
            {
                ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Log10");
                Assert.Throws<Exception>(() => calculator.Calculator(-7));
            }
        }
    }
}
