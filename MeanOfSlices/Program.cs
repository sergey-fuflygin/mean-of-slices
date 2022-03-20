using System;

namespace MeanOfSlices
{
    internal static class Program
    {
        private static void Main()
        {
            int[] arr = { 1, 1, 2, 3, 1, 4 };

            var sliceMeansCalculator = new SliceMeansCalculator(arr);
            Console.WriteLine(sliceMeansCalculator.GetMean(new Slice(2, 3)));
        }
    }
}