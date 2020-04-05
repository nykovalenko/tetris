using System.Collections.Generic;

namespace TetrisClient.FigurePatterns.ZBlock
{
    public class ZBlockPatternCollection : FigurePatternCollection
    {
        public ZBlockPatternCollection()
        {
            Collection = new List<FigurePattern>();
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
