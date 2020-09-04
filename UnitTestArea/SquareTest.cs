using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureArea;

namespace UnitTestArea
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void CorrectAreatest()
        {
            double width = 4;
            double height = 3;
            Square square = new Square(width, height);
            double expected = 12;

            double answer = square.Area();

            Assert.AreEqual(expected, answer);
        }
    }
}
