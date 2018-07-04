
using NUnit.Framework;

namespace Calculator.Test
{
    class CubeTest
    {
        [TestFixture]
        public class cube
        {
            [TestCase(3, 27)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cube();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(27, actualResult);
            }
        }
    }
}
