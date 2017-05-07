using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class TheBoard
    {
        public Cell[,] GameBoard { get; set; }
        public TheBoard(Cell[,] theBoard)
        {
            this.GameBoard = theBoard;
        }
    }
}
