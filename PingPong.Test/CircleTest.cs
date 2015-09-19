using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [TestCategory("Circle"), TestCategory("Perimeter")]
        public void circlePerimeterTest()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(circle.getPerimeter(), Math.PI * 20);

            circle = new Circle(3.5);
            Assert.AreEqual(circle.getPerimeter(), Math.PI * 7);
        }

        [TestMethod]
        [TestCategory("Circle"), TestCategory("Area")]
        public void circleAreaTest()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(circle.getArea(), Math.PI * 100);

            circle = new Circle(3.5);
            Assert.AreEqual(circle.getArea(), Math.PI * 3.5 * 3.5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("Circle"), TestCategory("Argument")]
        public void circleArgumentTest()
        {
            new Circle(-1);
        }
    }
}
