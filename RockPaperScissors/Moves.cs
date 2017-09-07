namespace RockPaperScissors
{
    public enum Moves
    {
        Rock,
        Paper,
        Scissors,
        //Lizard,
        //Spock
    }

    static class MovesExtensions
    {
        public static bool Defeats(this Moves move, Moves otherMove)
        {
            switch (move)
            {
                case Moves.Rock:
                    return otherMove == Moves.Scissors;
                case Moves.Scissors:
                    return otherMove == Moves.Paper;
                case Moves.Paper:
                    return otherMove == Moves.Rock;
            }

            return false;
        }
    }
}
