using System;

namespace Chess.Models
{
    public class Square : BasePositionModel
    {
        public Square(int row, int col, string color, ChessFigure figure)
        {
            this.Row = row;
            this.Col = col;
            this.Color = color;
            this.Figure = figure;
        }

        public string Color { get; set; }

        public ChessFigure Figure { get; set; }
    }
}
