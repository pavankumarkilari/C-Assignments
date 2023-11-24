using System;

namespace BasicCSharpAssignment
{
    public class VariablesAndUserInput
    {
        // Task 2
        public void UserInput()
        {
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($" Hello, {Name}");
        }

    }
}
