using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test
{
    class SinTest
    {
        [TestFixture]
        public class sin
        {
            [TestCase(5,-0.95)]
            [TestCase(25,25)]
            [TestCase(0,0)]
            public void CalculateTest(double firstValue, double expected)
            {
                var calculator = new Sin();
                var actualResult = calculator.Calculator(firstValue);
                Assert.AreEqual(0, actualResult,0.01);
            }
        }
    }
}
