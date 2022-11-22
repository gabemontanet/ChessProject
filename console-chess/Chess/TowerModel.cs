using console_chess.Model.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace console_chess.Chess
{
    class TowerModel : PieceModel
    {
        public TowerModel(ColorEnum Color, BoardModel Board) : base(Color, Board)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
