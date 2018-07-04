using System;
using NUnit.Framework;

namespace Calculator.Test
{
    class SqerTest
    {
        [TestFixture]
        public class sqrt
        {
            [TestCase(25, 5)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sqrt();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(5, actualResult);
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
