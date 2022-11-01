using System;
namespace Task_4
{
    public class Triangle : Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
    

        public override double Area() => Math.Sqrt(((side1 + side2 + side3) / 2) * (((side1 + side2 + side3) / 2) - side1) * (((side1 + side2 + side3) / 2) - side2) * (((side1 + side2 + side3) / 2) - side3));

        public override double Perimeter() => side1 + side2 + side3;
       
    }
}

