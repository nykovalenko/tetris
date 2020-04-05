namespace TetrisClient.Entities
{
    public class Cup
    {
        public Cup(Board board)
        {
            Line = board.Line.Replace('O', 'x').Replace('I', 'x').Replace('T', 'x').Replace('S', 'x').Replace('Z', 'x').Replace('J', 'x').Replace('L', 'x') + string.Empty.PadRight(board.Size * 5, 'x');
            Size = board.Size;
            Board = board;
        }

        public Board Board { get; }
        public int Size { get; }
        public string Line { get; }
    }
}
