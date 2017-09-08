using RockPaperScissors.Players;
using System;
using System.Linq;

namespace RockPaperScissors
{
    public static class Game
    {
        static int MaxGameLength;
        static Player Player1;
        static Player Player2;

        public static void Create()
        {
            WelcomeMessage();
            SetMaximumGameLength();
            SetupPlayers();
        }

        static void SetupPlayers()
        {
            Player1 = Player.CreatePlayer();
            Player2 = Player.CreatePlayer();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine($"Welcome to {string.Join(" ", Enum.GetValues(typeof(Moves)).Cast<Moves>().Select(x => x.ToString()))}");
            Console.WriteLine("This is a hand game usually played between two people, in which each player simultaneously forms shapes with an outstretched hand");
        }

        static void SetMaximumGameLength()
        {
            Console.Write("Please enter match length, best of (3, 5, 7....): ");
            MaxGameLength = int.Parse(Console.ReadLine());
        }

        public static bool IsComplete() =>
            Math.Max(Player1.NoOfWins, Player2.NoOfWins) * 2 > MaxGameLength;

        public static void EndGame()
        {
            var winnerLoser = Player1.OrderByWinner(Player2);

            Console.WriteLine($"{winnerLoser.Winner.Name} has defeated {winnerLoser.Loser.Name} by {winnerLoser.Winner.NoOfWins} games to {winnerLoser.Loser.NoOfWins}");
        }

        public static void Play()
        {
            var player1Move = Player1.Play();
            var player2Move = Player2.Play();

            if (player1Move.Defeats(player2Move))
            {
                Console.WriteLine($"{Player1.Name} ({player1Move}) defeats {Player2.Name} ({player2Move}) !");

                Player1.IncrementWinCount();
            }
            else if (player2Move.Defeats(player1Move))
            {
                Console.WriteLine($"{Player2.Name} ({player2Move})  defeats {Player1.Name} ({player1Move}) !");

                Player2.IncrementWinCount();
            }
            else
            {
                Console.WriteLine("It's a Draw!");
            }
        }
    }
}
