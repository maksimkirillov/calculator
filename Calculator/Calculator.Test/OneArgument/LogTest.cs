using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{

        [TestFixture]
        public class Log
        {
            [TestCase(76, 4.330)]
            [TestCase(12, 0.670)]
            [TestCase(19, 0.306)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Calculator.OneArgument.Log();
                var actualResult = calculator.Calculator(firstValue);
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result, 0.001);
            }
            [Test]
            public void log10exeptiontest()
            {
                ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Log10");
                Assert.Throws<Exception>(() => calculator.Calculator(-187));
            }
        }
    
}
