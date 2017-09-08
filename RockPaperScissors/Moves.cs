using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors
{
    public enum Moves
    {
        Rock,
        Paper,
        Scissors,
        Lizard,
        Spock
    }

    public static class MovesExtensions
    {
        public static bool Defeats(this Moves move, Moves otherMove) =>
            Rules.Exists(r => r.WinningMove == move && r.LosingMove == otherMove);

        public static Moves[] DefeatedBy(this Moves move) =>
            Rules
                .Where(r => r.LosingMove == move)
                .Select(r => r.WinningMove)
                .ToArray();

        static List<(Moves WinningMove, Moves LosingMove)> Rules => new List<(Moves WinningMove, Moves LosingMove)>
        {
            (Moves.Scissors, Moves.Paper),
            (Moves.Paper, Moves.Rock),
            (Moves.Rock, Moves.Lizard),
            (Moves.Lizard, Moves.Spock),
            (Moves.Spock, Moves.Scissors),
            (Moves.Scissors, Moves.Lizard),
            (Moves.Lizard, Moves.Paper),
            (Moves.Paper, Moves.Spock),
            (Moves.Spock, Moves.Rock),
            (Moves.Rock, Moves.Scissors)
        };
    }
}
