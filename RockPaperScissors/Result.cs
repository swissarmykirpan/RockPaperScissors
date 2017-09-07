namespace RockPaperScissors
{
    public class Result
    {
        public string WinnerId { get; private set; }
        public Moves WinnerMove { get; private set; }
        public string LoserId { get; private set; }

        public Moves LoserMove { get; private set; }

        public Result(string winnerId, Moves winnerMove, string loserId, Moves loserMove)
        {
            WinnerId = winnerId;
            WinnerMove = winnerMove;
            LoserId = loserId;
            LoserMove = loserMove;
        }
    }
}
