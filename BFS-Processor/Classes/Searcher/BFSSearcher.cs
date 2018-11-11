using BFS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFS.Classes
{
    internal sealed class BFSSearcher : IBFSSearcher
    {
        public IGraph Graph { get; set; }
        public IGraphVertex StartVertex { get; set; }
        public Stack<IGraphVertex> Queue { get; set; }
        public List<int> Distances { get; set; }
        public List<IGraphVertex> Path { get; set; }
        public string ResultContent { get; set; }
        private readonly int DISTANCE_UNIT = 1;
        private readonly List<IGraphVertex> DestinationVertexes;
        internal BFSSearcher(IGraphVertex startVertex, IGraph graph)
        {
            Graph = graph;
            StartVertex = startVertex;
            Distances = new List<int>(Graph.GraphInstance.Count);
            for (int i = 0; i < Graph.GraphInstance.Count; i++)
                Distances.Add(-1);
            int StartVertexIndex = Graph.GetIndexOfVertex(StartVertex);
            Distances[StartVertexIndex] = 0;
            Path = new List<IGraphVertex>();
            DestinationVertexes = Graph.GetDestinationVertices();
        }
        public void GetBFSTrackOfGraph(IGraphVertex startVertex)
        {
            Queue = new Stack<IGraphVertex>(Graph.GraphInstance.Count);
            Queue.Push(startVertex);
            int StartVertexIndex = Graph.GetIndexOfVertex(startVertex);
            Distances[StartVertexIndex] = 0;
            ResultContent += Environment.NewLine + "BFS Track:";

            while (Queue.Count != 0)
            {
                ResultContent += Environment.NewLine;
                ResultContent += "Queue: ";

                foreach (IGraphVertex queueVertex in Queue)
                {
                    ResultContent += " " + queueVertex.ToMatrixElementString() + " ";
                }

                IGraphVertex vertex = Queue.Pop();
                Path.Add(vertex);

                ResultContent += Environment.NewLine;
                ResultContent += "Looking at " + vertex.ToMatrixElementString() + "'s connected vertices:";

                foreach (IGraphVertex neighbour in Graph.GetConnectedVertices(vertex))
                {
                    IGraphVertex neighbourVertex = Graph.GetGraphVertexFromNeighbourVertex(neighbour);

                    ResultContent += Environment.NewLine;
                    ResultContent += vertex.ToMatrixElementString() + " is connected to " + neighbourVertex.ToMatrixElementString();

                    int indexOfNeighbourVertex = Graph.GetIndexOfVertex(neighbourVertex);

                    if (Distances[indexOfNeighbourVertex] == -1)
                    {
                        ResultContent += Environment.NewLine;
                        ResultContent += neighbourVertex.ToMatrixElementString() + " has no connections explored yet";
                        ResultContent += Environment.NewLine;

                        Distances[indexOfNeighbourVertex] = Distances[Graph.GetIndexOfVertex(vertex)] + DISTANCE_UNIT;
                        ResultContent += "Adding it to queue ...";
                        Queue.Push(neighbourVertex);
                    }
                    else
                    {
                        ResultContent += Environment.NewLine;
                        ResultContent += neighbourVertex.ToMatrixElementString() + " is fully explored.";
                    }
                    ResultContent += Environment.NewLine;
                }
                ResultContent += "--------------------------------------------------------------";
            }
            ResultContent += Environment.NewLine + "FINISHED";
        }
    }
}
