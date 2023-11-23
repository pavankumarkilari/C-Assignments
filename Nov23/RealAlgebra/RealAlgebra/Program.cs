using System;
using ShapeAreaLib;

namespace RealAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape to calculate its area: \n1. Rectangle\n2. Square\n3. Circle\n4. Triangle");
            int Choice = int.Parse(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    Rectangle rectangle = new Rectangle();
                    rectangle.Area();
                    break;
                case 2:
                    Square square = new Square();
                    square.Area();
                    break;
                case 3:
                    Circle circle = new Circle();
                    circle.Area();
                    break;
                case 4:
                    Triangle triangle = new Triangle();
                    triangle.Area();
                    break;
                default:
                    Console.WriteLine("Error! Enter a valid option.");
                    break;
                    
            }
        }
    }
}
