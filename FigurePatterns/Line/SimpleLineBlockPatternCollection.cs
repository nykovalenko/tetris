using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.Line
{
    public class SimpleLineBlockPatternCollection : FigurePatternCollection
    {
        public SimpleLineBlockPatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
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
