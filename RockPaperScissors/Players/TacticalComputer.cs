using System;

namespace RockPaperScissors.Players
{
    public class TacticalComputer : Player
    {
        public TacticalComputer() : base(nameof(TacticalComputer) + new Random().Next(1, 10000))
        {

        }

        public override Moves Play()
        {
            Console.WriteLine("Enter move:");
            return (Moves)int.Parse(Console.ReadLine());
        }
    }
}
