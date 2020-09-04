using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class ArbitraryFigure : IArea
    {
        double[] Sides;
        int NumberOfSides;

        public ArbitraryFigure(params double[] MassiveSide)
        {
            this.NumberOfSides = MassiveSide.Length;
            Sides = MassiveSide;
        }

        public double Area()
        {
            return 0;
        }
    }
}
