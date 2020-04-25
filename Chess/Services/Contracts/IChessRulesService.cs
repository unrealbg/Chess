using Chess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Services.Contracts
{
    public interface IChessRulesService
    {
        bool Check(Square[,] board, ChessFigure from, ChessFigure to);

        bool Check(Square[,] board, Pawn from, ChessFigure to);

        bool Check(Square[,] board, Knight from, ChessFigure to);
    }
}
