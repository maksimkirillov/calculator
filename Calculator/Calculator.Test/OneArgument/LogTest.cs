using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class LogTest
    {
        [TestFixture]
        public class log
        {
            [TestCase(76, 4.330)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Log();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(4.330, actualResult, 0.001);
            }
            [Test]
            public void log10exeptiontest()
            {
                ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Log10");
                Assert.Throws<Exception>(() => calculator.Calculator(-187));
            }
        }
    }
}
