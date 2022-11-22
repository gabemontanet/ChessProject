using System;
using System.Collections.Generic;
using System.Text;

namespace console_chess.Model.Board
{
    class PieceModel
    {
        public PositionModel Position { get; set; }
        public ColorEnum Color { get; protected set; }
        public int NofMovements { get; protected set; }
        public BoardModel Board { get; set; }

        public PieceModel(ColorEnum color, BoardModel board)
        {
            this.Position = null;
            this.Color = color;
            this.NofMovements = 0;
            this.Board = board;
        }
    }
}
