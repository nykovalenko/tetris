using System.Collections.Generic;
using System.Linq;
using TetrisClient.Entities;
using TetrisClient.FigurePatterns;
using TetrisClient.Strategies.CurrentFigureLocation;

namespace TetrisClient.Strategies
{
    public class PlaceForFigureFindStrategy
    {
        public PlaceForFigure Find(Cup cup, FigurePatternCollection patternCollection)
        {
            var placesForFigure = new List<PlaceForFigure>();
            foreach (var pattern in patternCollection.Collection)
            {
                for (var y = 0; y < cup.Size; y++)
                {
                    for (var x = 0; x < (cup.Size - (pattern.Width - 1)); x++)
                    {
                        var result = string.Empty;

                        for (var k = y; k > y - pattern.Height; k--)
                        {
                            var startIndex = cup.Size * (cup.Size - 1 - k) + x;
                            result = result + cup.Line.Substring(startIndex, pattern.Width);
                        }

                        if (result == pattern.Line && IsApplicablePosition(cup, x, y, pattern.Width))
                            placesForFigure.Add(new PlaceForFigure(pattern, new Point(x, y)));
                    }
                }
            }
            

            var minLevel = placesForFigure.Min(pff => pff.Level);
            var resultPlace = placesForFigure.FirstOrDefault(pff => pff.Level == minLevel);
            return resultPlace;
        }

        private bool IsApplicablePosition(Cup cup, int x, int y, int patternWidth)
        {
            for (var i = x; i < x + patternWidth; i++)
            {
                for (var j = y + 1; j < cup.Size; j++)
                {
                    if (cup.Board.GetAt(i, j) != Element.NONE)
                    {
                        var cfls = CurrentFigureLocationStrategyFactory.GetLocationStrategy(
                            cup.Board.GetCurrentFigureType());

                        if (!cfls.IsCurrentFigurePoint(cup.Board.GetCurrentFigurePosition(), new Point(i, j)))
                        {
                            return false;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return true;
        }
    }
}
