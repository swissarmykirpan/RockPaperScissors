using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Create();

            while (!Game.IsComplete())
                Game.Play();

            Game.EndGame();
   
            Console.ReadLine();
        }
    }
}
