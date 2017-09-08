namespace RockPaperScissors.Players
{
    public class TacticalComputer : RandomComputer
    {
        public TacticalComputer(): base(nameof(TacticalComputer))
        {

        }

        public override Moves Play(Moves[] rangeOfMoves = null)
        {
            var move = LastMove.HasValue 
                ? base.Play(LastMove.Value.DefeatedBy())
                : base.Play(rangeOfMoves);


            LastMove = move;

            return move;
        }

        internal Moves? LastMove;
    }
}
