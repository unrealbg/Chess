using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class Empty : ChessFigure
    {
        public Empty(int row, int col)
            :base(row, col,"", "")
        {
        }
    }
}
