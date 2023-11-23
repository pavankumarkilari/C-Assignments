using System;

namespace ShapeAreaLib
{
    public class Square
    {
        public void Area()
        {
            Console.WriteLine("Enter length of side: ");
            int Side = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area of the Square is {Side * Side}");
        }
    }
}
