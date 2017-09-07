using System;

namespace RockPaperScissors.Players
{
    public class Human : Player
    {
        public Human(string name) : base(name)
        {

        }

        public override Moves Play()
        {
            Console.WriteLine($"{Name}, please enter your move: ");
            return (Moves)int.Parse(Console.ReadLine());
        }
    }
}
