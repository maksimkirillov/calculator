
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{

        [TestFixture]
        public class Sin
        {
            [TestCase(15, 0.650)]
            [TestCase(1, 0.540)]
            [TestCase(6, 0.960)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Calculator.OneArgument.Sin();
                double result = calculator.Calculator(firstValue);
                Assert.AreEqual(expected, result, 0.001);
            }
        }
    
}
