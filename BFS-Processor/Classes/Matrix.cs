using System.Collections.Generic;
using BFS.Factories;
using BFS.Interfaces;

namespace BFS.Enums
{
    internal sealed class Matrix : IMatrix
    {
        public List<IMatrixLine> MatrixInstance { get; set; }
        public int Size { get; set; }

        internal Matrix()
        {
            MatrixInstance = new List<IMatrixLine>();
        }

        public override string ToString()
        {
            string matrix = "";
            for (var i = 0; i < MatrixInstance.Count; i++)
            {
                matrix += MatrixInstance[i].ToString();
            }
            return matrix;
        }
    }
}
