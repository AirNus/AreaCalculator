using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureArea;

namespace UnitTestArea
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CorrectAreaTest()
        {
            double LeftSide = 3;
            double RightSide = 4;
            double BottomSide = 5;
            Triangle triangle = new Triangle(LeftSide, RightSide, BottomSide);
            double expected = 6;

            double answer = triangle.Area();

            Assert.AreEqual(expected, answer);
        }
    }
}
