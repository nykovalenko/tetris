using System;
using System.Collections.Generic;
using System.Linq;
using TetrisClient.Entities;
using TetrisClient.Enums;

namespace TetrisClient.Strategies
{
    public class LevelDetermineStrategy
    {
        private const int SquareRepeatNumber = 40;
        private int _squareRepeatNumber = 0;

        public ELevel GetLevel(ELevel currentLevel, IEnumerable<Element> futureElements)
        {
            if (currentLevel != ELevel.OnlySquares)
            {
                if (futureElements.All(e => e == Element.YELLOW))
                {
                    _squareRepeatNumber++;
                }
                else
                {
                    _squareRepeatNumber = 0;
                }

                if (_squareRepeatNumber == SquareRepeatNumber)
                {
                    _squareRepeatNumber = 0;
                    return ELevel.OnlySquares;
                }
            }

            if (currentLevel == ELevel.OnlySquares)
            {
                if (futureElements.Any(e => e == Element.BLUE))
                    return ELevel.SquaresLines;
            }
            else if (currentLevel == ELevel.SquaresLines)
            {
                if (futureElements.Any(e => e == Element.CYAN || e == Element.ORANGE))
                    return ELevel.SquaresLinesLandJ;
            }
            else if (currentLevel == ELevel.SquaresLinesLandJ)
            {
                if (futureElements.Any(e => e == Element.RED || e == Element.GREEN || e == Element.PURPLE))
                    return ELevel.High;
            }

            return currentLevel;
        }
    }
}
