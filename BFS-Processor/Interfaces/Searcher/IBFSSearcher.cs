using BFS.Interfaces;
using System;
using System.Collections.Generic;

namespace BFS.Interfaces
{
    public interface IBFSSearcher
    {
        IGraph Graph { get; set; }
        IGraphVertex InitialStartVertex { get; set; }
        List<IGraphVertex> DestinationVertices { get; set; }
        List<IGraphVertex> Path { get; set; }
        string PathToString();
        void BFS();
    }
}
