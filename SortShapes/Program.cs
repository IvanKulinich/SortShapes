using System;
using System.Collections.Generic;

namespace SortShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double side = 1.1234D;
                double radius = 1.1234D;
                double triangleSide = 5D;
                double height = 2D;

                var shapes = new List<Shape>
                {
                    new Circle(radius),
                    new Square(side),
                    new Triangle(triangleSide, height)
                };

                Console.WriteLine("Before sort:");
                for (int i = 0; i < shapes.Count; i++)
                {
                    Console.WriteLine(shapes[i].Area());
                }

                shapes.Sort();

                Console.WriteLine("After sort:");
                for (int i = 0; i < shapes.Count; i++)
                {
                    Console.WriteLine(shapes[i].Area());
                }
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
