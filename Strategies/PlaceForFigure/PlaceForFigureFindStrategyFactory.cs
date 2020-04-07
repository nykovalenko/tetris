using TetrisClient.Enums;

namespace TetrisClient.Strategies.PlaceForFigure
{
    public class PlaceForFigureFindStrategyFactory
    {
        public RegularyPlaceForFigureFindStrategy GetStrategy(ELevel currentLevel)
        {
            return new RegularyPlaceForFigureFindStrategy();
        }
    }
}
