using BFS.Enums;
using BFS.Interfaces;
using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IMatrixFactory
    {
        IMatrix CreateMatrix(List<IMatrixLine> lineList);
        IMatrixLine CreateMatrixLine(List<IMatrixElement> elementList);
        IMatrixElement CreateMatrixElement(MatrixElementType elementType, int X, int Y);
    }
}
