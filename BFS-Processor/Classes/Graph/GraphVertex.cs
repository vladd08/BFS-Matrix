using BFS.Interfaces;
using System;
using System.Collections.Generic;

namespace BFS.Classes
{
    internal sealed class GraphVertex : IGraphVertex
    {
        public IMatrixElement MatrixElement { get; set; }
        public List<IGraphVertex> ConnectedVertices { get; set; }
        public bool Visited { get; set; }        internal GraphVertex()
        {
            ConnectedVertices = new List<IGraphVertex>();
            Visited = false;
        }
        public override string ToString()
        {
            string vertexLines = Environment.NewLine;
            vertexLines += "Vertex " + "[" + MatrixElement.X + "," + MatrixElement.Y + "] is connected to: ";
            foreach(GraphVertex connectedVertex in ConnectedVertices)
            {
                vertexLines += Environment.NewLine;
                vertexLines += "[" + connectedVertex.MatrixElement.X + "," + connectedVertex.MatrixElement.Y + "] - " + connectedVertex.MatrixElement.ToString();
            }
            vertexLines += Environment.NewLine;
            return vertexLines;
        }
        public string ToMatrixElementString()
        {
            return "[" + MatrixElement.X + ", " + MatrixElement.Y + "]";
        }
    }
}
