using System;
namespace Task_4
{
    public class Square:Shape
    {

        public double SideLenghth { get; set; }

        public override double Area() => Math.Pow(SideLenghth, 2);

        public override double Perimeter() => SideLenghth * 4;
  
    }
}

