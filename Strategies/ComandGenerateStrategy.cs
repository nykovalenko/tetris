using System;
using TetrisClient.Entities;
using TetrisClient.Enums;

namespace TetrisClient.Strategies
{
    public class CommandGenerateStrategy
    {
        public Command GenerateCommand(Figure figure, Entities.PlaceForFigure placeForFigure)
        {
            try
            {
                var dif = figure.CurrentPoint.X - placeForFigure.FigurePointX;

                if (dif == 0)
                {
                    return placeForFigure.FigureAngel == EAngel._000
                        ? Command.MoveTo(Direction.Down)
                        : GetRotationCommand(placeForFigure.FigureAngel).Combine(Command.MoveTo(Direction.Down));
                }

                var direction = dif > 0 ? Direction.Left : Direction.Right;

                var result = placeForFigure.FigureAngel == EAngel._000
                    ? Command.MoveTo(direction)
                    : GetRotationCommand(placeForFigure.FigureAngel).Combine(Command.MoveTo(direction));

                for (var i = 1; i < Math.Abs(dif); i++)
                {
                    result = result.Combine(Command.MoveTo(direction));
                }

                return result.Combine(Command.MoveTo(Direction.Down));
            }
            catch
            {
                return Command.MoveTo(Direction.Down);
            }
        }

        private Command GetRotationCommand(EAngel angel)
        {
            switch (angel)
            {
                case EAngel._090:
                    return Command.Rotate90();
                case EAngel._180:
                    return Command.Rotate180();
                case EAngel._270:
                    return Command.Rotate270();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
