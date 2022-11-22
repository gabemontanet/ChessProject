using console_chess.Chess;
using console_chess.Model;
using console_chess.Model.Board;
using System;

namespace console_chess
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardModel Board = new BoardModel(8, 8);

            Board.PutPiece(new TowerModel(ColorEnum.Black, Board), new PositionModel(0, 0));
            Board.PutPiece(new HorseModel(ColorEnum.Black, Board), new PositionModel(0, 1));
            Board.PutPiece(new BishopModel(ColorEnum.Black, Board), new PositionModel(0, 2));
            Board.PutPiece(new QueenModel(ColorEnum.Black, Board), new PositionModel(0, 3));
            Board.PutPiece(new KingModel(ColorEnum.Black, Board), new PositionModel(0, 4));
            Board.PutPiece(new BishopModel(ColorEnum.Black, Board), new PositionModel(0, 5));
            Board.PutPiece(new HorseModel(ColorEnum.Black, Board), new PositionModel(0, 6));
            Board.PutPiece(new TowerModel(ColorEnum.Black, Board), new PositionModel(0, 7));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 0));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 1));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 2));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 3));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 4));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 5));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 6));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(1, 7));


            Board.PutPiece(new TowerModel(ColorEnum.White, Board), new PositionModel(7, 0));
            Board.PutPiece(new HorseModel(ColorEnum.White, Board), new PositionModel(7, 1));
            Board.PutPiece(new BishopModel(ColorEnum.White, Board), new PositionModel(7, 2));
            Board.PutPiece(new QueenModel(ColorEnum.White, Board), new PositionModel(7, 3));
            Board.PutPiece(new KingModel(ColorEnum.White, Board), new PositionModel(7, 4));
            Board.PutPiece(new BishopModel(ColorEnum.White, Board), new PositionModel(7, 5));
            Board.PutPiece(new HorseModel(ColorEnum.White, Board), new PositionModel(7, 6));
            Board.PutPiece(new TowerModel(ColorEnum.White, Board), new PositionModel(7, 7));
            Board.PutPiece(new PawnModel(ColorEnum.Black, Board), new PositionModel(6, 0));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 1));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 2));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 3));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 4));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 5));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 6));
            Board.PutPiece(new PawnModel(ColorEnum.White, Board), new PositionModel(6, 7));

            Screen.PrintBoard(Board);
            
            Console.ReadLine();
        }
    }
}
