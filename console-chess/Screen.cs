using console_chess.Model.Board;
using System;

namespace console_chess
{
    class Screen
    {
        public static void PrintBoard(BoardModel Board)
        {
            for(int countx = 0; countx < Board.Line; countx ++)
            {
                for (int county = 0; county < Board.Column; county++)
                {
                    if (Board.Piece(countx, county) == null)
                        Console.Write("- ");
                    else
                        Console.Write(Board.Piece(countx, county) + " ");
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
