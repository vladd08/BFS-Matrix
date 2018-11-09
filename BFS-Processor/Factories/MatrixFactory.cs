using System.Collections.Generic;
using BFS.Classes;
using BFS.Enums;
using BFS.Exceptions;
using BFS.Interfaces;

namespace BFS.Factories
{
    public sealed class MatrixFactory : IMatrixFactory
    {

        public IMatrix CreateMatrix(List<IMatrixLine> lineList)
        {
            IMatrix matrix = new Matrix();
            foreach (IMatrixLine line in lineList)
            {
                matrix.MatrixInstance.Add(line);
            }

            matrix.Size = lineList.Count;
            return matrix;
        }

        public IMatrixLine CreateMatrixLine(List<IMatrixElement> elementList)
        {
            IMatrixLine line = new MatrixLine();
            foreach (IMatrixElement element in elementList)
            {
                line.Line.Add(element);
            }

            return line;
        }

        public IMatrixElement CreateMatrixElement(MatrixElementType elementType, int X, int Y)
        {
            switch (elementType)
            {
                case MatrixElementType.Available:
                    return new AvailableMatrixElement(X, Y);
                case MatrixElementType.Destination:
                    return new DestinationMatrixElement(X, Y);
                case MatrixElementType.Robot:
                    return new RobotMatrixElement(X, Y);
                default:
                    throw new InvalidMatrixElementTypeException(Message: Locales.Strings.InvalidMatrixElementType);
            }
        }
    }
}
