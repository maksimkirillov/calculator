using System;
using NUnit.Framework;

namespace Calculator.Test
{
    class Log10Test
    {
        [TestFixture]
        public class log10
        {
            [TestCase(2, 0.301)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Log10();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(0.301, actualResult,0.001);
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
