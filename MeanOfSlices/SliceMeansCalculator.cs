using System.Collections.Generic;

namespace MeanOfSlices
{
    public class SliceMeansCalculator : ISliceMeansCalculator
    {
        private readonly int[] _array;
        private int ArrayLength => _array.Length;
        private readonly Dictionary<Slice, double> _sliceMeans;
        
        public SliceMeansCalculator(int[] array)
        {
            _array = array;
            _sliceMeans = new Dictionary<Slice, double>(ArrayLength * (ArrayLength + 1) / 2);
            CalculateSliceMeans();
        }
        
        public double GetMean(Slice slice)
        {
            return _sliceMeans[slice];
        }

        private void CalculateSliceMeans()
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
                    _sliceMeans.Add(new Slice(i, j), avg);
                }
            }
        }
    }
}