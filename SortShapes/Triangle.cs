using System;
using System.Collections.Generic;
using System.Text;

namespace SortShapes
{
    class Triangle : Shape
    {
        private double side;
        private double height;

        public Triangle(double side, double height)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Wrong triangle side: " + side);
            }

            if (height <= 0)
            {
                throw new ArgumentException("Wrong triangle height: " + height);
            }

            this.side = side;
            this.height = height;
        }

        public override double Area()
        {
            return (side * height) / 2;
        }
    }
}
