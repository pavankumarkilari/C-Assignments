using System;

namespace GamingLibrary
{
    public class TraditionalSports
    {
        public void TSports()
        {
            Console.WriteLine("Which game do you want to play? \n1. Cricket, \n2. Football, \n3. Volleyball, \n4. Kho-Kho, \n5. Badminton");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("11 Players needed per team.");
                    break;
                case 2:
                    Console.WriteLine("11 Players needed per team.");
                    break;
                case 3:
                    Console.WriteLine("6 Players needed per team.");
                    break;
                case 4:
                    Console.WriteLine("11 Players needed per team.");
                    break;
                case 5:
                    Console.WriteLine("2 Players needed per team.");
                    break;
                default:
                    Console.WriteLine("Error! Please choose an valid sport.");
                    break;
            }
        }

    }
}
