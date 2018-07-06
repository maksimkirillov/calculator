
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{

        [TestFixture]
        public class MultyplicationTest
        {
            [TestCase(5, 5, 25)]
            [TestCase(25, 1, 25)]
            [TestCase(50, 0.5, 25)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Multyplication();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(25, actualResult);
            }
        }
    
}
