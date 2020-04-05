using System;
using TetrisClient.FigurePatterns.JBlock;
using TetrisClient.FigurePatterns.LBlock;
using TetrisClient.FigurePatterns.Line;
using TetrisClient.FigurePatterns.SBlock;
using TetrisClient.FigurePatterns.Square;
using TetrisClient.FigurePatterns.TBlock;
using TetrisClient.FigurePatterns.ZBlock;

namespace TetrisClient.FigurePatterns
{
    public class FigurePatternCollectionFactory
    {
        private readonly SquarePatternCollection _squarePatternCollection;
        private readonly LinePatternCollection _linePatternCollection;
        private readonly ZBlockPatternCollection _zBlockPatternCollection;
        private readonly TBlockPatternCollection _tBlockPatternCollection;
        private readonly SBlockPatternCollection _sBlockPatternCollection;
        private readonly JBlockPatternCollection _jBlockPatternCollection;
        private readonly LBlockPatterCollection _lBlockPatterCollection;

        public FigurePatternCollectionFactory()
        {
            _linePatternCollection = new LinePatternCollection();
            _squarePatternCollection = new SquarePatternCollection();
            _jBlockPatternCollection = new JBlockPatternCollection();
            _lBlockPatterCollection = new LBlockPatterCollection();
            _sBlockPatternCollection = new SBlockPatternCollection();
            _zBlockPatternCollection = new ZBlockPatternCollection();
            _tBlockPatternCollection = new TBlockPatternCollection();
        }

        public FigurePatternCollection GetPatternCollection(Element type)
        {
            switch (type)
            {
                case Element.YELLOW:
                    return _squarePatternCollection;
                case Element.BLUE:
                    return _linePatternCollection;
                case Element.CYAN:
                    return _jBlockPatternCollection;
                case Element.GREEN:
                    return _sBlockPatternCollection;
                case Element.ORANGE:
                    return _lBlockPatterCollection;
                case Element.PURPLE:
                    return _tBlockPatternCollection;
                case Element.RED:
                    return _zBlockPatternCollection;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
