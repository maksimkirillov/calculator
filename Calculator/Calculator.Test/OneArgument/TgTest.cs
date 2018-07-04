
using NUnit.Framework;

namespace Calculator.Test
{
    class TgTest
    {
        [TestFixture]
        public class tg
        {
            [TestCase(0, 0)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Tg();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(0, actualResult);
            }
        }
    }
}
