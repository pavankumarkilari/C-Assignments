using System;

namespace ShapeAreaLib
{
    public class Rectangle
    {
        public void Area()
        {
            Console.WriteLine("Enter length: ");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth: ");
            int Breadth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area of the rectangle is {Length * Breadth}");
        }
    }
}
