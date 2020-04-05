namespace TetrisClient.Strategies.CurrentFigureLocation.Specific
{
    public class SBlockLocationStrategy : CurrentFigureLocationStrategy
    {
        public override bool IsCurrentFigurePoint(Point currentFigurePosition, Point point)
        {
            return (currentFigurePosition.X == point.X && currentFigurePosition.Y == point.Y)
                   || (currentFigurePosition.X - 1 == point.X && currentFigurePosition.Y == point.Y)
                   || (currentFigurePosition.X + 1 == point.X && currentFigurePosition.Y + 1 == point.Y);
        }
    }
}
