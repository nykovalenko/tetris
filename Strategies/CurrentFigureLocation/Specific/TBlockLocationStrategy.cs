namespace TetrisClient.Strategies.CurrentFigureLocation.Specific
{
    public class TBlockLocationStrategy : CurrentFigureLocationStrategy
    {
        public override bool IsCurrentFigurePoint(Point currentFigurePosition, Point point)
        {
            return (currentFigurePosition.Y == point.Y)
                   && (currentFigurePosition.X == point.X 
                       || (currentFigurePosition.X - 1 == point.X) 
                       || (currentFigurePosition.X + 1 == point.X));
        }
    }
}
