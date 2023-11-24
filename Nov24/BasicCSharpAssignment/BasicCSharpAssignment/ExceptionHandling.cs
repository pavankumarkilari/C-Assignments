using System;

namespace BasicCSharpAssignment
{
    public class ExceptionHandling
    {
        public void UserAge()
        {
            Console.Write("Enter your age: ");
            string UserAge = Console.ReadLine();
            AgeCheck(UserAge);
        }
        public void AgeCheck(string AgeInput)
        {
            if (int.TryParse(AgeInput, out int Age))
            {
                if (Age<18)
                {
                    Console.WriteLine($"your age is {Age}. So, you are a minor.");
                }
                else if(Age>=18 && Age<65)
                {
                    Console.WriteLine($"your age is {Age}. So, you are an adult.");
                }
                else
                {
                    Console.WriteLine($"your age is {Age}. So, you are a senior.");
                }
            }
            else
            {
                Console.WriteLine("Error! Please enter a valid age.");
                UserAge();
            }
        }
    }
}
