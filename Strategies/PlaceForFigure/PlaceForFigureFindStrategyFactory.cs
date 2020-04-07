using TetrisClient.Enums;

namespace TetrisClient.Strategies.PlaceForFigure
{
    public class PlaceForFigureFindStrategyFactory
    {
        private readonly RegularyPlaceForFigureFindStrategy _regularyPlaceForFigureFindStrategy;
        private readonly LinesOrientedPlaceForFigureFindStrategy _linesOrientedPlaceForFigureFindStrategy;

        public PlaceForFigureFindStrategyFactory()
        {
            _regularyPlaceForFigureFindStrategy = new RegularyPlaceForFigureFindStrategy();
            _linesOrientedPlaceForFigureFindStrategy = new LinesOrientedPlaceForFigureFindStrategy();
        }

        public PlaceForFigureFindStrategy GetStrategy(ELevel currentLevel)
        {
            switch (currentLevel)
            {
                case ELevel.SquaresLines:
                    return _linesOrientedPlaceForFigureFindStrategy;
                default:
                    return _regularyPlaceForFigureFindStrategy;
            }
        }
    }
}
