using System;
using TetrisClient.Strategies.CurrentFigureLocation.Specific;

namespace TetrisClient.Strategies.CurrentFigureLocation
{
    public static class CurrentFigureLocationStrategyFactory
    {
        private static readonly SBlockLocationStrategy _sBlockLocationStrategy;
        private static readonly ZBlockLocationStrategy _zBlockLocationStrategy;
        private static readonly TBlockLocationStrategy _tBlockLocationStrategy;
        private static readonly LBlockLocationStrategy _lBlockLocationStrategy;
        private static readonly JBlockLocationStrategy _jBlockLocationStrategy;
        private static readonly SquareBlockLocationStrategy _squareBlockLocationStrategy;
        private static readonly LineBlockLocationStrategy _lineBlockLocationStrategy;

        static CurrentFigureLocationStrategyFactory()
        {
            _sBlockLocationStrategy = new SBlockLocationStrategy();
            _zBlockLocationStrategy = new ZBlockLocationStrategy();
            _tBlockLocationStrategy = new TBlockLocationStrategy();
            _lBlockLocationStrategy = new LBlockLocationStrategy();
            _jBlockLocationStrategy = new JBlockLocationStrategy();
            _squareBlockLocationStrategy = new SquareBlockLocationStrategy();
            _lineBlockLocationStrategy = new LineBlockLocationStrategy();
        }

        public static CurrentFigureLocationStrategy GetLocationStrategy(Element figureType)
        {
            switch (figureType)
            {
                case Element.BLUE:
                    return _lineBlockLocationStrategy;
                case Element.YELLOW:
                    return _squareBlockLocationStrategy;
                case Element.CYAN:
                    return _jBlockLocationStrategy;
                case Element.GREEN:
                    return _sBlockLocationStrategy;
                case Element.RED:
                    return _zBlockLocationStrategy;
                case Element.PURPLE:
                    return _tBlockLocationStrategy;
                case Element.ORANGE:
                    return _lBlockLocationStrategy;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}