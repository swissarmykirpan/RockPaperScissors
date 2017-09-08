using System;
using System.Linq;

namespace RockPaperScissors.Players
{

    public class RandomComputer : Player
    {
        public RandomComputer() : this(nameof(RandomComputer))
        {

        }

        public RandomComputer(string name) : base(name)
        {

        }


        public override Moves Play(Moves[] rangeOfMoves = null)
        {
            var rnd = new Random();

            var enumValueRange = rangeOfMoves ?? Enum.GetValues(typeof(Moves)).Cast<Moves>();

            var move = rnd.Next((int)enumValueRange.Min(), (int)enumValueRange.Max());

            Console.Write($"{Name}, please enter a move (${string.Join(" ", Enum.GetValues(typeof(Moves)).Cast<Moves>().Select(x => x.ToString()))}): ");
            Console.Write($"{(Moves)move}");
            Console.WriteLine();

            return (Moves)move;
        }
    }
}
