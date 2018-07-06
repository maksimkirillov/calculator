
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class AbsTest
    {
        [TestFixture]
        public class abs
        {
            [TestCase(-5, 5)]
            [TestCase(-15, 15)]
            [TestCase(-55, 55)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Abs();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result);
            }
        }
    }
}
