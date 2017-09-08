using System;
using System.Linq;

namespace RockPaperScissors.Players
{
    public class Human : Player
    {
        public Human(string name) : base(name)
        {

        }

        public override Moves Play(Moves[] rangeOfMoves = null)
        {
            Console.Write($"{Name}, please enter a move (${string.Join(" ", Enum.GetValues(typeof(Moves)).Cast<Moves>().Select(x => x.ToString()))}): ");
            return (Moves)Enum.Parse(typeof(Moves), Console.ReadLine());
            Console.WriteLine();
        }
    }
}
