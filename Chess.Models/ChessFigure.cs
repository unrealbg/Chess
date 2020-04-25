using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Models
{
    public class ChessFigure : BasePositionModel
    {

        public ChessFigure(int row, int col, string color, string image)
        {
            this.Row = row;
            this.Col = col;
            this.Color = color;
            this.Image = image;
        }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Color { get; set; }


        public override string ToString()
        {
            return $"{this.Name} {this.Row} {this.Col}";
        }
    }
}
