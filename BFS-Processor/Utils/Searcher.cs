using BFS.Classes;
using BFS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFS.Utils
{
    public static class Searcher
    {
        public static string BFS(IGraphVertex startVertex, List<IGraphVertex> destinationVertices, IGraph graph)
        {
            IBFSSearcher searcher = new BFSSearcher(startVertex, destinationVertices, graph);
            searcher.BFS();
            return searcher.PathToString();
        }
    }
}
