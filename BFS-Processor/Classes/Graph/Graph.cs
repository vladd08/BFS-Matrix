using BFS.Interfaces;
using System;
using System.Collections.Generic;

namespace BFS.Classes
{
    internal sealed class Graph : IGraph
    {
        public List<IGraphVertex> GraphInstance { get; set; }
        internal Graph()
        {
            GraphInstance = new List<IGraphVertex>();
        }
        public override string ToString()
        {
            string graphLines = "Graph from matrix: ";
            foreach(IGraphVertex vertex in GraphInstance)
            {
                graphLines += vertex.ToString();
            }
            return graphLines;
        }
    }
}
