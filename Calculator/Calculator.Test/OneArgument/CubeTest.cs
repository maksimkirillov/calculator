
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{

        [TestFixture]
        public class Cube
        {
            [TestCase(3, 27)]
            [TestCase(2, 8)]
            [TestCase(1, 1)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Calculator.OneArgument.Cube();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result);
            }
        }
    
}
