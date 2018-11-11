using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IGraph
    {
        List<IGraphVertex> GraphInstance { get; set; }
    }
}
