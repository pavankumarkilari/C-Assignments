using System;

namespace ConAppAS21P01
{
    internal class Program
    {
        public delegate int ArithmeticOperation(int num1, int num2);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an arithemetic operation to perform: \n1. Addition, \n2. Subtraction, \n3. Multiplication \n4. division");
            int Choice = Convert.ToInt32(Console.ReadLine());

            ArithmeticOperation Try = null;

            switch (Choice)
            {
                case 1:
                    Try = new ArithmeticOperation(Calculation.Add);
                    Console.Write($"Result after adding {Number1} and {Number2} = ");
                    break;
                case 2:
                    Try = new ArithmeticOperation(Calculation.Subtract);
                    Console.Write($"Result after subtracting {Number1} from {Number2} = ");
                    break;
                case 3:
                    Try = new ArithmeticOperation(Calculation.Multiply);
                    Console.Write($"Result after multiplying {Number1} and {Number2} = ");
                    break;
                case 4:
                    Try = new ArithmeticOperation(Calculation.Divide);
                    Console.Write($"Result after dividing {Number1} by {Number2} = ");
                    break;
                default:
                    Console.WriteLine("Error! Please enter a valid option.");
                    break;
            }
            Console.WriteLine(Try(Number1, Number2));
            Console.ReadKey();

        }
    }
}
