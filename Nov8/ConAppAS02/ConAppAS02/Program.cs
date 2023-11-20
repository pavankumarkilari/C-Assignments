using System;

namespace ConAppAS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string eName = Console.ReadLine();

            Console.Write("Enter Employee Gender: ");
            string eGender = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            decimal eSalary = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter DOJ: ");
            DateTime eDoj = DateTime.Parse(Console.ReadLine());
            string formattedDoj = eDoj.ToString("dd/MM/yyyy");

            Console.WriteLine("ID\tEmployee Name\tEmployeeGender\tEmployee Salary\t\tDOJ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{eName}\t\t{eGender}\t\t{eSalary}\t\t\t{formattedDoj}");
        }
    }
}
