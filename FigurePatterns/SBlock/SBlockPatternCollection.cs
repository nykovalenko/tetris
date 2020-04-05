﻿using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.SBlock
{
    public class SBlockPatternCollection : FigurePatternCollection
    {
        public SBlockPatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..x",
                    Height = 1,
                    Width = 3,
                    Angle = EAngel._000,
                    OffsetX = 1
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..x.",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._090,
                    OffsetX = 0
                }
            };
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}