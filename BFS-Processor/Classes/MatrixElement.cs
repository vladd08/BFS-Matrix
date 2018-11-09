using BFS.Interfaces;

namespace BFS.Enums
{
    internal class MatrixElement : IMatrixElement
    {
        public int X { get; set; }
        public int Y { get; set; }

        internal MatrixElement(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
