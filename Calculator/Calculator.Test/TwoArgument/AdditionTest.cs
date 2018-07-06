using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{

        [TestFixture]
        public class AdditionTest
        {
            [TestCase(0, 7, 7)]
            [TestCase(3, 4, 7)]
            [TestCase(6, 1, 7)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Addition();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(7, actualResult);
            }

        }
    
}

