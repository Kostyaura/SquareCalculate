using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculate;
using System;

namespace TestProject
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestCircleCalc()
        {
            var circle = new Circle(1);

            Assert.AreEqual(3.141592653589793, circle.Square);
        }

        [TestMethod]
        public void TestTriangleCalc()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.Square);
        }

        [TestMethod]
        public void TestCircleRadiusNegativeNumber()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(true, triangle.TriangleRight());
        }
    }
}
