using System;
using System.Collections.Generic;
using System.Linq;

namespace MeanOfSlices.Core
{
    public class MeansBySlice
    {
        private readonly int[] _array;
        private int ArrayLength => _array.Length;
        private readonly Dictionary<Slice, double> _meansBySlice; //cache for faster access

        private const int CacheSize = 50000000;
        private const int CacheThreshold = 1000000;
        
        public MeansBySlice(int[] array)
        {
            _array = array ?? throw new ArgumentNullException(nameof(array));
            _meansBySlice = new Dictionary<Slice, double>(CacheSize);
        }
        
        public double this[Slice slice]
        {
            get
            {
                if (slice.Start >= ArrayLength || slice.End >= ArrayLength)
                {
                    throw new IndexOutOfRangeException("Specified slice does not belong to the array.");
                }

                return GetMean(slice);
            }
        }

        private double GetMean(Slice slice)
        {
            //Verify and return if we already calculated a mean for the slice
            if (_meansBySlice.ContainsKey(slice))
            {
                return _meansBySlice[slice];
            }

            //Otherwise calculate it
            var count = slice.End - slice.Start + 1;
            var avg = 0.0;
                
            for (var k = slice.Start; k <= slice.End; k++)
            {
                avg += (double)_array[k] / count;
            }

            //Clear the cache if it is close to the limit
            if (_meansBySlice.Count > CacheSize - CacheThreshold)
            {
                _meansBySlice.Clear();
            }
            
            //And add to the cache
            _meansBySlice.Add(slice, avg);
            
            return avg;
        }
    }
}