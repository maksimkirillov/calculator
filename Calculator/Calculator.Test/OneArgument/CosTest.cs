
using NUnit.Framework;

namespace Calculator.Test
{
    class CosTest
    {
        [TestFixture]
        public class cos
        {
            [TestCase(14, 0.136)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Cos();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(0.136, actualResult,0.001);
            }
        }
    }
}
