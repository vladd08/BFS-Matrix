using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IMatrix
    {
        List<IMatrixLine> MatrixInstance { get; set; }
        int Size { get; set; }
        void SetMatrixElement(IMatrixElement element);
        IMatrixElement GetElementAbove(IMatrixLine line, IMatrixElement element);
        IMatrixElement GetElementBelow(IMatrixLine line, IMatrixElement element);
    }
}
