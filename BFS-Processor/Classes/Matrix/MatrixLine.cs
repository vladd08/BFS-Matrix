using System;
using System.Collections.Generic;
using BFS.Interfaces;

namespace BFS.Classes
{
    internal sealed class MatrixLine: IMatrixLine
    {
        public List<IMatrixElement> Line { get; set; }

        internal MatrixLine()
        {
            Line = new List<IMatrixElement>();
        }

        public override string ToString()
        {
            string line = "";
            for(var i = 0; i < Line.Count; i++)
            {
                line += Line[i].ToString();
            }
            return AppendNewlineToLine(line);
        }

        private string AppendNewlineToLine(string line)
        {
            return line += Environment.NewLine + Environment.NewLine;
        }
    }
}
