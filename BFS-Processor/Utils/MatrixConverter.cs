using BFS.Classes;
using BFS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFS.Utils
{
    public static class MatrixConverter
    {
        public static IGraph ConvertMatrixToGraph(IMatrix matrix)
        {
            IGraph graph = new Graph();
            foreach(IMatrixLine line in matrix.MatrixInstance)
            {
                foreach(IMatrixElement element in line.Line)
                {
                    IGraphVertex vertex = ConvertMatrixElementToVertex(element);
                    IMatrixElement elementAtRight = line.GetElementAtRight(element);
                    IMatrixElement elementAtLeft = line.GetElementAtLeft(element);
                    IMatrixElement elementAbove = matrix.GetElementAbove(line, element);
                    IMatrixElement elementBelow = matrix.GetElementBelow(line, element);

                    if (!elementAtLeft.IsEmpty())
                        vertex.ConnectedVertices.Add(ConvertMatrixElementToVertex(elementAtLeft));
                    if (!elementAtRight.IsEmpty())
                        vertex.ConnectedVertices.Add(ConvertMatrixElementToVertex(elementAtRight));
                    if (!elementAbove.IsEmpty())
                        vertex.ConnectedVertices.Add(ConvertMatrixElementToVertex(elementAbove));
                    if (!elementBelow.IsEmpty())
                        vertex.ConnectedVertices.Add(ConvertMatrixElementToVertex(elementBelow));
                    graph.GraphInstance.Add(vertex);
                }
            }
            return graph;
        }
        private static IGraphVertex ConvertMatrixElementToVertex(IMatrixElement element)
        {
            IGraphVertex vertex = new GraphVertex
            {
                MatrixElement = element
            };
            return vertex;
        }
    }
}
