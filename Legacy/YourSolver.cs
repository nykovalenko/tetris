/*-
 * #%L
 * Codenjoy - it's a dojo-like platform from developers to developers.
 * %%
 * Copyright (C) 2018 Codenjoy
 * %%
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public
 * License along with this program.  If not, see
 * <http://www.gnu.org/licenses/gpl-3.0.html>.
 * #L%
 */

using System;
using TetrisClient.Entities;
using TetrisClient.Enums;
using TetrisClient.FigurePatterns;
using TetrisClient.Helpers;
using TetrisClient.Strategies;

namespace TetrisClient
{
	/// <summary>
	/// This is Minesweeper client.
	/// </summary>
	internal class YourSolver : AbstractSolver
    {
        private readonly PlaceForFigureFindStrategy _placeForFigureFindStrategy;
        private readonly CommandGenerateStrategy _commandGenerateStrategy;
        private readonly FigurePatternCollectionFactory _figurePatternCollectionFactory;
        private readonly LevelDetermineStrategy _levelDetermineStrategy;
        private ELevel _currentLevel;

        public YourSolver(string server)
			: base(server)
		{
            _placeForFigureFindStrategy = new PlaceForFigureFindStrategy();
            _commandGenerateStrategy = new CommandGenerateStrategy();
            _figurePatternCollectionFactory = new FigurePatternCollectionFactory();
            _levelDetermineStrategy = new LevelDetermineStrategy();
            _currentLevel = ELevel.Unknown;
            Logger.InitLogger();
        }

		/// <summary>
		/// Calls each move to make decision what to do (next move)
		/// </summary>
		protected internal override Command Get(Board board)
        {
            var time = DateTime.Now;

            try
            {
                try
                {
                    var figure = new Figure(board.GetCurrentFigureType(), board.GetCurrentFigurePosition());
                    var cup = new Cup(board);

                    _currentLevel = _levelDetermineStrategy.GetLevel(_currentLevel, cup.Board.GetFutureFigures());

                    var patternCollection = _figurePatternCollectionFactory.GetPatternCollection(figure.Type, cup, _currentLevel);
                    var place = _placeForFigureFindStrategy.Find(cup, patternCollection);

                    return _commandGenerateStrategy.GenerateCommand(figure, place);
                }
                catch
                {
                    return Command.MoveTo(Direction.Down);
                }
            }
            finally
            {
                Logger.Log.Info((DateTime.Now - time).TotalMilliseconds);
            }
        }

	}



}
