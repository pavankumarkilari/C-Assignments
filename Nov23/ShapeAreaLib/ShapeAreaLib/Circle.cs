using System;

namespace ShapeAreaLib
{
    public class Circle
    {
        public void Area()
        {
            Console.WriteLine("Enter radius of the circle: ");
            int Radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area of the Square is {3.14 * Radius * Radius}");
        }
    }
}
