using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class SqerTest
    {
        [TestFixture]
        public class sqrt
        {
            [TestCase(25, 5)]
            [TestCase(9, 3)]
            [TestCase(81, 9)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sqrt();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result);
            }
            [Test]
            public void sqrtexeptiontest()
            {
                ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Sqrt");
                Assert.Throws<Exception>(() => calculator.Calculator(-79));
            }
        }
    }
}
