using TetrisClient.Enums;

namespace TetrisClient.Strategies.PlaceForFigure
{
    public class PlaceForFigureFindStrategyFactory
    {
        public PlaceForFigureFindStrategy GetStrategy(ELevel currentLevel)
        {
            return new PlaceForFigureFindStrategy();
        }
    }
}
