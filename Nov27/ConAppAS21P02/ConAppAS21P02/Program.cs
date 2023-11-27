using System;

namespace ConAppAS21P02
{
    internal class Program
    {
        public delegate T Operation<T>(T num1, T num2);
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an arithemetic operation to perform: \n1. Addition, \n2. Substraction, \n3. Multiplication \n4. division");
            int Choice = Convert.ToInt32(Console.ReadLine());

            Operation<int> perform = null;

            switch (Choice)
            {
                case 1:
                    perform = Calculation<int>.Add;
                    Console.Write($"Result after adding {Number1} and {Number2} = ");
                    break;
                case 2:
                    perform = Calculation<int>.Subtract;
                    Console.Write($"Result after subtracting {Number1} from {Number2} = ");
                    break;
                case 3:
                    perform = Calculation<int>.Multiply;
                    Console.Write($"Result after multiplying {Number1} and {Number2} = ");
                    break;
                case 4:
                    perform = Calculation<int>.Divide;
                    Console.Write($"Result after dividing {Number1} by {Number2} = ");
                    break;
                default:
                    Console.WriteLine("Error! Please enter a valid option.");
                    break;
            }
            Console.WriteLine(perform(Number1, Number2));
            Console.ReadKey();

        }
    }
}
