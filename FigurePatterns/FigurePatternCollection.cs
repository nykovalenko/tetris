using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisClient.FigurePatterns
{
    public abstract class FigurePatternCollection
    {
        public abstract IEnumerable<FigurePattern> Collection { get; }
    }
}
