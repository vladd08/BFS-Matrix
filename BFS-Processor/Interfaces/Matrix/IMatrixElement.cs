namespace BFS.Interfaces
{
    public interface IMatrixElement
    {
        int X { get; set; }
        int Y { get; set; }
        bool IsRobot();
        bool IsAvailable();
        bool IsDestination();
        bool IsEmpty();
    }
}
