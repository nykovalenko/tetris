namespace TetrisClient.Entities
{
    public class Cup
    {
        public Cup(string line, int lengthXY)
        {
            Line = line.Replace('O', 'x').Replace('I', 'x').Replace('T', 'x').Replace('S', 'x').Replace('Z', 'x').Replace('J', 'x').Replace('L', 'x') + string.Empty.PadRight(lengthXY * 5, 'x');
            Size = lengthXY;
        }

        public int Size { get; }
        public string Line { get; }
    }
}
