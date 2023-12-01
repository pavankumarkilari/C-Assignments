using System;
using GamingLibrary;

namespace Gaming
{
    public class Sports
    {
        public void chooseSports()
        {
            TraditionalSports traditionalSports = new TraditionalSports();
            ElectronicSports electronicSports = new ElectronicSports();
            Console.WriteLine("Do you want to play outdoor or indoor ?\n1. Outdoor, \n2. Indoor");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Here are some of the Traditional sports.");
                    traditionalSports.TSports();
                    break;
                case 2:
                    Console.WriteLine("Here are some of the Electronic sports.");
                    electronicSports.ESports();
                    break;
                default:
                    Console.WriteLine("Error! Please enter a valid option.");
                    break;
            }
        }
    }
}
