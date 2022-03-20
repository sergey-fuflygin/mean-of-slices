using System;

namespace MeanOfSlices.Core
{
    public struct Slice
    {
        public int Start { get; }
        public int End { get; }

        public Slice(int start, int end)
        {
            if (start < 0 || end < 0 || end < start)
            {
                throw new ArgumentOutOfRangeException($"Both {nameof(start)} and {nameof(end)} must be non-negative and {nameof(end)} must be greater or equal to {nameof(start)}");
            }
            
            Start = start;
            End = end;
        }
    }
}