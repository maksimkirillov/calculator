
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{

        [TestFixture]
        public class Square
        {
            [TestCase(9, 81)]
            [TestCase(3, 9)]
            [TestCase(5, 25)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Calculator.OneArgument.Square();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result);
            }
        }
    
}
