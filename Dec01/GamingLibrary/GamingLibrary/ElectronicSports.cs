using System;

namespace GamingLibrary
{
    public class ElectronicSports
    {
        public void ESports()
        {
            Console.WriteLine("Which game do you want to play? \n1. BGMI, \n2. Free fire, \n3. Call of duty, \n4. Fortnite, \n5. Mech arena");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("4 Players needed per team.");
                    break;
                case 2:
                    Console.WriteLine("4 Players needed per team.");
                    break;
                case 3:
                    Console.WriteLine("2 Players needed per team.");
                    break;
                case 4:
                    Console.WriteLine("2 Players needed per team.");
                    break;
                case 5:
                    Console.WriteLine("Single Player needed to play.");
                    break;
                default:
                    Console.WriteLine("Error! Please choose an valid sport.");
                    break;
            }
        }
    }
}
