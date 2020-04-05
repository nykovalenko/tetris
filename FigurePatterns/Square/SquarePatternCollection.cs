﻿using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.Square
{
    public class SquarePatternCollection : FigurePatternCollection
    {
        public SquarePatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..xx",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._000,
                    OffsetX = 0,
                    OffsetY = 0
                }
            };
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
