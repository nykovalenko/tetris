namespace TetrisClient.Entities
{
    public class Figure
    {
        public Figure(Element type, Point currentPoint)
        {
            Type = type;
            CurrentPoint = currentPoint;
        }

        public Element Type { get; }
        public Point CurrentPoint { get; }
    }
}
