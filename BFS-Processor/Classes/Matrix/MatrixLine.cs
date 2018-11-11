using System;
using System.Collections.Generic;
using BFS.Factories;
using BFS.Interfaces;

namespace BFS.Classes
{
    internal sealed class MatrixLine : IMatrixLine
    {
        public List<IMatrixElement> Line { get; set; }
        private IMatrixFactory MatrixFactory;
        internal MatrixLine()
        {
            Line = new List<IMatrixElement>();
            MatrixFactory = new MatrixFactory();
        }
        public IMatrixElement GetElementAtLeft(IMatrixElement element)
        {
            if (!HasElementAtLeft(Line.IndexOf(element)))
                return GetEmptyElement();

            return Line[Line.IndexOf(element) - 1];
        }
        public IMatrixElement GetElementAtRight(IMatrixElement element)
        {
            if (!HasElementAtRight(Line.IndexOf(element)))
                return GetEmptyElement();

            return Line[Line.IndexOf(element) + 1];
        }
        public IMatrixElement GetElementAtIndex(int elementIndex) => Line[elementIndex];
        public bool IsEmpty() => Line.Count == 0;
        private IMatrixElement GetEmptyElement() => MatrixFactory.CreateMatrixElement(Enums.MatrixElementType.Empty, 0, 0);
        private bool HasElementAtLeft(int elementIndex) => elementIndex - 1 >= 0;
        private bool HasElementAtRight(int elementIndex) => elementIndex + 1 < Line.Count;
        public override string ToString()
        {
            string lines = "";
            for (var i = 0; i < Line.Count; i++)
            {
                lines += Line[i].ToString();
            }
            return AppendNewlineToLine(lines);
        }
        private string AppendNewlineToLine(string line) => line += Environment.NewLine + Environment.NewLine;
    }
}
