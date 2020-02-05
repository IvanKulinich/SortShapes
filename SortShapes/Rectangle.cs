using System;
using System.Collections.Generic;
using System.Text;

namespace SortShapes
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Wrong rectangle width: " + width);
            }

            if (height <= 0)
            {
                throw new ArgumentException("Wrong rectangle height: " + height);
            }

            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
