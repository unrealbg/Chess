using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class Pawn : ChessFigure
    {
        public Pawn(int row, int col, string color, string image)
            :base(row, col, color, image)
        {
            this.Name = "Pawn";
        }
    }
}
