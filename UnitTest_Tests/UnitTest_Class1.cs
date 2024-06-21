using System;
using UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Tests
{
    [TestClass]
    public class UnitTest_Class1
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator calc = new Calculator();
            double result = calc.Add(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            Calculator calc = new Calculator();
            double result = calc.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            Calculator calc = new Calculator();
            double result = calc.Multiply(10, 20);
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            Calculator calc = new Calculator();
            double result = calc.Divide(20, 10);
            Assert.AreEqual(2, result);
        }
        
        [TestMethod]
        public void TestAddx2()
        {
            double result = Program.Addx2(1.2, 2.3, 3.4, 4.5);
            Assert.AreEqual(11.4, result);
        }

        [TestMethod]
        public void TestSubtractx2()
        {
            double result = Program.Subtractx2(1, 2, 3, 4);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMultiplyx2()
        {
            double result = Program.Multiplyx2(1, 2, 3, 4);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void TestDividex2()
        {
            double result = Program.Dividex2(1, 2, 3, 4);
            Assert.AreEqual(0.6666666666666666, result);
        }
    }
}