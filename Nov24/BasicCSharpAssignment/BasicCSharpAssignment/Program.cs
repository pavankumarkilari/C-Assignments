using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option to check the task:\n1. Hello World \n2. Variables and User Input " +
                "\n3. Basic Arithmetic \n4. Control Structures \n5. loops\n6. Arrays \n7. Methods \n8. Exception Handling");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    Console.WriteLine("Hello, World!");
                    break;
                case 2:
                    VariablesAndUserInput variablesAndUserInput = new VariablesAndUserInput();
                    variablesAndUserInput.UserInput();
                    break;
                case 3:
                    BasicArithmetic basicArithmetic = new BasicArithmetic();
                    basicArithmetic.ArithmeticOperations();
                    break;
                case 4:
                    ControlStructures controlStructures = new ControlStructures();
                    controlStructures.EvenOdd();
                    break;
                case 5:
                    Loops loops = new Loops();
                    loops.Iterate();
                    break;
                case 6:
                    Arrays arrays = new Arrays();
                    arrays.SumAverage();
                    break;
                case 7:
                    Methods methods = new Methods();
                    Console.Write("Enter a number: ");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Factorial of {Number} is {methods.CalculateFactorial(Number)}.");
                    break;
                case 8:
                    ExceptionHandling exceptionHandling = new ExceptionHandling();
                    exceptionHandling.UserAge();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }
            Console.ReadKey();
        }
    }
}


