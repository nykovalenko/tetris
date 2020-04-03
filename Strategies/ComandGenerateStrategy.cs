using System;
using TetrisClient.Entities;

namespace TetrisClient.Strategies
{
    public class CommandGenerateStrategy
    {
        public Command GenerateCommand(Figure figure, PlaceForPattern placeForPattern)
        {
            var dif = figure.CurrentPoint.X - placeForPattern.Point.X;

            if (dif == 0)
                return Command.MoveTo(Direction.Down);

            var direction = dif > 0 ? Direction.Left : Direction.Right;
            var result = Command.MoveTo(direction);
            for (var i = 1; i < Math.Abs(dif); i++)
            {
                result = result.Combine(Command.MoveTo(direction));
            }

            return result.Combine(Command.MoveTo(Direction.Down));
        }
    }
}
