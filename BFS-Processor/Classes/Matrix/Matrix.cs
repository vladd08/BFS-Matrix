using System;
using System.Collections.Generic;
using BFS.Exceptions;
using BFS.Factories;
using BFS.Interfaces;

namespace BFS.Enums
{
    internal sealed class Matrix : IMatrix
    {
        public List<IMatrixLine> MatrixInstance { get; set; }
        public int Size { get; set; }
        private IMatrixFactory MatrixFactory { get; set; }
        private bool StartPositionSet = false;

        internal Matrix()
        {
            MatrixFactory = new MatrixFactory();
            MatrixInstance = new List<IMatrixLine>();
        }

        public void SetMatrixElement(IMatrixElement element)
        {
            if (!IsElementInRange(element))
                throw new ElementOutOfRangeException(Locales.Strings.ElementOutOfRange);

            if (!StartPositionSet && element.IsRobot())
                StartPositionSet = true;
            else if (StartPositionSet && element.IsRobot())
                throw new StartPositionAlreadySetException(Locales.Strings.StartPositionAlreadySet);

            if (IsElementAlreadyMarked(element))
                throw new PositionAlreadySetException(Locales.Strings.PositionAlreadySet);

            MatrixInstance[element.X].Line[element.Y] = element;
        }

        private bool IsElementInRange(IMatrixElement element) => element.X < Size && element.Y < Size && element.X >= 0 && element.Y >= 0;

        private bool IsElementAlreadyMarked(IMatrixElement element) => !MatrixInstance[element.X].Line[element.Y].IsAvailable();

        public override string ToString()
        {
            string matrix = Environment.NewLine;
            for (var i = 0; i < MatrixInstance.Count; i++)
            {
                matrix += MatrixInstance[i].ToString();
            }
            return matrix;
        }
    }
}
