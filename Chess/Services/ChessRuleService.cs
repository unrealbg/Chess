namespace Chess.Services
{
    using System;

    using Chess.Models;
    using Chess.Services.Contracts;

    //TODO: the rest of the rules
    class ChessRuleService : IChessRulesService
    {
        public bool Check(Square[,] board, ChessFigure from, ChessFigure to)
        {
            return false;
        }

        public bool Check(Square[,] board, Pawn from, ChessFigure to)
        {
            if (from.Color == "white")
            {
                if (from.Row - to.Row == 1)
                {
                    return true;
                }
            }
            else
            {
                if (to.Row - from.Row == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Check(Square[,] board, Knight from, ChessFigure to)
        {
            if (Math.Abs(from.Row - to.Row) == 2)
            {
                if (Math.Abs(from.Col - to.Col) == 1)
                {
                    return true;
                }
            }
            if (Math.Abs(from.Row - to.Row) == 1)
            {
                if (Math.Abs(from.Col - to.Col) == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
