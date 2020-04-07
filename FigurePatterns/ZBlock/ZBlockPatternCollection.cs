using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.ZBlock
{
    public class ZBlockPatternCollection : FigurePatternCollection
    {
        public ZBlockPatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "x..xxx",
                    Height = 2,
                    Width = 3,
                    Angle = EAngel._000,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...xxx",
                    Height = 3,
                    Width = 2,
                    Angle = EAngel._090,
                    OffsetX = 0,
                    DiffBetweenYAndLevel = 3
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x.x",
                    Height = 3,
                    Width = 2,
                    Angle = EAngel._090,
                    OffsetX = 0,
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...xxx",
                    Height = 2,
                    Width = 3,
                    Angle = EAngel._000,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 1
                },
            };
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
