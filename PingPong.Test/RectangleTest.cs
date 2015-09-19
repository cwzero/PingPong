using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong.Test
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        [TestCategory("Rectangle"), TestCategory("Perimeter")]
        public void rectanglePerimeterTest()
        {
            Rectangle rectangle = new Rectangle(10, 10);
            Assert.AreEqual(rectangle.getPerimeter(), 40);

            rectangle = new Rectangle(1, 4);
            Assert.AreEqual(rectangle.getPerimeter(), 10);
        }

        [TestMethod]
        [TestCategory("Rectangle"), TestCategory("Area")]
        public void rectangleAreaTest()
        {
            Rectangle rectangle = new Rectangle(10, 10);
            Assert.AreEqual(rectangle.getArea(), 100);

            rectangle = new Rectangle(1, 4);
            Assert.AreEqual(rectangle.getArea(), 4);
        }

        [TestMethod]
        [TestCategory("Rectangle"), TestCategory("Argument")]
        [ExpectedException(typeof(ArgumentException))]
        public void rectangleArgumentTest()
        {
            new Rectangle(-1, -1);
        }
    }
}
