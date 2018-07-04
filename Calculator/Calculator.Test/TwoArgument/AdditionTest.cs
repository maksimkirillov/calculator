using NUnit.Framework;

namespace Calculator.Test
{
    class AdditionTest
    {
        [TestFixture]
        public class additionTest
        {
            [TestCase(0, 7, 7)]
            [TestCase(3, 4, 7)]
            [TestCase(6, 1, 7)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new addition();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(7, actualResult);
            }

        }
    }
}

