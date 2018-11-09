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
    }
}
