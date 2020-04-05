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
using TetrisClient;
using System.Collections.Generic;
using TetrisClient.Entities;
using TetrisClient.FigurePatterns;
using TetrisClient.FigurePatterns.Square;
using TetrisClient.Strategies;

namespace TetrisClient
{
	/// <summary>
	/// This is Minesweeper client.
	/// </summary>
	internal class YourSolver : AbstractSolver
    {
        private readonly PlaceForPatternFindStrategy _placeForPatternFindStrategy;
        private readonly CommandGenerateStrategy _commandGenerateStrategy;
        private readonly FigurePatternCollectionFactory _figurePatternCollectionFactory;

        public YourSolver(string server)
			: base(server)
		{
            _placeForPatternFindStrategy = new PlaceForPatternFindStrategy();
            _commandGenerateStrategy = new CommandGenerateStrategy();
            _figurePatternCollectionFactory = new FigurePatternCollectionFactory();
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
                    var cup = new Cup(board.Line, board.Size);
                    var patternCollection = _figurePatternCollectionFactory.GetPatternCollection(figure.Type);
                    var place = _placeForPatternFindStrategy.Find(cup, patternCollection);

                    return _commandGenerateStrategy.GenerateCommand(figure, place);
                }
                catch
                {
                    return Command.MoveTo(Direction.Down);
                }
            }
            finally
            {
                Console.WriteLine((DateTime.Now - time).TotalMilliseconds);
            }
        }

	}



}
