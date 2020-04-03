using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisClient.Entities
{
    public class Cup
    {
        public Cup(string line, int lengthXY)
        {
            Line = line.Replace('O', 'x') + string.Empty.PadRight(lengthXY, 'x');
            Size = lengthXY;
        }

        public int Size { get; }
        public string Line { get; }
    }
}
