using System;

namespace ConAppAS04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Implementing the decision-making constructs to perform the given tasks
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Utilizing the conditional operator to determine whether the number is even or odd

            string evenOddCheck = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"The number is {evenOddCheck}.");
        }
    }
}
