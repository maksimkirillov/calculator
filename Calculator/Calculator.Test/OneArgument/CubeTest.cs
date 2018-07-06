
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class CubeTest
    {
        [TestFixture]
        public class cube
        {
            [TestCase(3, 27)]
            [TestCase(2, 8)]
            [TestCase(1, 1)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cube();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result);
            }
        }
    }
}
