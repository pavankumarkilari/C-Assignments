using System;

namespace BasicCSharpAssignment
{
    public class ControlStructures
    {
        public void EvenOdd()
        {
            Console.Write("Enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            if(Number %2 == 0)
            {
                Console.WriteLine($"{Number} is a even number.");
            }
            else
            {
                Console.WriteLine($"{Number} is an odd number.");
            }
        }
    }
}
