using Chess.Common;
using Chess.Models;
using Chess.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Automation;

namespace Chess.Services
{
    public class BoardGeneratorService : IBoardGeneratorService
    {
        public Square[,] Generate()
        {
            Square[,] board = new Square[Constans.BoardRows, Constans.BoardCols];

            for (int row = 0; row < Constans.BoardRows; row++)
            {
                for (int col = 0; col < Constans.BoardCols; col++)
                {
                    Square square = null;
                    ChessFigure figure = GetFigure(row, col);
                    //figure.Image = @"E:\Repos\Chess\Chess\Images\WhitePawn.png";

                    if ((row + col) % 2 == 0)
                    {
                        square = new Square(row, col, "white", figure);
                    }
                    else
                    {
                        square = new Square(row, col, "black", figure);
                    }

                    board[row, col] = square;
                }
            }

            return board;
        }

        //TODO: Figure Images
        private ChessFigure GetFigure(int row, int col)
        {
            ChessFigure figure = new Empty(row, col);

            if (row == 0)
            {
                if (col == 1 || col == 6)
                {
                    figure = new Knight(row, col, "black", @"E:\Repos\Chess\Chess\Images\BlackKnight.png");
                }

                if (col == 3)
                {
                    figure = new Queen(row, col, "black", @"E:\Repos\Chess\Chess\Images\BlackQueen.png");
                }
            }

            if (row == 7)
            {
                if (col == 1 || col == 6)
                {
                    figure = new Knight(row, col, "white", @"E:\Repos\Chess\Chess\Images\WhiteKnight.png");
                }

                if (col == 3)
                {
                    figure = new Queen(row, col, "white", @"E:\Repos\Chess\Chess\Images\WhiteQueen.png");
                }
            }

            if (row == 1)
            {
                figure = new Pawn(row, col, "black", @"E:\Repos\Chess\Chess\Images\BlackPawn.png");
            }

            if (row == 6)
            {
                figure = new Pawn(row, col, "white", @"E:\Repos\Chess\Chess\Images\WhitePawn.png");
            }

            return figure;
        }
    }
}
