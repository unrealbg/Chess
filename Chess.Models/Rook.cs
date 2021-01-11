using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class Rook : ChessFigure
    {
        public Rook(int row, int col, string color, string image) 
            : base(row, col, color, image)
        {
        }
    }
}
