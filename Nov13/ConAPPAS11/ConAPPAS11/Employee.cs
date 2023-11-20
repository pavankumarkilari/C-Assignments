using System;

namespace ConAppAS11
{
    public class Employee
    {
        public void HR()
        {
            int projectHandles = 1, extras = 0;
            Console.Write("Enter working hours: ");
            int wHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of working days:");
            int wDays = Convert.ToInt32(Console.ReadLine());
            int salary = wHour * wDays * 100 + projectHandles * 3000 + extras * 2000;
            Console.WriteLine($"Salary of the HR is {salary}");
        }
        public void Admin()
        {
            int extras = 0;
            Console.Write("Enter working hours: ");
            int wHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of working days:");
            int wDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of project handles:");
            int projectHandles = Convert.ToInt32(Console.ReadLine());
            int salary = wHour * wDays * 100 + projectHandles * 3000 + extras * 2000;
            Console.WriteLine($"Salary of the Admin is {salary}");
        }

        public void SoftwareDeveloper()
        {
            Console.Write("Enter working hours: ");
            int wHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of working days:");
            int wDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of project handles:");
            int projectHandles = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter extras: ");
            int extras = Convert.ToInt32(Console.ReadLine());
            int salary = wHour * wDays * 100 + projectHandles * 3000 + extras * 2000;
            Console.WriteLine($"Salary of the Software Developer is {salary}");
        }
    }
}
