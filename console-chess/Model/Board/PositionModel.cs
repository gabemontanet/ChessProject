using System;
using System.Collections.Generic;
using System.Text;

namespace console_chess.Model
{
    class PositionModel
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public PositionModel(int line, int column)
        {
            this.Line = line;
            this.Column = column;
        }

        public override string ToString()
        {
            return 
                Line + 
                "," + 
                Column;
        }
    }
    
}
