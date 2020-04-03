using TetrisClient.Entities;
using TetrisClient.FigurePatterns;

namespace TetrisClient.Strategies
{
    public class PlaceForPatternFindStrategy
    {
        public PlaceForPattern Find(Cup cup, FigurePattern pattern)
        {
            for (var y = 0; y < cup.Size; y++)
            {
                for (var x = 0; x < cup.Size; x++)
                {
                    var result = string.Empty;
                    for (var k = y; k > y - pattern.Height; k--)
                    {
                        var startIndex = cup.Size * (cup.Size - 1 - k) + x;
                        result = result + cup.Line.Substring(startIndex, pattern.Width);
                    }

                    if (result == pattern.Line)
                        return new PlaceForPattern(){Point = new Point(x, y)};
                }
            }

            return new PlaceForPattern(){Point = new Point(0, 0)};
        }
    }
}
