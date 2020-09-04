using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Triangle : IArea
    {
        double LeftSide;
        double RightSide;
        double BottomSide;

        public Triangle(double LeftSide, double RightSide, double BottomSide)
        {
            this.LeftSide = LeftSide;
            this.RightSide = RightSide;
            this.BottomSide = BottomSide;
        }

        public  double Perimetr()
        {
            return LeftSide + RightSide + BottomSide;
        }
        
        public double Area()
        {
            double HalfPerimetr = Perimetr() / 2;
            return Math.Sqrt(HalfPerimetr * (HalfPerimetr - BottomSide) * (HalfPerimetr - RightSide) * (HalfPerimetr - LeftSide));
        }
    }
}
