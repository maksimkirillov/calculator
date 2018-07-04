using NUnit.Framework;

namespace Calculator.Test
{
    class AdditionTest
    {
        [TestFixture]
        public class additionTest
        {
            [Test]
            public void AdditionTest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("addition");
                double result = calculator.Calculator(5, 5);
                Assert.AreEqual(10, result);
            }
        }
    }
}
