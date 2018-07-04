using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class DivisionTest
    {
        [TestFixture]
        public class additionTest
        {
            [Test]
            public void AdditionTest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("division");
                double result = calculator.Calculator(25, 5);
                Assert.AreEqual(5, result);
            }
        }
    }
}
