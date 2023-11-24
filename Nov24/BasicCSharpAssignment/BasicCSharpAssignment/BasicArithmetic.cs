using System;

namespace BasicCSharpAssignment
{
    public class BasicArithmetic
    {
        public void ArithmeticOperations()
        {
            Console.Write("Enter a number: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*------------------Arithmetic Operations Result------------------*");
            Console.WriteLine($"Addition of two numbers is: {NumberOne + NumberTwo}");
            Console.WriteLine($"Subtraction of two numbers is: {NumberOne - NumberTwo}");
            Console.WriteLine($"Multiplication of two numbers is: {NumberOne * NumberTwo}");
            Console.WriteLine($"Division of two numbers is: {NumberOne / NumberTwo}");
            Console.WriteLine($"Modulus of two numbers is: {NumberOne % NumberTwo}");
        }
    }
}
