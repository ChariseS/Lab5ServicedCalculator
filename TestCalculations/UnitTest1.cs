using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.CalculatorSoapClient calcRef;
        [TestMethod]
        public void TestAdd()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        }

        [TestMethod]
        public void TestSubtract()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Subtract(2.0, 2.0);
            Assert.AreEqual(0.0, d);
        }

        [TestMethod]
        public void TestMultiply()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Multiply(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        }

        [TestMethod]
        public void TestDivide()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            var quotient = calcRef.Divide(1.0, 1.0);
            Assert.AreEqual(1, quotient);
        }
    }
}
