using System.Collections.Generic;

namespace TetrisClient.FigurePatterns.TBlock
{
    public class TBlockPatternCollection : FigurePatternCollection
    {
        public TBlockPatternCollection()
        {
            Collection = new List<FigurePattern>();
        }

        public override IEnumerable<FigurePattern> Collection { get; }
    }
}
