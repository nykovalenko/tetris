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
            FigurePointX = PatternPoint.X + _pattern.OffsetX;
            Level = patternPoint.Y - _pattern.DiffBetweenYAndLevel;
            FigureAngel = _pattern.Angle;
        }

        public FigurePattern Pattern => _pattern;
        public Point PatternPoint { get; }
        public int FigurePointX { get; }
        public EAngel FigureAngel { get; }
        public int Level { get; }
    }
}
