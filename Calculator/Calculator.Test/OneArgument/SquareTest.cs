
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    class SquareTest
    {
        [TestFixture]
        public class square
        {
            [TestCase(9, 81)]
            [TestCase(3, 9)]
            [TestCase(5, 25)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Square();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result);
            }
        }
    }
}
