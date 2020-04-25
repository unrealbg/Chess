using Chess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Services.Contracts
{
    public interface IBoardGeneratorService
    {
        Square[,] Generate();
    }
}
