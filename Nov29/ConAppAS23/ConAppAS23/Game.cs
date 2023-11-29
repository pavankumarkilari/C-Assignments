using System;
using System.Collections.Generic;

namespace ConAppAS23
{
    public class Game
    {
        int PlayerCount, EnergyLevel = 1, WinningProbability = 100;
        string[] PlayerNames;
        List<int> EnergyList = new List<int>();
        List<int> ProbabilityList = new List<int>();
        public void Players()
        {
            Console.Write("Enter number of players: ");
            PlayerCount = Convert.ToInt32(Console.ReadLine());

            PlayerNames = new string[PlayerCount];
            
            for (int i = 0; i < PlayerCount; i++)
            {
                Console.Write($"You are Player {i+1}: \nEnter your name: ");
                PlayerNames[i] =  Console.ReadLine();
            }
            Spins();
        }
        public void Spins()
        {
            for (int i = 1;i < 6; i++)
            {
                for (int j = 0; j< PlayerCount; j++)
                {
                    Console.Write($"Hi, {PlayerNames[j]}! This is your Spin {i}.\nEnter your lucky number between 1 to 10: ");
                    int LuckyNumber = Convert.ToInt32(Console.ReadLine());
                    Score(LuckyNumber);
                    EnergyList.Insert(j,  EnergyLevel);
                    ProbabilityList.Insert(j, WinningProbability);
                }
            }
            CheckWinner();
        }

        public void Score(int Input)
        {
            switch(Input)
            {
                case 1:
                    EnergyLevel += 1;
                    WinningProbability += 10;
                    break;
                case 2:
                    EnergyLevel += 2;
                    WinningProbability += 20;
                    break;
                case 3:
                    EnergyLevel -= 3;
                    WinningProbability -= 30;
                    break;
                case 4:
                    EnergyLevel += 4;
                    WinningProbability += 40;
                    break;
                case 5:
                    EnergyLevel += 5;
                    WinningProbability += 50;
                    break;
                case 6:
                    EnergyLevel -= 1;
                    WinningProbability -= 60;
                    break;
                case 7:
                    EnergyLevel += 1;
                    WinningProbability += 70;
                    break;
                case 8:
                    EnergyLevel -=2;
                    WinningProbability -= 20;
                    break;
                case 9:
                    EnergyLevel -= 3;
                    WinningProbability -= 30;
                    break;
                case 10:
                    EnergyLevel += 10;
                    WinningProbability += 100;
                    break;
                default:
                    Console.WriteLine("Error! Please enter a number from 1 to 10");
                    break;
            }
        }

        public void CheckWinner()
        {
            for (int i=0; i<PlayerCount; i++)
            {
                if (EnergyList[i] >= 4 && ProbabilityList[i] > 60)
                {
                    Console.WriteLine($"Congratulations {PlayerNames[i]}!!! You are the winner.");
                }
                else if (EnergyList[i] >=1 && ProbabilityList[i] > 50)
                {
                    Console.WriteLine($"Well done {PlayerNames[i]}!!! You are the runner up.");
                }
                else
                {
                    Console.WriteLine(EnergyList[i] + "," + ProbabilityList[i]);
                    Console.WriteLine($"Sorry {PlayerNames[i]}!!! You lose the game.");
                }
            }
        }
    }
}
