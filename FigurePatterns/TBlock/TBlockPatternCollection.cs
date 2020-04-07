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
                    Line = "x...xxx.xxxxxxx",
                    Height = 3,
                    Width = 5,
                    Angle = EAngel._180,
                    OffsetX = 2,
                    DiffBetweenYAndLevel = 5
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "x...xx.xxxxx",
                    Height = 3,
                    Width = 4,
                    Angle = EAngel._180,
                    OffsetX = 2,
                    DiffBetweenYAndLevel = 4
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...xx.xxxxxx",
                    Height = 3,
                    Width = 4,
                    Angle = EAngel._180,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 4
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x.xxxx",
                    Height = 3,
                    Width = 3,
                    Angle = EAngel._180,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x.xxx.",
                    Height = 3,
                    Width = 3,
                    Angle = EAngel._180,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x.x.xx",
                    Height = 3,
                    Width = 3,
                    Angle = EAngel._180,
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
                    DiffBetweenYAndLevel = 2
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..x.xx",
                    Height = 3,
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
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "...x",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._090,
                    OffsetX = 0,
                    DiffBetweenYAndLevel = 1
                },
                new FigurePattern()
                {
                    Weight = 10,
                    Line = "..x.",
                    Height = 2,
                    Width = 2,
                    Angle = EAngel._270,
                    OffsetX = 1,
                    DiffBetweenYAndLevel = 1
                },
            };
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
