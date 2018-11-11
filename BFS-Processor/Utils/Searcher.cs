using BFS.Classes;
using BFS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFS.Utils
{
    public static class Searcher
    {
        public static IBFSSearcher searcher;
        public static string BFS(IGraphVertex startVertex, IGraph graph)
        {
            searcher = new BFSSearcher(startVertex, graph);
            searcher.GetBFSTrackOfGraph(startVertex);
            return searcher.ResultContent;
        }
        public static string ParseBFSDistances(List<int> Distances)
        {
            string pathResult = Environment.NewLine;
            foreach(IGraphVertex vertex in searcher.Graph.GraphInstance)
            {
                if (vertex.MatrixElement.IsDestination())
                {
                    pathResult += "Getting from start to " + vertex.ToMatrixElementString() + " and back ";
                    int indexOfDestinationVertex = searcher.Graph.GetIndexOfVertex(vertex);
                    int distanceBetweenDestinationAndStart = Distances[indexOfDestinationVertex] - Distances[searcher.Graph.GetIndexOfVertex(searcher.Graph.GetStartVertex())];
                    pathResult += " needs " + distanceBetweenDestinationAndStart + " moves each route";
                }
                pathResult += Environment.NewLine;
            }
            string pathElements = "";
            foreach(IGraphVertex pathVertex in searcher.Path)
            {
                pathElements += pathVertex.ToMatrixElementString() + " -> ";
            }
            pathResult += "Path taken is: " + pathElements + searcher.Graph.GetStartVertex().ToMatrixElementString();
            return pathResult;
        }
    }
}
