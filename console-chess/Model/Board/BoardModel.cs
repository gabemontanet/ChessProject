using System;
using System.Collections.Generic;
using System.Text;

namespace console_chess.Model.Board
{
    class BoardModel
    {
        public int Line { get; set; }
        public int Column { get; set; }
        private PieceModel[,] Pieces;
        
        public BoardModel(int line, int columns)
        {
            this.Line = line;
            this.Column = columns;
            this.Pieces = new PieceModel[line, columns];
        }

        public PieceModel Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public void PutPiece(PieceModel Piece, PositionModel Position)
        {
            Pieces[Position.Line, Position.Column] = Piece;
            Piece.Position = Position;
        }
    }
}
