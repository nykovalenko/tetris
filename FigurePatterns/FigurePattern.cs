namespace TetrisClient.FigurePatterns
{
    public abstract class FigurePattern
    {
        public abstract int Weight { get; }
        public abstract string Line { get; }
        public abstract int Height { get; }
        public abstract int Width { get; }
    }
}
