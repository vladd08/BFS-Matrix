using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IGraph
    {
        List<IGraphVertex> GraphInstance { get; set; }
        int GetIndexOfVertex(IGraphVertex vertex);
        List<IGraphVertex> GetConnectedVertices(IGraphVertex vertex);
        IGraphVertex GetStartVertex();
        IGraphVertex GetGraphVertexFromNeighbourVertex(IGraphVertex neighbourVertex);
        List<IGraphVertex> GetDestinationVertices();
    }
}
