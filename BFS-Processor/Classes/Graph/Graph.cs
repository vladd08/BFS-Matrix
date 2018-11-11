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
        public int GetIndexOfVertex(IGraphVertex vertex) => GraphInstance.IndexOf(vertex);
        public List<IGraphVertex> GetConnectedVertices(IGraphVertex vertex) => GraphInstance[GetIndexOfVertex(vertex)].ConnectedVertices;
        public IGraphVertex GetGraphVertexFromNeighbourVertex(IGraphVertex neighbourVertex)
        {
            foreach(IGraphVertex vertex in GraphInstance)
            {
                if (vertex.MatrixElement.Equals(neighbourVertex.MatrixElement))
                    return vertex;
            }
            return new GraphVertex();
        }
        public IGraphVertex GetStartVertex()
        {
            foreach(IGraphVertex vertex in GraphInstance)
            {
                if (vertex.MatrixElement.GetType().Name == "StartMatrixElement")
                    return vertex;
            }
            return new GraphVertex();
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
