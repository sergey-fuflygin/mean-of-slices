using System;

namespace MeanOfSlices.Core
{
    public struct Slice
    {
        public int Start { get; }
        public int End { get; }

        public Slice(int start, int end)
        {
            var errorMessage = $"Both '{nameof(start)}' and '{nameof(end)}' must be non-negative and '{nameof(end)}' must be greater or equal to '{nameof(start)}'";
            
            if (start < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(start), errorMessage);
            }

            if (end < 0 || end < start)
            {
                throw new ArgumentOutOfRangeException(nameof(end), errorMessage);
            }
            
            Start = start;
            End = end;
        }
    }
}