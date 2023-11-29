using System;

namespace ConAppAS23
{
    internal delegate void GameProbability();
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GameProbability GamePro = new GameProbability(game.Players);
            GamePro();
            Console.ReadKey();
        }
    }
}
