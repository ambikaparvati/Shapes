using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, ExpectedException(typeof(Exception))]
        public void ChoiceFail()
        {
            Shape circleArea = ShapesAreaCalculator.GetShape('a');
        }
        [TestMethod]
        public void NullArea()
        {
            Shape triangleArea = ShapesAreaCalculator.GetShape(3);
            triangleArea.CalculateArea(0, 0);
            Assert.AreEqual(0, triangleArea.area, "Correct Area");
        }
        [TestMethod]
        public void CircleArea()
        {
            Shape circleArea = ShapesAreaCalculator.GetShape(1);
            double radius = 1;
            circleArea.CalculateArea(radius);
            Assert.AreEqual(Math.PI * radius * radius, circleArea.area, "Correct Area");
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void CircleAreaParameterFail()
        {
            Shape circleArea = ShapesAreaCalculator.GetShape(1);
            circleArea.CalculateArea(1, 2);
            Assert.AreEqual(Math.PI * 1 * 1, circleArea.area, "Correct Area");
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void CircleAreaNegativeFail()
        {
            Shape circleArea = ShapesAreaCalculator.GetShape(1);
            circleArea.CalculateArea(-1);
            Assert.AreEqual(Math.PI * 1 * 1, circleArea.area, "Correct Area");
        }
        [TestMethod]
        public void RectangleArea()
        {
            Shape rectangleArea = ShapesAreaCalculator.GetShape(2);
            rectangleArea.CalculateArea(1, 2);
            Assert.AreEqual(1 * 2, rectangleArea.area, "Correct Area");
        }
        [TestMethod]
        public void RectangleAreaChoiceFail()
        {
            Shape rectangleArea = ShapesAreaCalculator.GetShape(3);
            rectangleArea.CalculateArea(1, 2);
            Assert.AreNotEqual(1 * 2, rectangleArea.area, "Correct Area");
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void RectangleAreaParameterFail()
        {
            Shape rectangleArea = ShapesAreaCalculator.GetShape(2);
            rectangleArea.CalculateArea(1);
            Assert.AreNotEqual(1 * 1, rectangleArea.area, "Correct Area");
        }
        [TestMethod]
        public void TriangleArea()
        {
            Shape triangleArea = ShapesAreaCalculator.GetShape(3);
            triangleArea.CalculateArea(2, 2);
            Assert.AreEqual(0.5 * 2 * 2, triangleArea.area, "Correct Area");
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void TriangleAreaParameterFail()
        {
            Shape triangleArea = ShapesAreaCalculator.GetShape(3);
            triangleArea.CalculateArea(2, 2, 2);
            Assert.AreEqual(0.5 * 2 * -2, triangleArea.area, "Correct Area");
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void TriangleAreaNegativeFail()
        {
            Shape triangleArea = ShapesAreaCalculator.GetShape(3);
            triangleArea.CalculateArea(2, -2);
            Assert.AreEqual(0.5 * 2 * -2, triangleArea.area, "Correct Area");
        }
    }
}
