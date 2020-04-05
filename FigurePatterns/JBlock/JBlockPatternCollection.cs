using System.Collections.Generic;
using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns.JBlock
{
    public class JBlockPatternCollection : FigurePatternCollection
    {
        public JBlockPatternCollection()
        {
            Collection = new List<FigurePattern>()
            {
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...xx.",
                    Height = 2,
                    Width = 3,
                    Angle = EAngel._270,
                    OffsetX = 1
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x.x",
                    Height = 3,
                    Width = 2,
                    Angle = EAngel._180,
                    OffsetX = 0
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...xxx",
                    Height = 2,
                    Width = 3,
                    Angle = EAngel._090,
                    OffsetX = 1
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..xx",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._000,
                    OffsetX = 1
                },
            };
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
