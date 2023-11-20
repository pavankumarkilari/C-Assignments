using System;

namespace ASDATE09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            //string name = "Pavan Kumar";
            //int age = 22;
            //int height = 135;
            //Console.WriteLine($"Hi, {name}! You are {age} years old. Your height is {height}cms.");

            // Part 2
            // for loop
            //Console.WriteLine("First 10 natural numbers:");
            //Console.ForegroundColor = ConsoleColor.Green;
            //for(int i=1;i<11;i++)
            //{
            //    Console.WriteLine("\t\t\t "+i);
            //}
            //Console.ForegroundColor = ConsoleColor.White;

            // while loop
            //int number = 2;
            //Console.WriteLine("First 10 even natural numbers:");
            //Console.ForegroundColor = ConsoleColor.Green;
            //while (number < 21)
            //{
            //    Console.WriteLine("\t\t\t\t" + number);
            //    number += 2;
            //}
            //Console.ForegroundColor= ConsoleColor.White;

            // do-while
            //int oddNumber = 1;
            //Console.WriteLine("First 10 odd natural numbers:");
            //Console.ForegroundColor = ConsoleColor.Green;
            //do
            //{
            //    Console.WriteLine("\t\t\t\t" + oddNumber);
            //    oddNumber += 2;
            //} while (oddNumber < 20);
            //Console.ForegroundColor= ConsoleColor.White;

            // Part 3
            //int firstInSequence = 0;
            //int secondInSequence = 1;
            //int nextInSequence = 1;
            //Console.WriteLine("First 10 numbers in Fibanocci sequence");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write($"{firstInSequence}, {secondInSequence}");
            //for(int i=0; i<8;i++)
            //{
            //    Console.Write(", " + nextInSequence);
            //    firstInSequence = secondInSequence;
            //    secondInSequence = nextInSequence;
            //    nextInSequence = firstInSequence + secondInSequence;
            //}
            //Console.WriteLine();

            //Part 4
            //int[] arr = { 1, 4, 3, 7, 9 };
            // finding sum and average using for loop
            //int sum = 0;
            //foreach (var i in arr)
            //{
            //    sum += i;
            //}
            //decimal average = (decimal)sum / arr.Length;
            //Console.WriteLine($"The sum of elements in array = {sum}");
            //Console.WriteLine($"The average of elements in array = {average}");

            // using LINQ to find the sum and average
            //Console.WriteLine($"The sum of elements in array = {arr.Sum()}");
            //Console.WriteLine($"The average of elements in array = {arr.Average()}");

            // Part 5
            Console.Write("Enter your percentage: ");
            int percentage = Convert.ToInt32(Console.ReadLine());

            if (percentage >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is F");
            }
        }
    }
}