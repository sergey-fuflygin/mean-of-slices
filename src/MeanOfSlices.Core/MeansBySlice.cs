using System;
using System.Collections.Generic;

namespace MeanOfSlices.Core
{
    public class MeansBySlice
    {
        private readonly int[] _array;
        private int ArrayLength => _array.Length;
        private readonly Dictionary<Slice, double> _meansBySlice;
        
        public MeansBySlice(int[] array)
        {
            _array = array ?? throw new ArgumentNullException(nameof(array));
            _meansBySlice = new Dictionary<Slice, double>(ArrayLength * (ArrayLength + 1) / 2);
            PrecalculateSliceMeans();
        }
        
        public double this[Slice slice]
        {
            get
            {
                if (slice.Start >= ArrayLength || slice.End >= ArrayLength)
                {
                    throw new IndexOutOfRangeException("Specified slice does not belong to the array.");
                }
            
                return _meansBySlice[slice];
            }
        }

        private void PrecalculateSliceMeans()
        {
            for (var i = 0; i < ArrayLength; i++)
            {
                for (var j = i; j < ArrayLength; j++)
                {
                    var sum = 0;
                    
                    for (var k = i; k <= j; k++)
                    {
                        sum += _array[k];
                    }

                    var avg = (double)sum / (j - i + 1);
                    _meansBySlice.Add(new Slice(i, j), avg);
                }
            }
        }
    }
}