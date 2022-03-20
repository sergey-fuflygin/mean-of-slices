namespace MeanOfSlices
{
    public struct Slice
    {
        public int Start { get; }
        public int End { get; }

        public Slice(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}