using System;
using System.Collections.Generic;
using BFS.Exceptions;
using BFS.Factories;
using BFS.Interfaces;

namespace BFS.Classes
{
    internal sealed class Matrix : IMatrix
    {
        public List<IMatrixLine> MatrixInstance { get; set; }
        public int Size { get; set; }
        private bool StartPositionSet { get; set; }
        private IMatrixFactory MatrixFactory { get; set; }
        internal Matrix()
        {
            MatrixFactory = new MatrixFactory();
            MatrixInstance = new List<IMatrixLine>();
            StartPositionSet = false;
        }
        public void SetMatrixElement(IMatrixElement element)
        {
            if (!IsElementInRange(element))
                throw new ElementOutOfRangeException(Locales.Strings.ElementOutOfRange);

            if (!IsRobotElementAlreadySet() && element.IsRobot())
                StartPositionSet = true;
            else if (IsRobotElementAlreadySet() && element.IsRobot())
                throw new StartElementAlreadySetException(Locales.Strings.StartPositionAlreadySet);

            if (IsElementAlreadyMarked(element))
                throw new ElementAlreadySetException(Locales.Strings.PositionAlreadySet);

            MatrixInstance[element.X].Line[element.Y] = element;
        }
        public IMatrixElement GetElementAbove(IMatrixLine line, IMatrixElement element)
        {
            if (!HasLineAbove(MatrixInstance.IndexOf(line)))
                return GetEmptyElement();

            int indexOfElement = line.Line.IndexOf(element);
            IMatrixLine lineAbove = MatrixInstance[MatrixInstance.IndexOf(line) - 1];
            return lineAbove.GetElementAtIndex(indexOfElement);
        }
        public IMatrixElement GetElementBelow(IMatrixLine line, IMatrixElement element)
        {
            if (!HasLineBelow(MatrixInstance.IndexOf(line)))
                return GetEmptyElement();

            int indexOfElement = line.Line.IndexOf(element);
            IMatrixLine lineBelow = MatrixInstance[MatrixInstance.IndexOf(line) + 1];
            return lineBelow.GetElementAtIndex(indexOfElement);
        }
        public override string ToString()
        {
            string matrixLines = Environment.NewLine;
            for (var i = 0; i < MatrixInstance.Count; i++)
            {
                matrixLines += MatrixInstance[i].ToString();
            }
            return matrixLines;
        }
        private IMatrixElement GetEmptyElement()
        {
            return MatrixFactory.CreateMatrixElement(Enums.MatrixElementType.Empty, 0, 0);
        }
        private bool IsElementInRange(IMatrixElement element) => element.X < Size && element.Y < Size && element.X >= 0 && element.Y >= 0;
        private bool IsElementAlreadyMarked(IMatrixElement element) => !MatrixInstance[element.X].Line[element.Y].IsAvailable();
        private bool IsRobotElementAlreadySet() => StartPositionSet;
        private bool HasLineAbove(int lineIndex) => lineIndex - 1 >= 0;
        private bool HasLineBelow(int lineIndex) => lineIndex + 1 < Size;
    }
}
