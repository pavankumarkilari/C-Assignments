using System;

namespace ConAppAS11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose employee type to calculate the Salary: \n 1. HR\n 2. Admin\n 3. Software Developer");
            int employeeType = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee();
            switch (employeeType)
            {
                case 1:
                    employee.HR();
                    break;
                case 2:
                    employee.Admin();
                    break;
                case 3:
                    employee.SoftwareDeveloper();
                    break;
                default:
                    Console.WriteLine("Enter valid employee type!");
                    break;
            }
        }
    }
}
