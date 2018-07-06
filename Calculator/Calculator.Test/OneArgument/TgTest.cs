
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class TgTest
    {
        [TestFixture]
        public class tg
        {
            [TestCase(0, 0)]
            [TestCase(98, 0.699)]
            [TestCase(7, 0.871)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Tg();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result, 0.001);
            }
        }
    }
}
