namespace TetrisClient.Strategies.CurrentFigureLocation
{
    public class LineBlockLocationStrategy : CurrentFigureLocationStrategy
    {
        public override bool IsCurrentFigurePoint(Point currentFigurePosition, Point point)
        {
            return (currentFigurePosition.X == point.X && (currentFigurePosition.Y - 2) == point.Y);
        }
    }
}
