using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(3, calculator.Add(1.5, 1.5));
            Assert.AreEqual(1000, calculator.Add(150.25, 849.75));
            Assert.AreEqual(0, calculator.Add(10, -10));
            Assert.AreEqual(1, calculator.Add(0,1));
        }

        [TestMethod]
        public void Subtract_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(0, calculator.Subtract(1.5, 1.5));
            Assert.AreEqual(1000, calculator.Subtract(1500.25, 500.25));
            Assert.AreEqual(20, calculator.Subtract(10, -10));
            Assert.AreEqual(-1, calculator.Subtract(0, 1));
        }

        [TestMethod]
        public void Multiply_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(2.25, calculator.Multiply(1.5, 1.5));
            Assert.AreEqual(25, calculator.Multiply(5, 5));
            Assert.AreEqual(-100, calculator.Multiply(10, -10));
            Assert.AreEqual(0, calculator.Multiply(0, 1));
        }

        [TestMethod]
        public void Divide_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(1, calculator.Divide(1.5, 1.5));
            Assert.AreEqual(5, calculator.Divide(5, 1));
            Assert.AreEqual(-1, calculator.Divide(10, -10));
            Assert.AreEqual(10, calculator.Divide(-50, -5));
        }

        [TestMethod]
        public void Square_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(4, calculator.Square(-2));
            Assert.AreEqual(25, calculator.Square(5));
            Assert.AreEqual(110.25, calculator.Square(10.5));
            Assert.AreEqual(10000, calculator.Square(100));
        }

        [TestMethod]
        public void SquareRoot_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(5, calculator.Square_Root(25));
            Assert.AreEqual(10.5, calculator.Square_Root(110.25));
            Assert.AreEqual(4.25, calculator.Square_Root(18.0625));
            Assert.AreEqual(1, calculator.Square_Root(1));
            Assert.AreEqual(0, calculator.Square_Root(0));
        }

        [TestMethod]
        public void Cube_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(-125, calculator.Cube(-5));
            Assert.AreEqual(1000, calculator.Cube(10));
            Assert.AreEqual(3.375, calculator.Cube(1.5));
            Assert.AreEqual(1, calculator.Cube(1));
            Assert.AreEqual(0, calculator.Cube(0));
        }

        [TestMethod]
        public void CubeRoot_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(5, calculator.Cube_Root(125));
            Assert.AreEqual(-1, calculator.Cube_Root(-1));
            Assert.AreEqual(4.25, calculator.Cube_Root(76.765625));
            Assert.AreEqual(1, calculator.Cube_Root(1));
            Assert.AreEqual(0, calculator.Cube_Root(0));
        }

        [TestMethod]
        public void Sine_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(1, calculator.Sine((Math.PI) / 2.0));
            Assert.AreEqual(-1, calculator.Sine((3.0*Math.PI) / 2.0));
            Assert.AreEqual(0, calculator.Sine(0));
            Assert.AreEqual(0.5, calculator.Sine(Math.PI / 6.0));
            Assert.AreEqual(0, calculator.Sine(Math.PI));
        }

        [TestMethod]
        public void Cosine_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(0, calculator.Cosine((Math.PI) / 2.0));
            Assert.AreEqual(0, calculator.Cosine((3.0 * Math.PI) / 2.0));
            Assert.AreEqual(1, calculator.Cosine(0));
            Assert.AreEqual(0.5, calculator.Cosine(Math.PI / 3.0));
            Assert.AreEqual(-1, calculator.Cosine(Math.PI));
        }


        [TestMethod]
        public void ValidateInput_Function_Test()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(-1, calculator.ValidateInput_Function("three"));
            Assert.AreEqual(-1, calculator.ValidateInput_Function("87654"));
            Assert.AreEqual(11, calculator.ValidateInput_Function("11"));
            Assert.AreEqual(-1, calculator.ValidateInput_Function("0"));
            Assert.AreEqual(-1, calculator.ValidateInput_Function("1.5"));
        }
    }
}
