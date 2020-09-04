using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Circle : IArea
    {
        const double PI = 3.14;

        double radius;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return radius * radius * PI;
        } 
    }
}
