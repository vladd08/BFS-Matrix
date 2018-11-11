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
                case MatrixElementType.Start:
                    return new StartMatrixElement(X, Y);
                case MatrixElementType.Empty:
                    return new EmptyMatrixElement(X, Y);
                default:
                    throw new InvalidMatrixElementTypeException(Message: Locales.Strings.InvalidMatrixElementType);
            }
        }
        public IMatrix InitializeMatrix(IMatrix matrix, int size)
        {
            if (size == 0 || size == 1 || size < 0)
                throw new InvalidOrNotExistentMatrixSizeException(Message: Locales.Strings.InvalidMatrixSize);

            List<IMatrixLine> lineList = new List<IMatrixLine>();
            for (int i = 0; i < size; i++)
            {
                List<IMatrixElement> elementList = new List<IMatrixElement>();
                for (int j = 0; j < size; j++)
                {
                    IMatrixElement matrixElement;
                    matrixElement = CreateMatrixElement(MatrixElementType.Available, i, j);
                    elementList.Add(matrixElement);
                }
                IMatrixLine matrixLine = CreateMatrixLine(elementList);
                lineList.Add(matrixLine);
            }
            matrix = CreateMatrix(lineList);
            return matrix;
        }
    }
}
