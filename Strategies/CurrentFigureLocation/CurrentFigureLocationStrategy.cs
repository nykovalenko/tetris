namespace TetrisClient.Strategies.CurrentFigureLocation
{
    public abstract class CurrentFigureLocationStrategy
    {
        public abstract bool IsCurrentFigurePoint(Point currentFigurePosition, Point point);
    }
}
