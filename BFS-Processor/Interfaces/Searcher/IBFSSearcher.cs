using BFS.Interfaces;
using System;
using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IBFSSearcher
    {
        IGraph Graph { get; set; }
        IGraphVertex StartVertex { get; set; }
        Stack<IGraphVertex> Queue { get; set; }
        string ResultContent { get; set; }
        List<int> Distances { get; set; }
        List<IGraphVertex> Path { get; set; }
        void GetBFSTrackOfGraph(IGraphVertex startVertex);
    }
}
