using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class CosTest
    {
        [TestFixture]
        public class cos
        {
            [TestCase(1, 0.84)]
            [TestCase(5, 0.2836)]
            [TestCase(0, 1)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sin();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(0, actualResult,0.01);
            }
        }
    }
}
