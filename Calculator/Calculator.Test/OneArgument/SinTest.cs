
using NUnit.Framework;

namespace Calculator.Test
{
    class SinTest
    {
        [TestFixture]
        public class sin
        {
            [TestCase(15, 0.650)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sin();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(0.650, actualResult,0.001);
            }
        }
    }
}
