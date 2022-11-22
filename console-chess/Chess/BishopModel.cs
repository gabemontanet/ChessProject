using console_chess.Model.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace console_chess.Chess
{
    class BishopModel : PieceModel
    {
        public BishopModel(ColorEnum Color, BoardModel Board) : base(Color, Board)
        {

        }
        public override string ToString()
        {
            return "B";
        }
    }
}
