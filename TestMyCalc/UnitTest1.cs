using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalc123;
using System;

namespace TestMyCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlus()
        {
            double a = 4.7;
            double b = 4.8;
            double result = a + b;

            Operations op = new Operations();

            double act = op.Plus(a, b);

            Assert.AreEqual(result, act+0.7, 0.1);
        }

        [TestMethod]
        public void TestMultiply()
        {
            double a = 4.7;
            double b = 4.8;
            double result = a * b;

            Operations op = new Operations();

            double act = op.Multiply(a, b);

            Assert.AreEqual(result, act);
        }

        [TestMethod]
        public void TestMinus()
        {
            double a = 4.7;
            double b = 4.8;
            double result = a - b;

            Operations op = new Operations();

            double act = op.Minus(a, b);

            Assert.AreEqual(result, act);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDiv()
        {
            double a = 4.7;
            double b = 0;
            double result = a / b;

            Operations op = new Operations();

            double act = op.Div(a, b);

            Assert.AreEqual(result, act);
        }
    }
}
