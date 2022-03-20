using System;
using System.Collections.Generic;

namespace MeanOfSlices.Core
{
    public class IntArrayMeanOfSlicesCalculator : IMeanOfSlicesCalculator
    {
        private readonly int[] _array;
        private int ArrayLength => _array.Length;
        private readonly Dictionary<ArraySlice, double> _meansBySlice;
        
        public IntArrayMeanOfSlicesCalculator(int[] array)
        {
            _array = array ?? throw new ArgumentNullException(nameof(array));
            _meansBySlice = new Dictionary<ArraySlice, double>(ArrayLength * (ArrayLength + 1) / 2);
            PrecalculateSliceMeans();
        }
        
        public double GetMean(ArraySlice slice) => _meansBySlice[slice];

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
                    _meansBySlice.Add(new ArraySlice(i, j), avg);
                }
            }
        }
    }
}