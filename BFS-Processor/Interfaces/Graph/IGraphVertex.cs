using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IGraphVertex
    {
        IMatrixElement MatrixElement { get; set; }
        List<IGraphVertex> ConnectedVertices { get; set; }
        string ToMatrixElementString();
    }
}
