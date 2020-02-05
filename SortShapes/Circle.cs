using System;
using System.Collections.Generic;
using System.Text;

namespace SortShapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Wrong circle radius: " + radius);
            }

            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (radius * radius);
        }
    }
}
