// ReSharper disable NotAccessedField.Local

using System;

namespace MeanOfSlices.Core
{
    public struct ArraySlice
    {
        private readonly int _start;
        private readonly int _end;

        public ArraySlice(int start, int end)
        {
            if (start < 0 || end < 0 || end < start)
            {
                throw new ArgumentOutOfRangeException($"Both {nameof(start)} and {nameof(end)} must be non-negative and {nameof(end)} must be greater or equal to {nameof(start)}");
            }
            
            _start = start;
            _end = end;
        }
    }
}