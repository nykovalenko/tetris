﻿using System.Collections.Generic;
using System.Linq;
using TetrisClient.Entities;
using TetrisClient.FigurePatterns;
using TetrisClient.Strategies.PlaceForFigure;

namespace TetrisClient.Strategies
{
    public class RegularyPlaceForFigureFindStrategy : PlaceForFigureFindStrategy
    {
        protected override List<Entities.PlaceForFigure> CalculatePossiblePlacesForFigure(Cup cup, FigurePatternCollection patternCollection)
        {
            var placesForFigure = new List<Entities.PlaceForFigure>();
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
                            placesForFigure.Add(new Entities.PlaceForFigure(pattern, new Point(x, y)));
                    }
                }
            }

            return placesForFigure;
        }
    }
}
