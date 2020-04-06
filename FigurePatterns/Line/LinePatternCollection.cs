using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.Line
{
    public class LinePatternCollection : FigurePatternCollection
    {
        public LinePatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "....xxxx",
                    Height = 2,
                    Width = 4,
                    Angle = EAngel._090,
                    OffsetX = 2,
                    DiffBetweenYAndLevel = 1
                },
                new FigurePattern()
                {
                    Weight = 5,
                    Line = "...x",
                    Height = 4,
                    Width = 1,
                    Angle = EAngel._000,
                    OffsetX = 0,
                    DiffBetweenYAndLevel = 3
                },
            };
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
