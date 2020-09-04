using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureArea;

namespace UnitTestArea
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CorrectAreaTest()
        {
            double radius = 3;
            Circle circle = new Circle(radius);
            double expected = 28.26;

            double answer = circle.Area();

            Assert.AreEqual(expected, System.Math.Round(answer,2));
        }
    }
}
