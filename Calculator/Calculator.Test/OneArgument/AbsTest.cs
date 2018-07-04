
using NUnit.Framework;

namespace Calculator.Test
{
    class AbsTest
    {
        [TestFixture]
        public class abs
        {
            [TestCase(-5, 5)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Abs();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(5, actualResult);
            }
        }
    }
}
