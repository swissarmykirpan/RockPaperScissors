using System;
using System.Linq;

namespace RockPaperScissors.Players
{

    public class RandomComputer : Player
    {
        public RandomComputer() : base(nameof(RandomComputer) + new Random().Next(1, 10000))
        {

        }


        public override Moves Play()
        {
            var rnd = new Random();

            var move = rnd.Next(0, (int)Enum.GetValues(typeof(Moves)).Cast<Moves>().Max());

            Console.WriteLine($"{Name}, please enter your move: ");
            Console.WriteLine($"{(Moves)move}");

            return (Moves)move;
        }
    }
}
