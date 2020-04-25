using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class Queen : ChessFigure
    {
        public Queen(int row, int col, string color, string image) 
            : base(row, col, color, image)
        {
            this.Name = "Queen";
        }
    }
}
