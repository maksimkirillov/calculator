
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class CosTest
    {
        [TestFixture]
        public class cos
        {
            [TestCase(14, 0.136)]
            [TestCase(1, 8.414)]
            [TestCase(3, 0.141)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cos();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result,0.001);
            }
        }
    }
}
