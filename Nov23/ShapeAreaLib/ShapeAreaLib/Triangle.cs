using System;


namespace ShapeAreaLib
{
    public class Triangle
    {
        public void Area()
        {
            Console.WriteLine("Enter base: ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int Height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area of the rectangle is {0.5 * Base * Height}");
        }
    }
}
