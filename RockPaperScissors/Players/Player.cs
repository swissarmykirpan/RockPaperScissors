using RockPaperScissors.Players;
using System;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string Id { get; private set; }

        protected Player(string name)
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
            NoOfWins = 0;
        }
        public abstract Moves Play(Moves[] rangeOfMoves = null);

        public string Name { get; private set; }

        public int NoOfWins { get; private set; }

        public void IncrementWinCount() => NoOfWins++;

        public static Player CreatePlayer()
        {
            Console.Write("Please select the type of Player (0 = Human, 1 = Random Computer, 2 = Tactical Computer): ");
            var playerType = int.Parse(Console.ReadLine());

            if (playerType == 0)
            {
                Console.Write("Please enter your name: ");
                return new Human(Console.ReadLine());
            }

            if (playerType == 1)
                return new RandomComputer();

            return new TacticalComputer();
        }
    }

    public static class PlayerExtensions
    {
        public static (Player Winner, Player Loser) OrderByWinner(this Player player1, Player player2)
        {
            if (player1.NoOfWins > player2.NoOfWins)
                return (player1, player2);

            return (player2, player1);
        } 
    }

}
