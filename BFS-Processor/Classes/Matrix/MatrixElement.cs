using BFS.Interfaces;

namespace BFS.Enums
{
    internal class MatrixElement : IMatrixElement
    {
        private readonly string RobotElement = "      X      ";
        private readonly string AvailableElement = "      0      ";
        private readonly string DestinationElement = "      1      ";
        public int X { get; set; }
        public int Y { get; set; }

        internal MatrixElement(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public bool IsAvailable()
        {
            return GetType().Name == "AvailableMatrixElement";
        }
        public bool IsRobot()
        {
            return GetType().Name == "RobotMatrixElement";
        }
        public bool IsDestination()
        {
            return GetType().Name == "DestinationMatrixElement";
        }
        public override string ToString()
        {
            string type = this.GetType().Name;
            switch (type)
            {
                case "AvailableMatrixElement":
                    return AvailableElement;
                case "DestinationMatrixElement":
                    return DestinationElement;
                case "RobotMatrixElement":
                    return RobotElement;
                default:
                    return "";
            }
        }
    }
}
