using System;
using static System.Math;

    namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void PrintShape(Shape shape)
            {
                Console.WriteLine($"Area: {shape.Area()} \t Perimeter: {shape.Perimeter()}" );
            }

            Square square1 = new Square {SideLenghth = 4 };

            Triangle triangle1 = new Triangle { side1 = 5, side2 = 10, side3 = 15 };

            Circle circle1 = new Circle { Radius = 13 };


            PrintShape(square1);
            PrintShape(triangle1);
            PrintShape(circle1);
        
        }
    }
}
