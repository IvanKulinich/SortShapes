using System;
using System.Collections.Generic;
using System.Text;

namespace SortShapes
{
    class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Wrong square side: " + side);
            }

            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}
