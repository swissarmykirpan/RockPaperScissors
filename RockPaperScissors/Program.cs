using RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors
{
    class Game
    {
        public int BestOf { get; private set; }

        public List<Result> Results { get; private set; }

        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public Game(int bestOf, params Player[] players)
        {
            BestOf = bestOf;
            Results = new List<Result>();
            Player1 = players[0];
            Player2 = players[1];
        }

        public bool IsComplete()
        {
            if (Results.Count() == 3) return true;
            return false;
        }

        public string GetScore()
        {
            var player1Wins = Results.Count(r => r.WinnerId == Player1.Id);

            var player2Wins = Results.Count(r => r.WinnerId == Player2.Id);

            if (player1Wins > player2Wins)
                return $"{Player1.Name} has defeated {Player2.Name} by {player1Wins} games to {player2Wins}";

            return $"{Player2.Name} has defeated {Player1.Name} by {player2Wins} games to {player1Wins}";
        }

        public void Play()
        {

            var play1 = Player1.Play();
            var play2 = Player2.Play();

            if (play1.Defeats(play2))
            {
                Console.WriteLine($"{Player1.Name} defeats {Player2.Name}!");

                Results.Add(new Result(Player1.Id, play1, Player2.Id, play2));
            }
            else if (play2.Defeats(play1))
            {
                Console.WriteLine($"{Player2.Name} defeats {Player1.Name}!");

                Results.Add(new Result(Player2.Id, play2, Player1.Id, play1));
            }
            else
            {
                Console.WriteLine("It's a Draw!");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to {string.Join(" ", Enum.GetValues(typeof(Moves)).Cast<Moves>().Select(x => x.ToString()))}");
            Console.WriteLine("This is a hand game usually played between two people, in which each player simultaneously forms shapes with an outstretched hand");

            var player1 = CreatePlayer();
            var player2 = CreatePlayer();

            Console.WriteLine("Please enter match length, best of (3, 5, 7....)");
            var gameLength = int.Parse(Console.ReadLine());

            var game1 = new Game(gameLength, player1, player2);

            while(!game1.IsComplete())
            {
                //game1.
                game1.Play();
            }

            Console.WriteLine(game1.GetScore());
            Console.WriteLine("Thank you for playing!");

            Console.ReadLine();
        }

        public static Player CreatePlayer()
        {
            Console.WriteLine("Please create the type of Player (0 = Human, 1 = Random Computer, 2 = Tactical Computer");
            var playerType = int.Parse(Console.ReadLine());
                
            if (playerType == 0)
            {
                Console.WriteLine("Please enter your name: ");
                return new Human(Console.ReadLine());
            }

            if (playerType == 1)
                return new RandomComputer();

            return new TacticalComputer();   
        }
    }
}
