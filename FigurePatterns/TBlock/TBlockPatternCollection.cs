using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.TBlock
{
    public class TBlockPatternCollection : FigurePatternCollection
    {
        public TBlockPatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x.x",
                    Height = 2,
                    Width = 3,
                    Angle = EAngel._180,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._090,
                    OffsetX = 0,
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..x.",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._270,
                    OffsetX = 1,
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
