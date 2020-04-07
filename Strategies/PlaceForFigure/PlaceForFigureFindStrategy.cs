using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisClient.Entities;
using TetrisClient.FigurePatterns;
using TetrisClient.Strategies.CurrentFigureLocation;

namespace TetrisClient.Strategies.PlaceForFigure
{
    public abstract class PlaceForFigureFindStrategy
    {
        public Entities.PlaceForFigure Find(Cup cup, FigurePatternCollection patternCollection)
        {
            var placesForFigure = CalculatePossiblePlacesForFigure(cup, patternCollection);

            return GetTheBestPlace(placesForFigure);
        }

        protected abstract List<Entities.PlaceForFigure> CalculatePossiblePlacesForFigure(Cup cup,
            FigurePatternCollection patternCollection);

        protected bool IsApplicablePosition(Cup cup, int x, int y, int patternWidth)
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

        protected Entities.PlaceForFigure GetTheBestPlace(List<Entities.PlaceForFigure> placesForFigure)
        {
            var minLevel = placesForFigure.Min(pff => pff.Level);
            return placesForFigure.FirstOrDefault(pff => pff.Level == minLevel);
        }
    }
}
