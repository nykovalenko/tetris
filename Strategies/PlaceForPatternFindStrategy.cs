using System;
using System.Collections.Generic;
using System.Linq;
using TetrisClient.Entities;
using TetrisClient.FigurePatterns;

namespace TetrisClient.Strategies
{
    public class PlaceForPatternFindStrategy
    {
        public PlaceForFigure Find(Cup cup, FigurePatternCollection patternCollection)
        {
            var placesForFigure = new List<PlaceForFigure>();
            try
            {
                foreach (var pattern in patternCollection.Collection)
                {
                    for (var y = 0; y < cup.Size-2; y++)
                    {
                        for (var x = 0; x < (cup.Size - (pattern.Width - 1)); x++)
                        {
                            var result = string.Empty;

                            for (var k = y; k > y - pattern.Height; k--)
                            {
                                try
                                {
                                    var startIndex = cup.Size * (cup.Size - 1 - k) + x;
                                    result = result + cup.Line.Substring(startIndex, pattern.Width);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    throw;
                                }
                            }

                            if (result == pattern.Line)
                                placesForFigure.Add(new PlaceForFigure(pattern, new Point(x, y)));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            var minY = placesForFigure.Min(pff => pff.PatternPoint.Y + 1 - pff.Pattern.Height);
            var resultPlace = placesForFigure.FirstOrDefault(pff => (pff.PatternPoint.Y + 1 - pff.Pattern.Height) == minY);
            return resultPlace;
        }
    }
}
