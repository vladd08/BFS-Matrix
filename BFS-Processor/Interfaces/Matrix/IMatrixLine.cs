using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IMatrixLine
    {
        List<IMatrixElement> Line { get; set; }
        IMatrixElement GetElementAtLeft(IMatrixElement element);
        IMatrixElement GetElementAtRight(IMatrixElement element);
        IMatrixElement GetElementAtIndex(int elementIndex);
        bool IsEmpty();
    }
}
