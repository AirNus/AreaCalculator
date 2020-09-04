using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Square : IArea
    {
        double LeftSide;
        double TopSide;
        double RightSide;
        double BottomSide;

        public double Area()
        {
            return LeftSide * BottomSide;
        }

        public Square(double LeftSide,double TopSide, double RightSide, double BottomSide)
        {
            this.LeftSide = LeftSide;
            this.TopSide = TopSide;
            this.RightSide = RightSide;
            this.BottomSide = BottomSide;
        }

        public Square(double Width, double Height)
        {
            this.LeftSide = this.RightSide = Height;
            this.TopSide = this.BottomSide = Width;
        }
    }
}
