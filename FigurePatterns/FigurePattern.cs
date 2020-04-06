using TetrisClient.Enums;

namespace TetrisClient.FigurePatterns
{
    public class FigurePattern
    {
        public int Weight { get; set; }
        public string Line { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public EAngel Angle { get; set; }

        public int OffsetX { get; set; }

        public int DiffBetweenYAndLevel { get; set; }
    }
}
