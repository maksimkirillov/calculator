
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{

        [TestFixture]
        public class SubtractionTest
        {
            [TestCase(5, 5, 0)]
            [TestCase(25, 25, 25)]
            [TestCase(0, 0, 0)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Sabtraction();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(0, actualResult);
            }
        }
    
}
