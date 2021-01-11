namespace Chess.Services
{
    using Chess.Common;
    using Chess.Models;
    using Chess.Services.Contracts;

    public class BoardGeneratorService : IBoardGeneratorService
    {
        public Square[,] Generate()
        {
            Square[,] board = new Square[Constans.BoardRows, Constans.BoardCols];

            for (int row = 0; row < Constans.BoardRows; row++)
            {
                for (int col = 0; col < Constans.BoardCols; col++)
                {
                    ChessFigure figure = GetFigure(row, col);

                    Square square = ((row + col) % 2) switch
                    {
                        0 => new Square(row, col, "white", figure),
                        _ => new Square(row, col, "black", figure),
                    };

                    board[row, col] = square;
                }
            }

            return board;
        }

        private ChessFigure GetFigure(int row, int col)
        {
            ChessFigure figure = new Empty(row, col);

            // Black Figures
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

                if (col == 2 || col == 5)
                {
                    figure = new Bishop(row, col, "black", @"E:\Repos\Chess\Chess\Images\BlackBishop.png");
                }

                if (col == 4)
                {
                    figure = new King(row, col, "black", @"E:\Repos\Chess\Chess\Images\BlackKing.png");
                }

                if (col == 0 || col == 7)
                {
                    figure = new Rook(row, col, "black", @"E:\Repos\Chess\Chess\Images\BlackRook.png");
                }
            }

            // White Figures
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

                if (col == 2 || col == 5)
                {
                    figure = new Bishop(row, col, "white", @"E:\Repos\Chess\Chess\Images\WhiteBishop.png");
                }

                if (col == 4)
                {
                    figure = new King(row, col, "white", @"E:\Repos\Chess\Chess\Images\WhiteKing.png");
                }

                if (col == 0 || col == 7)
                {
                    figure = new Rook(row, col, "white", @"E:\Repos\Chess\Chess\Images\WhiteRook.png");
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
