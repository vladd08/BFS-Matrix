using BFS.Factories;
using BFS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFS.Classes
{
    internal sealed class BFSSearcher : IBFSSearcher
    {
        public IGraph Graph { get; set; }
        public IGraphVertex InitialStartVertex { get; set; }
        public List<IGraphVertex> Path { get; set; }
        public List<IGraphVertex> DestinationVertices { get; set; }
        private IMatrixFactory MatrixFactory;
        internal BFSSearcher(IGraphVertex startVertex, List<IGraphVertex> destinationVertices, IGraph graph)
        {
            InitialStartVertex = startVertex;
            DestinationVertices = destinationVertices;
            Graph = graph;
            MatrixFactory = new MatrixFactory();
            Path = new List<IGraphVertex>();
        }
        public void BFS()
        {
            List<IGraphVertex> route = GenerateRoute();
            for (int i = 0; i < route.Count; i++)
            {
                List<IGraphVertex> path = new List<IGraphVertex>();

                if (i + 1 == route.Count)
                    return;

                path = GetPathBetweenPoints(route[i], route[i + 1]);
                foreach (IGraphVertex vertex in path)
                    Path.Add(vertex);
                
            }
        }
        private List<IGraphVertex> GetPathBetweenPoints(IGraphVertex startVertex, IGraphVertex destinationVertex)
        {
            List<IGraphVertex> path = new List<IGraphVertex>();
            Stack<IGraphVertex> Queue = CreateNewQueue();
            Queue.Push(startVertex);

            int StartVertexIndex = Graph.GetIndexOfVertex(startVertex);
            List<bool> visited = CreateNewVisitedArray();
            visited[StartVertexIndex] = true;

            while (Queue.Count != 0)
            {
                IGraphVertex vertex = Queue.Pop();
                path.Add(vertex);

                if (vertex.MatrixElement.IsDestination() && !vertex.Equals(startVertex))
                    return path;

                foreach (IGraphVertex neighbour in Graph.GetConnectedVertices(vertex))
                {
                    IGraphVertex neighbourVertex = Graph.GetGraphVertexFromNeighbourVertex(neighbour);
                    int indexOfNeighbourVertex = Graph.GetIndexOfVertex(neighbourVertex);

                    if (visited[indexOfNeighbourVertex] == false)
                    {
                        visited[indexOfNeighbourVertex] = true;
                        Queue.Push(neighbourVertex);
                    }
                }
            }
            return path;
        }
        private Stack<IGraphVertex> CreateNewQueue() => new Stack<IGraphVertex>(Graph.GraphInstance.Count);
        private List<bool> CreateNewVisitedArray()
        {
            List<bool> visitedArray = new List<bool>();
            foreach (IGraphVertex vertex in Graph.GraphInstance)
                visitedArray.Add(false);
            return visitedArray;
        }
        private List<IGraphVertex> GenerateRoute()
        {
            List<IGraphVertex> route = new List<IGraphVertex>
            {
                InitialStartVertex
            };
            foreach (IGraphVertex vertex in DestinationVertices)
                route.Add(vertex);
            return route;
        }
        public string PathToString()
        {
            string path = Environment.NewLine;
            foreach (IGraphVertex vertex in Path)
            {
                path += vertex.ToMatrixElementString() + " -> ";
            }
            path += "Finish";
            return path;
        }
    }
}
