
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
        [TestFixture]
        public class Cos
        {
            [TestCase(14, 0.136)]
            [TestCase(1, 8.414)]
            [TestCase(3, 0.141)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Calculator.OneArgument.Cos();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result,0.001);
            }
        }
}
