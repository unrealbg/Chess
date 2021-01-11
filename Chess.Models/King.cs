using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class King : ChessFigure
    {
        public King(int row, int col, string color, string image) 
            : base(row, col, color, image)
        {
        }
    }
}
