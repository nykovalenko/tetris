using TetrisClient.Enums;
using TetrisClient.FigurePatterns;

namespace TetrisClient.Entities
{
    public class PlaceForFigure
    {
        private FigurePattern _pattern;

        public PlaceForFigure(FigurePattern pattern, Point patternPoint)
        {
            _pattern = pattern;
            PatternPoint = patternPoint;
        }

        public FigurePattern Pattern => _pattern;
        public Point PatternPoint { get; }
        public Point FigurePoint => new Point(PatternPoint.X + _pattern.OffsetX, PatternPoint.Y + _pattern.OffsetY);
        public EAngel FigureAngel => _pattern.Angle;
    }
}
