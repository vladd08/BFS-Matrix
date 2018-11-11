using BFS.Interfaces;

namespace BFS.Classes
{
    internal class MatrixElement : IMatrixElement
    {
        private readonly string StartElement = "      X      ";
        private readonly string AvailableElement = "      0      ";
        private readonly string DestinationElement = "      1      ";
        public int X { get; set; }
        public int Y { get; set; }
        internal MatrixElement(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public bool IsAvailable() => GetType().Name == "AvailableMatrixElement";
        public bool IsRobot() => GetType().Name == "StartMatrixElement";
        public bool IsDestination() => GetType().Name == "DestinationMatrixElement";
        public bool IsEmpty() => GetType().Name == "EmptyMatrixElement";
        public override string ToString()
        {
            string type = this.GetType().Name;
            switch (type)
            {
                case "AvailableMatrixElement":
                    return AvailableElement;
                case "DestinationMatrixElement":
                    return DestinationElement;
                case "StartMatrixElement":
                    return StartElement;
                default:
                    return "";
            }
        }
    }
}
