
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class SinTest
    {
        [TestFixture]
        public class sin
        {
            [TestCase(15, 0.650)]
            [TestCase(1, 0.540)]
            [TestCase(6, 0.960)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sin();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result, 0.001);
            }
        }
    }
}
