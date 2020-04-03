namespace TetrisClient.FigurePatterns.Square
{
    public class SquarePattern : FigurePattern
    {
        public override int Weight => 10;
        public override string Line => "..xx";
        public override int Height => 2;
        public override int Width => 2;
    }
}
