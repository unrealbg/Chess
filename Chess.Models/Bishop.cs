using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class Bishop : ChessFigure
    {
        public Bishop(int row, int col, string color, string image) 
            : base(row, col, color, image)
        {
        }
    }
}
