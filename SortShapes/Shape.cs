using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortShapes
{
    abstract class Shape: IComparable<Shape>
    {
        public abstract double Area();

        public int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}
